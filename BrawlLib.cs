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

		public static void DisplayModel(IDisposable node) {
			Type ResourceNode = Assembly.GetType("BrawlLib.SSBB.ResourceNodes.ResourceNode");
			if (!ResourceNode.IsInstanceOfType(node)) throw new InvalidCastException();
			Type MDL0Node = Assembly.GetType("BrawlLib.SSBB.ResourceNodes.MDL0Node");
			Type ModelPanel = Assembly.GetType("System.Windows.Forms.ModelPanel");
			Type Vector3 = Assembly.GetType("System.Vector3");

			List<IDisposable> models = new List<IDisposable>();
			PopulateList(node, models, MDL0Node);

			Form form = new Form() { Width = 640, Height = 480 };
			form.Shown += delegate(object o, EventArgs e) {
				Control mp = (Control)ModelPanel.GetConstructor(new Type[0]).Invoke(null);
				mp.Dock = DockStyle.Fill;
				form.Controls.Add(mp);

				foreach (var model in models) {
					MDL0Node.GetMethod("Populate", new Type[0]).Invoke(model, null);
					foreach (string prop in new string[] { "_renderBones", "_renderWireframe", "_renderVertices", "_renderBox", "_renderNormals" }) {
						MDL0Node.GetField(prop).SetValue(model, false);
					}
					MDL0Node.GetField("_renderPolygons").SetValue(model, true);
					MDL0Node.GetMethod("ApplyCHR").Invoke(model, new object[] { null, 0 });
					MDL0Node.GetMethod("ApplySRT").Invoke(model, new object[] { null, 0 });
					ModelPanel.GetMethod("AddTarget").Invoke(mp, new object[] { model });
				}

				object min = Vector3.GetConstructor(new Type[] { typeof(float) }).Invoke(new object[] { -100f });
				object max = Vector3.GetConstructor(new Type[] { typeof(float) }).Invoke(new object[] { 100f });
				ModelPanel.GetMethod("SetCamWithBox").Invoke(mp, new object[] { min, max });
			};
			form.Disposed += delegate(object o, EventArgs e) {
				foreach (var model in models) model.Dispose();
			};
			form.Show();
		}

		private static void PopulateList(object node, ICollection<IDisposable> models, Type type) {
			if (type.IsInstanceOfType(node)) {
				models.Add((IDisposable)node);
			} else if ((bool)type.GetProperty("HasChildren").GetGetMethod().Invoke(node, null)) {
				foreach (var child in (System.Collections.IEnumerable)type.GetProperty("Children").GetGetMethod().Invoke(node, null)) {
					PopulateList(child, models, type);
				}
			}
		}
	}
}
