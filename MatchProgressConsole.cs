using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareDir {
	public class MatchProgressConsole : IMatchProgress {
		public bool Cancelled {
			get { return false; }
		}

		public int OnlyLeftCount { get; set; }
		public int MatchCount { get; set; }
		public int NoMatchCount { get; set; }
		public int OnlyRightCount { get; set; }
		public int ErrorCount { get; set; }
		public int TotalCount {
			get {
				return MatchCount + NoMatchCount + OnlyRightCount + OnlyLeftCount + ErrorCount;
			}
		}

		private int asterisks;
		private float min, max;
		private int value;

		public void Begin(int min, int max, int value) {
			this.min = min;
			this.max = max;
			Console.Error.Write('[');
			asterisks = (int)((78 * value - min) / (max - min));
			Console.Error.Write(new string('*', asterisks));
		}

		public void Update(int value) {
			this.value = value;
			int new_asterisks = (int)((78 * value - min) / (max - min));
			if (new_asterisks > asterisks) {
				Console.Error.Write(new string('*', new_asterisks - asterisks));
				asterisks = new_asterisks;
			}
		}

		public void Increment() {
			Update(value + 1);
		}

		public void Finish() {
			Console.Error.WriteLine(']');
		}
	}
}
