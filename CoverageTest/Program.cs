using System;

namespace CoverageTest
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
		}

		public static void ALoop (int n)
		{
			Console.WriteLine ("Looping {0} times", n);
			for (int i = 0; i < n; i++) {
				Console.Write ("{0}, ", i);
			}
			Console.WriteLine ("");
		}

		public static void ARandomBranchLoop (Random rnd, int n)
		{
			Console.WriteLine ("Random looping {0} times", n);
			for (int i = 0; i < n; i++) {
				if (rnd.Next (0, 100) < 50) {
					Console.Write ("{0}, ", i);
				} else {
					Console.Write ("-{0}, ", i);
				}
			}
			Console.WriteLine ("");
		}

		public static void NeverFail ()
		{
			Console.Write ("This will always print true: ");
			if (true) {
				Console.WriteLine ("True!");
			} else {
				Console.WriteLine ("False!");
			}
		}
	}
}
