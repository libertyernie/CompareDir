using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace CompareDir {
	public class BrawlLib {
		public static Assembly Assembly = null;
		static BrawlLib() {
			if (File.Exists("BrawlLib.dll")) {
				Assembly = Assembly.LoadFrom("BrawlLib.dll");
			} else if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "/BrawlLib.dll")) {
				Assembly = Assembly.LoadFrom(Path.GetDirectoryName(Application.ExecutablePath) + "/BrawlLib.dll");
			}
		}

		public static IDisposable NodeFromFile(string path) {
			return Assembly.GetType("BrawlLib.SSBB.ResourceNodes.NodeFactory")
				.InvokeMember("FromFile", BindingFlags.InvokeMethod, null, null, new object[] { null, path })
				as IDisposable;
		}

		public static string getAudioLengthIfAny(IDisposable node) {
			var s_property = node.GetType().GetProperty("NumSamples");
			if (s_property == null) return null;
			var r_property = node.GetType().GetProperty("SampleRate");
			if (r_property == null) return null;

			int samples = (int)s_property.GetGetMethod().Invoke(node, null);
			int sampleRate = (int)r_property.GetGetMethod().Invoke(node, null);
			return new DateTime((10000000L * samples) / sampleRate).ToString("mm:ss.ff");
		}
	}
}
