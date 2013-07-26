using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareDir {
	public interface IMatchProgress {
		bool Cancelled { get; }

		int OnlyLeftCount { get; set; }
		int MatchCount { get; set; }
		int NoMatchCount { get; set; }
		int OnlyRightCount { get; set; }
		int ErrorCount { get; set; }
		int TotalCount { get; }

		void Begin(int min, int max, int value);
		void Update(int value);
		void Increment();
		void Finish();
	}
}
