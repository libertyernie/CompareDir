using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CompareDir {
	public class FileLabelRow : IRow {
		public enum MatchStatus {
			MATCH,
			NO_MATCH,
			ONLY_LEFT,
			ONLY_RIGHT
		}

		public FileLabel Left { get; private set; }
		public FileLabel Center { get; private set; }
		public FileLabel Right { get; private set; }

		public MatchStatus LeftRightMatches { get; private set; }
		public bool CenterMatchesLeft { get; private set; }
		public bool CenterMatchesRight { get; private set; }

		public FileLabelRow(FileLabel left, FileLabel center, FileLabel right) {
			Left = left;
			Center = center;
			Right = right;

			if (Left.MD5 == null && Right.MD5 != null) {
				LeftRightMatches = MatchStatus.ONLY_RIGHT;
			} else if (Left.MD5 != null && Right.MD5 == null) {
				LeftRightMatches = MatchStatus.ONLY_LEFT;
			} else if (Left.MD5 != null && Right.MD5 != null) {
				if (byteArrayEquals(Left.MD5, Right.MD5)) {
					LeftRightMatches = MatchStatus.MATCH;
				} else {
					LeftRightMatches = MatchStatus.NO_MATCH;
				}
			} else {
				throw new System.IO.FileNotFoundException("File not found in either directory: " + Left.File.Name);
			}

			CenterMatchesLeft = Center.MD5 != null && Left.MD5 != null && byteArrayEquals(Center.MD5, Left.MD5);
			CenterMatchesRight = Center.MD5 != null && Right.MD5 != null && byteArrayEquals(Center.MD5, Right.MD5);

			switch (LeftRightMatches) {
				case MatchStatus.ONLY_RIGHT:
					right.Colors = (FileLabel.Color_OnlyOne);
					break;
				case MatchStatus.ONLY_LEFT:
					left.Colors = (FileLabel.Color_OnlyOne);
					break;
				case MatchStatus.MATCH:
					left.Colors = (FileLabel.Color_Match);
					right.Colors = (FileLabel.Color_Match);
					break;
				case MatchStatus.NO_MATCH:
					left.Colors = (FileLabel.Color_NoMatch);
					right.Colors = (FileLabel.Color_NoMatch);
					break;
			}

			if (Center.MD5 != null) {
				center.Colors = (FileLabel.Color_Orig);
				if (CenterMatchesLeft) {
					left.Colors = (FileLabel.Color_Orig);
				}
				if (CenterMatchesRight) {
					right.Colors = (FileLabel.Color_Orig);
				}
			}
		}

		public int FindMaxLength() {
			int l = Left.Text.Length;
			int r = Right.Text.Length;
			return (l > r ? l : r);
		}

		public string ToString(int maxFilenameLength) {
			string s = String.IsNullOrWhiteSpace(Left.Text) ? Right.Text : Left.Text;
			string s_pad = "";
			if (maxFilenameLength - s.Length > 0) {
				s_pad = new string(' ', maxFilenameLength - s.Length);
			}

			switch (LeftRightMatches) {
				case MatchStatus.MATCH:
					return (s_pad + s + " = " + s);
				case MatchStatus.NO_MATCH:
					return (s_pad + s + " X " + s);
				case MatchStatus.ONLY_LEFT:
					return (s_pad + s + new string(' ', maxFilenameLength + 3));
				case MatchStatus.ONLY_RIGHT:
					return (new string(' ', maxFilenameLength + 3) + s);
			}

			throw new Exception(s);
		}

		public override string ToString() {
			return ToString(0);
		}

		public void AddTo(TableLayoutPanel table, int rows) {
			table.Controls.Add(Left.Label);
			table.Controls.Add(Center.Label);
			table.Controls.Add(Right.Label);
			Left.Label.Dock = Center.Label.Dock = Right.Label.Dock = DockStyle.Fill;
			if (rows > 1) {
				table.SetRowSpan(Left.Label, rows);
				table.SetRowSpan(Center.Label, rows);
				table.SetRowSpan(Right.Label, rows);
			}
		}

		/*public static void setBGColor(ICell cell, FileLabel l) {
			// Get the color
			if (l.Colors == null) return;
			Color c = l.Colors.Item1;

			// Get the workbook
			HSSFWorkbook workbook = cell.Row.Sheet.Workbook as HSSFWorkbook;

			// Create a new cell style
			ICellStyle style = workbook.CreateCellStyle();
			style.FillForegroundColor = workbook.GetCustomPalette().FindSimilarColor(c.R, c.G, c.B).GetIndex();
			style.FillPattern = FillPatternType.SOLID_FOREGROUND;

			// Apply the style
			cell.CellStyle = style;
		}

		public void FillSpreadsheetRow(IRow row, int columns) {
			ICell cL = row.CreateCell(0);
			cL.SetCellValue(Left.Text);
			setBGColor(cL, Left);

			if (columns >= 3) {
				ICell cC = row.CreateCell(1);
				cC.SetCellValue(Center.Text);
				setBGColor(cC, Center);
			}

			ICell cR = row.CreateCell(columns-1);
			cR.SetCellValue(Right.Text);
			setBGColor(cR, Right);
		}*/

		public string HTMLTableRow(int columns) {
			if (columns < 2 || columns > 3) {
				throw new IndexOutOfRangeException("Table must have 2 or 3 columns");
			}
			StringBuilder sb = new StringBuilder();
			sb.Append("<tr>");
			sb.AppendFormat("<td{0} align=right>{1}</td>", Left.Colors != null ? " bgcolor=" + ColorTranslator.ToHtml(Left.Colors.Item1) : "", Left.Text);
			if (columns == 3) sb.AppendFormat("<td{0} align=center>{1}</td>", Center.Colors != null ? " bgcolor=" + ColorTranslator.ToHtml(Center.Colors.Item1) : "", Center.Text);
			sb.AppendFormat("<td{0}>{1}</td>", Right.Colors != null ? " bgcolor=" + ColorTranslator.ToHtml(Right.Colors.Item1) : "", Right.Text);
			sb.Append("</tr>");
			return sb.ToString();
		}

		public static bool byteArrayEquals(byte[] b1, byte[] b2) {
			for (int i = 0; i < b1.Length; i++) {
				if (b1[i] != b2[i]) return false;
			}
			return true;
		}
	}
}
