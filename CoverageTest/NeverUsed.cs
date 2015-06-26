using System;

namespace CoverageTest
{
	public class NeverUsed
	{
		bool ABoolean = false;

		public NeverUsed ()
		{
			ABoolean = true;
		}

		public bool IsThisBiggerThanTen(int n) {
			if (n > 10) {
				Console.WriteLine ("{0} is bigger than 10", n);
				return true;
			} else {
				Console.WriteLine ("{0} is not bigger than 10", n);
				return false;
			}
		}
	}
}

