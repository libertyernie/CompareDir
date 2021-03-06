﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CompareDir {
	public partial class MainForm : Form {
		private DirectoryInfo dirL, dirR, dirC;

		private List<IRow> rows;
		private bool recursive;
		public static string COMMAND_LINE_ARGS = @"Usage: CompareDir [-g/-fhirx] [--openwith={PATH}] [left right [center]]

-g: use GUI for everything (overrides all other options)
    If no arguments are given, -g will be assumed.

-i: use GUI to ask for directories and recursive setting (overrides -r)
    If no directories are given, but -g is off, -i will be assumed.

-f: show only filenames, not relative paths
-h: output as color-coded HTML instead of plain text
-r: search recursively
-x: write to (and launch) a file on the desktop
--openwith={PATH}: assume -x but use the program {PATH} to open the file

-a: display About dialog
-l: print license terms to stdout";

		public MainForm(DirectoryInfo dir1, DirectoryInfo dir2, DirectoryInfo dir3,
						bool? recursiveOverride = null) {
			this.dirL = dir1;
			this.dirR = dir2;
			this.dirC = dir3;
			InitializeComponent();

			using (Form loading = new Loading("Select directory")) {
				loading.Show();
				if (dir1 == null || dir2 == null) {
					bool b = StartupOptions.ChangeLeftRight(loading, ref dirL, ref dirR);
					if (!b) Environment.Exit(0);
					if (dir3 == null) {
						StartupOptions.ChangeCenter(loading, ref dirC);
					}
				}
				if (recursiveOverride != null) {
					recursive = recursiveOverride.Value;
				} else {
					StartupOptions.AskRecursive(loading, ref recursive);
				}
				refreshTable(loading);
			}
		}

		private void refreshTable(IWin32Window parent) {
			if (dirL == null || dirR == null) return;

			table.AutoScroll = false;

			this.rows = generate(dirL, dirR, dirC, recursive, true, false);

			if (rows.Count > 100) {
				var dr = MessageBox.Show(parent,
					"There are more than 100 files, so building the GUI could take a while. Would you like to export to HTML instead?",
					"Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (dr == DialogResult.Yes) {
					hTMLToolStripMenuItem.PerformClick();
					return;
				} else if (dr == DialogResult.Cancel) {
					return;
				}
			}

			bool showMiddleColumn = anyInCenter(rows);

			table.Controls.Clear();
			foreach (IRow row in rows) {
				row.AddTo(table);
			}

			// If all three columns are shown, use 1/3 width for all. If only two are shown, use 50% for 1st and 3rd (hide center column.)
			int j = 0;
			foreach (ColumnStyle style in table.ColumnStyles)
			{
				style.SizeType = SizeType.Percent;
				style.Width =
					(showMiddleColumn) ? 100f / 3 :
					(j == 1) ? 0f :
					50f;
				j++;
			}

			table.RowStyles.Clear();
			for (int i = 0; i < rows.Count; i++){
				table.RowStyles.Add(new RowStyle() {
					SizeType = SizeType.AutoSize
				});
			}

			table.AutoScroll = true;
		}

		public static List<IRow> generate(DirectoryInfo dirL, DirectoryInfo dirR, DirectoryInfo dirC,
										  bool recursive, bool filenameOnly, bool textOnly) {
			var filenamesL = dirL.EnumerateFiles("*.*", recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
							.Select(f => RelativePath(f.FullName, dirL.FullName));
			var filenamesR = dirR.EnumerateFiles("*.*", recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
							.Select(f => RelativePath(f.FullName, dirR.FullName));
			var filenames = filenamesL.Concat(filenamesR)
							.Distinct(StringComparer.CurrentCultureIgnoreCase)
							.OrderBy(s => s);

			IMatchProgress mp = textOnly ? (IMatchProgress)new MatchProgressConsole() : new MatchProgressWindow();
			mp.Begin(0, filenames.Count(), 0);

			List<IRow> rows = new List<IRow>();
			rows.Add(new HeaderRow()
			{
				Left = filenameOnly ? dirL.Name :
					   dirL.FullName,
				Center = dirC == null ? null :
						 filenameOnly ? dirC.Name :
						 dirC.FullName,
				Right = filenameOnly ? dirR.Name :
						dirR.FullName
			});
			foreach (string s in filenames) {
				IRow row;
				try {
					FileLabel left = new FileLabel(dirL, s, filenameOnly) { TextAlign = ContentAlignment.MiddleRight };
					FileLabel center = new FileLabel(dirC, s, filenameOnly) { TextAlign = ContentAlignment.MiddleCenter };
					FileLabel right = new FileLabel(dirR, s, filenameOnly) { TextAlign = ContentAlignment.MiddleLeft };
					row = new FileLabelRow(left, center, right);
					rows.Add(row);
					switch (((FileLabelRow)row).LeftRightMatches) {
						case FileLabelRow.MatchStatus.MATCH:
							mp.MatchCount++;
							break;
						case FileLabelRow.MatchStatus.NO_MATCH:
							mp.NoMatchCount++;
							break;
						case FileLabelRow.MatchStatus.ONLY_LEFT:
							mp.OnlyLeftCount++;
							break;
						case FileLabelRow.MatchStatus.ONLY_RIGHT:
							mp.OnlyRightCount++;
							break;
					}
				} catch (IOException e) {
					// Could not read file
					row = new NoteRow(e, s);
					rows.Add(row);
					mp.ErrorCount++;
				}

				mp.Increment();
				if (mp.Cancelled) break;
			}

			IRow r = new NoteRow(String.Format("{0} files: {1} matches, {2} non-matches - {3} only in left, {4} only in right - {5} errors",
					mp.TotalCount, mp.MatchCount, mp.NoMatchCount, mp.OnlyLeftCount, mp.OnlyRightCount, mp.ErrorCount));
			rows.Add(r);

			mp.Finish();

			return rows;
		}

		private static string RelativePath(string p, string dir) {
			string path = p;
			if (p.StartsWith(dir)) {
				p = p.Substring(dir.Length);
			}
			if (p[0] == '/' || p[0] == '\\') {
				p = p.Substring(1);
			}
			return p;
		}

		public static string report(IEnumerable<IRow> rows) {
			StringBuilder sb = new StringBuilder();
			int maxlength = (from r in rows select r.FindMaxLength()).Max();
			foreach (IRow row in rows) {
				sb.AppendLine(row.ToString(maxlength));
			}
			return sb.ToString();
		}

		public static string html(IEnumerable<IRow> rows) {
			int columns = anyInCenter(rows) ? 3 : 2;
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<html>");
			sb.AppendLine("<head>");
			sb.AppendLine("<title>CompareDir</title>");
			sb.AppendLine("</head>");
			sb.AppendLine("<body>");
			sb.AppendLine("<table>");
			foreach (IRow row in rows) {
				sb.AppendLine(row.HTMLTableRow(columns));
			}
			sb.AppendLine("</table>");
			sb.AppendLine("</body>");
			sb.AppendLine("</html>");
			return sb.ToString();
		}

		private static bool anyInCenter(IEnumerable<IRow> rows) {
			return (from s in rows
					where s is FileLabelRow
					&& ((FileLabelRow)s).Center.Text.Length > 0
					select s).Any();
		}

		private void changeLeftRightItem_Click(object sender, EventArgs e) {
			if (StartupOptions.ChangeLeftRight(this, ref dirL, ref dirR)) {
				StartupOptions.AskRecursive(this, ref recursive);
				refreshTable(this);
			}
		}

		private void changeCenterItem_Click(object sender, EventArgs e) {
			StartupOptions.ChangeCenter(this, ref dirC);
			refreshTable(this);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void aboutCompareDirToolStripMenuItem_Click(object sender, EventArgs e) {
			new About(null).ShowDialog(this);
		}

		private void plainText2ColumnsToolStripMenuItem_Click(object sender, EventArgs e) {
			using (SaveFileDialog d = new SaveFileDialog()) {
				d.Filter = "Plain text (*.txt)|*.txt";
				d.DefaultExt = "txt";
				d.AddExtension = true;
				if (d.ShowDialog(this) == DialogResult.OK) {
					File.WriteAllText(d.FileName, report(rows));
				}
			}
		}

		private void hTMLToolStripMenuItem_Click(object sender, EventArgs e) {
			using (SaveFileDialog d = new SaveFileDialog()) {
				d.Filter = "HTML document (*.html, *.htm)|*.*html;*.htm";
				d.DefaultExt = "html";
				d.AddExtension = true;
				if (d.ShowDialog(this) == DialogResult.OK) {
					File.WriteAllText(d.FileName, html(rows));
					System.Diagnostics.Process.Start(d.FileName);
				}
			}
		}

		private void filenamesOnlyToolStripMenuItem_Click(object sender, EventArgs e) {
			bool v = ((ToolStripMenuItem)sender).Checked;
			foreach (IRow row in rows) {
				if (row is FileLabelRow) {
					((FileLabelRow)row).FilenameOnly = v;
				}
			}
			this.Update();
		}

		private void commandLineArgumentsToolStripMenuItem_Click(object sender, EventArgs e) {
			using (Form form = new Form()) {
				form.Width = 400;
				form.Height = 250;
				using (TextBox textBox = new TextBox()) {
					textBox.Dock = DockStyle.Fill;
					textBox.Text = COMMAND_LINE_ARGS;
					textBox.Multiline = true;
					form.Controls.Add(textBox);
					form.ShowDialog(this);
				}
			}
		}
	}
}
