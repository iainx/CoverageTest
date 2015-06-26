using System;

namespace CoverageTest
{
	class MainClass
	{
		static Random rnd;

		public static void Main (string[] args)
		{
			rnd = new Random ();
			Console.WriteLine ("Hello World!");
			ALoop (rnd.Next (10, 100));
			ARandomBranchLoop (rnd.Next (10, 100));
			NeverFail ();
		}

		public static void ALoop (int n)
		{
			Console.WriteLine ("Looping {0} times", n);
			for (int i = 0; i < n; i++) {
				Console.Write ("{0}, ", i);
			}
			Console.WriteLine ("");
		}

		public static void ARandomBranchLoop (int n)
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
