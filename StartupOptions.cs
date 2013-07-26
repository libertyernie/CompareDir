using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CompareDir {
	public class StartupOptions {
		public static FolderBrowserDialog browser = new FolderBrowserDialog();

		public static bool ChangeLeftRight(IWin32Window parent, ref DirectoryInfo dirL, ref DirectoryInfo dirR) {
			browser.Description = "Left comparison folder:";
			if (dirL != null) browser.SelectedPath = dirL.FullName;
			if (browser.ShowDialog(parent) != DialogResult.OK) {
				return false;
			}
			DirectoryInfo newdir1 = new DirectoryInfo(browser.SelectedPath);
			browser.Description = "Right comparison folder:";
			if (dirR != null) browser.SelectedPath = dirR.FullName;
			if (browser.ShowDialog(parent) != DialogResult.OK) {
				return false;
			}
			DirectoryInfo newdir2 = new DirectoryInfo(browser.SelectedPath);

			dirL = newdir1;
			dirR = newdir2;

			return true;
		}

		public static void ChangeCenter(IWin32Window parent, ref DirectoryInfo dirC) {
			browser.Description = "Center folder (optional):";
			browser.SelectedPath = (dirC != null ? dirC.FullName : null);
			if (browser.ShowDialog(parent) == DialogResult.OK) {
				dirC = new DirectoryInfo(browser.SelectedPath);
			} else {
				dirC = null;
			}
		}

		public static void AskRecursive(IWin32Window parent, ref bool recursive) {
			var dr = MessageBox.Show(parent, "Do a recursive search?", "",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					recursive ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2);
			recursive = (dr == DialogResult.Yes);
		}
	}
}
