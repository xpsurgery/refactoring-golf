using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Golf
{
	[TestFixture]
	public class Hole5Tests
	{
		[Test]
		public void FirstSevenFibonacciTerms()
		{
			IEnumerable<int> seq = new Hole5Before.FibonacciSequence().take(7);
			List<int> expected = new List<int> () { 1, 1, 2, 3, 5, 8, 13 };
			Assert.IsTrue (seq.ToList().SequenceEqual(expected));
		}

		[Test]
		public void FirstSevenTriangleNumbers()
		{
			IEnumerable<int> seq = new Hole5Before.TriangularNumberSequence().take(7);
			List<int> expected = new List<int> () { 1, 3, 6, 10, 15, 21, 28 };
			Assert.IsTrue (seq.ToList().SequenceEqual(expected));
		}

	}
}

