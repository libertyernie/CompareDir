using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections.Generic;

namespace CompareDir
{
    public static class Program
    {
		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] args) {
			DirectoryInfo dir1 = null, dir2 = null, dirC = null;
			bool gui = false;
			bool recursive = false, filenameOnly = false, html = false, execute = false, interactive = false;

			foreach (string s in args) {
				if (s == "--help" || s == "/?" || s == "/c") {
					return usage(0);
				} else if (s == "-l") {
					Console.Error.WriteLine(About.License);
					return 0;
				} else if (s == "-a") {
					new About().ShowDialog();
					return 0;
				} else if (s == "-g") {
					gui = true;
				} else if (s[0] == '-') {
					foreach (char c in s.Substring(1)) {
						if (c == 'r') {
							recursive = true;
						} else if (c == 'f') {
							filenameOnly = true;
						} else if (c == 'h') {
							html = true;
						} else if (c == 'x') {
							execute = true;
						} else if (c == 'i') {
							interactive = true;
						} else {
							Console.Error.WriteLine("Unrecognized parameter: -" + c);
							return usage(1);
						}
					}
				} else {
					if (dir1 == null) {
						dir1 = new DirectoryInfo(s);
					} else if (dir2 == null) {
						dir2 = new DirectoryInfo(s);
					} else if (dirC == null) {
						dirC = new DirectoryInfo(s);
					} else {
						Console.Error.WriteLine("Too many parameters: " + s);
						return usage(1);
					}
				}
			}

			if (gui || args.Length == 0) {
				IntPtr handle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
				ShowWindow(handle, 0);

				Application.Run(new MainForm(dir1, dir2, dirC));
				return 0;
			} else {
				interactive = interactive || dir2 == null;
				if (interactive) {
					IntPtr handle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
					ShowWindow(handle, 0);

					using (Form loading = new Loading("Select directory")) {
						loading.Show();
						if (dir2 == null) {
							var r = StartupOptions.ChangeLeftRight(loading, ref dir1, ref dir2);
							if (!r) return 0;
						}
						if (dirC == null && html) {
							StartupOptions.ChangeCenter(loading, ref dirC);
						} else if (dirC != null && !html) {
							Console.Error.WriteLine("Plain text output only supports two directories");
							return usage(1);
						}
						StartupOptions.AskRecursive(loading, ref recursive);
					}
				}

				var rows = MainForm.generate(dir1, dir2, dirC, recursive, filenameOnly, !interactive);
				string report = html ? MainForm.html(rows) : MainForm.report(rows);
				if (execute) {
					string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					string file = dir + "\\Comparison." + (html ? "html" : "txt");
					File.WriteAllText(file, report);
					System.Diagnostics.Process.Start(file);
				} else {
					Console.WriteLine(report);
				}
				return 0;
			}
        }

		private static int usage(int returnValue) {
			Console.Error.WriteLine("Usage: CompareDir [-g/-fhirx] [left right [center]]");
			Console.Error.WriteLine("  -g: use GUI for everything (overrides all other options)");
			Console.Error.WriteLine("  -i: use GUI to ask for directories and recursive setting (overrides -r)");
			Console.Error.WriteLine("  -r: search recursively");
			Console.Error.WriteLine("  -f: show only filenames, not relative paths");
			Console.Error.WriteLine("  -h: output as color-coded HTML instead of plain text");
			Console.Error.WriteLine("  -x: write to (and launch) a file on the desktop");
			Console.Error.WriteLine("");
			Console.Error.WriteLine("  -a: display About dialog");
			Console.Error.WriteLine("  -l: display license terms");
			Console.Error.WriteLine("");
			Console.Error.WriteLine("  If less than two directories are given, -i will be assumed; if no arguments are given, -g will be assumed.");
			return returnValue;
		}
    }
}
