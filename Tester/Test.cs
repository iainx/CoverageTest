using NUnit.Framework;
using System;
using CoverageTest;

namespace Tester
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			var rnd = new Random ();
			MainClass.ALoop (rnd.Next (10, 100));
			MainClass.ARandomBranchLoop (rnd, rnd.Next (10, 100));
			MainClass.NeverFail ();
		}
	}
}

