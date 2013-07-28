using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Drawing;

namespace CompareDir
{
    public class FileLabel {
        private static MD5 md5 = new MD5CryptoServiceProvider();

        public FileInfo File { get; private set; }
        public byte[] MD5 { get; private set; }
        public Label Label { get; private set; }
        public ContentAlignment TextAlign { get { return Label.TextAlign; } set { Label.TextAlign = value; } }

		public static readonly Tuple<Color, Color> Color_Match   = new Tuple<Color, Color>(Color.FromArgb(64, 128, 64), Color.FromArgb(96, 192, 96));
		public static readonly Tuple<Color, Color> Color_NoMatch = new Tuple<Color, Color>(Color.FromArgb(160, 64, 64), Color.FromArgb(240, 96, 96));
		public static readonly Tuple<Color, Color> Color_OnlyOne = new Tuple<Color, Color>(Color.FromArgb(64, 128, 192), Color.FromArgb(96, 192, 255));
		public static readonly Tuple<Color, Color> Color_Orig = new Tuple<Color, Color>(Color.FromArgb(128, 128, 128), Color.FromArgb(192, 192, 192));

		private string originalFilename;

		private Tuple<Color, Color> _colors;
        public Tuple<Color, Color> Colors
        {
            get
            {
                return _colors;
            }
            set
            {
                _colors = value;
                if (Label != null) Label.BackColor = _colors.Item1;
            }
        }

		public string Text {
			get {
				return Label.Text;
			}
		}

		public bool FilenameOnly {
			set {
				if (this.MD5 != null && originalFilename != null) {
					Label.Text = (value ? File.Name : originalFilename);
				}
			}
		}

		public FileLabel(DirectoryInfo dir, string filename, bool filenameOnly = false)
            : this(dir == null ? null : new FileInfo(dir.FullName + "\\" + filename)) {
				this.originalFilename = filename;
				this.FilenameOnly = filenameOnly;
		}

        public FileLabel(FileInfo f)
        {
            Label = new Label() {
                BorderStyle = BorderStyle.FixedSingle,
                Margin = Padding.Empty,
                Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold)
            };
            this.File = f;
            if (f != null && !f.Exists)
            {
                string s = f.Directory.FullName + "\\" + f.Name.Replace(".", "_en.");
                if (System.IO.File.Exists(s))
                {
                    f = new FileInfo(s);
                }
            }
            if (f != null && f.Exists)
            {
                this.MD5 = md5.ComputeHash(System.IO.File.ReadAllBytes(f.FullName));
				Label.Text = f.Name;

                Label.Click += new EventHandler(FileLabel_Click);
                Label.MouseEnter += new EventHandler(Label_MouseEnter);
                Label.MouseLeave += new EventHandler(Label_MouseLeave);
            }
        }

        void FileLabel_Click(object sender, EventArgs ea)
        {
			MouseEventArgs e = ea as MouseEventArgs;
			if (e == null) return;

			if (e.Button == MouseButtons.Left) {
				Form fd = new FileDisplay(this);
				fd.Show();
			} else if (e.Button == MouseButtons.Right) {
				BrawlLib.BrawlView(File.FullName);
			}
        }

        void Label_MouseEnter(object sender, EventArgs e)
        {
            Label.BackColor = _colors.Item2;
        }

        void Label_MouseLeave(object sender, EventArgs e)
        {
            Label.BackColor = _colors.Item1;
        }
    }
}
