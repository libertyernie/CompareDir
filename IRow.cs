using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CompareDir {
	public interface IRow {
        int FindMaxLength();
        string ToString(int maxFilenameLength);
        void AddTo(TableLayoutPanel table, int rows = 1);
		//void FillSpreadsheetRow(IRow row, int columns);
		string HTMLTableRow(int columns);
	}

	public class NoteRow : IRow {
		public string Message { get; private set; }

		public NoteRow(string m) {
			Message = m;
		}

		public NoteRow(Exception e, string s)
			: this (s + ": " + e.GetType() + " - " + e.Message) {}

        public int FindMaxLength() {
            return 0;
        }

		public string ToString(int maxFilenameLength) {
			return Message;
		}

		public override string ToString() {
			return Message;
		}

		public void AddTo(TableLayoutPanel table, int rows) {
			Label l = new Label() {
				Text = Message,
				BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
				Dock = DockStyle.Fill,
				TextAlign = ContentAlignment.TopCenter,
				Margin = Padding.Empty
			};
			table.Controls.Add(l);
			table.SetColumnSpan(l, 3);
            if (rows > 1) table.SetRowSpan(l, rows);
		}

		/*public void FillSpreadsheetRow(IRow row, int columns) {
			ICell cL = row.CreateCell(0);
			cL.SetCellValue(Message);
		}*/

		public string HTMLTableRow(int columns) {
			if (columns < 2 || columns > 3) {
				throw new IndexOutOfRangeException("Table must have 2 or 3 columns");
			}
			return String.Format("<tr><td align=center colspan={0}>{1}</td></tr>", columns, Message);
		}
	}

    public class HeaderRow : IRow {
        public string Left;
        public string Center;
        public string Right;

        public int FindMaxLength() {
            //return 0;
            return (Left.Length > Right.Length ? Left.Length : Right.Length);
        }

        public string ToString(int maxFilenameLength) {
            //return "Comparing " + Left + " with " + Right;
            return new string(' ', maxFilenameLength - Left.Length) + Left + " | " + Right;
        }

        public void AddTo(TableLayoutPanel table, int rows) {
            // Do nothing - header does not appear on table
        }

        public string HTMLTableRow(int columns) {
            if (columns < 2 || columns > 3) {
                throw new IndexOutOfRangeException("Table must have 2 or 3 columns");
            }
            return "<tr>" +
                "<th>" + Left + "</th>" +
                (columns == 3 ? "<th>" + Center + "</th>" : "") +
                "<th>" + Right + "</th>" +
                "</tr>";
        }
    }
}
