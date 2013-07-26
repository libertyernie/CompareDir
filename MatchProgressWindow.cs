using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareDir
{
	public partial class MatchProgressWindow : Form, IMatchProgress
	{
		public bool Cancelled { get; private set; }

		private int _onlyLeftCount;
		public int OnlyLeftCount {
			get {
				return _onlyLeftCount;
			}
			set {
				_onlyLeftCount = value;
				lblLeft2.Text = _onlyLeftCount.ToString();
			}
		}
		private int _matchCount;
		public int MatchCount {
			get {
				return _matchCount;
			}
			set {
				_matchCount = value;
				lblMatch2.Text = _matchCount.ToString();
			}
		}
		private int _noMatchCount;
		public int NoMatchCount {
			get {
				return _noMatchCount;
			}
			set {
				_noMatchCount = value;
				lblNoMatch2.Text = _noMatchCount.ToString();
			}
		}
		private int _onlyRightCount;
		public int OnlyRightCount {
			get {
				return _onlyRightCount;
			}
			set {
				_onlyRightCount = value;
				lblRight2.Text = _onlyRightCount.ToString();
			}
		}
		public int ErrorCount { get; set; }

		public int TotalCount {
			get {
				return MatchCount + NoMatchCount + OnlyRightCount + OnlyLeftCount + ErrorCount;
			}
		}

		public MatchProgressWindow() {
			InitializeComponent();
			Cancelled = false;
			MatchCount = NoMatchCount = OnlyLeftCount = OnlyRightCount = 0;
		}

		public void Begin(int min, int max, int value) {
			progressBar1.Minimum = min;
			progressBar1.Maximum = max;
			progressBar1.Value = value;

			Show();
			Application.DoEvents();
		}

		public void Update(int value) {
			progressBar1.Value = value;
			Application.DoEvents();
		}

		public void Increment() {
			progressBar1.Value++;
			Application.DoEvents();
		}

		public void Finish() {
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Cancelled = true;
		}
	}
}
