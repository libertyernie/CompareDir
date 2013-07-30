using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace CompareDir {
	public class BrawlLib {
		public static string BrawlViewPath = null;

		static BrawlLib() {
			string[] bvsearch = { "BrawlView.exe", Path.GetDirectoryName(Application.ExecutablePath) + "/BrawlView.exe" };
			foreach (string s in bvsearch) {
				if (File.Exists(s)) {
					BrawlViewPath = s;
					break;
				}
			}
		}

		public static void BrawlView(string path) {
			if (BrawlViewPath != null) {
				System.Diagnostics.Process.Start(BrawlViewPath, '"' + path + '"');
			}
		}
	}
}
