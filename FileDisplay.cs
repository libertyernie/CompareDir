using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareDir
{
	public partial class FileDisplay : Form {
		private static string[] BrawlExts = { ".pac", ".pcs", ".brres", ".tex0", ".plt0", ".mdl0", ".brsar", ".brstm" };

		private string _path;
		private string _dir;
		private IDisposable node;

		public FileDisplay(FileLabel fl) {
			InitializeComponent();
			this.AcceptButton = btnOkay;

			_path = fl.File.FullName;
			_dir = fl.File.DirectoryName;
			this.Text = lblName2.Text = fl.File.Name;
			lblSize2.Text = fl.File.Length.ToString("#,##0") + " bytes";
			lblModified2.Text = fl.File.LastWriteTime.ToString();
			StringBuilder sb = new StringBuilder(fl.MD5.Length * 2);
			foreach (byte b in fl.MD5) {
				sb.Append(b.ToString("X2"));
			}
			lblMD52.Text = sb.ToString();

			if (BrawlExts.Any(ext => _path.EndsWith(ext, StringComparison.InvariantCultureIgnoreCase))) {
				button1.Visible = (BrawlLib.BrawlViewPath != null);
			}
		}

		private static bool isPrintable(int c) {
			return (c > 0x20 && c < 0x80);
		}

		private void btnOkay_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnOpenFile_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(_path);
		}

		private void btnOpenLocation_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(_dir);
		}

		private void button1_Click(object sender, EventArgs e) {
			BrawlLib.BrawlView(_path);
		}
	}
}
