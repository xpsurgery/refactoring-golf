using System;
using System.Collections.Generic;

namespace Golf
{
	public class Hole6Before
	{

		public abstract class NumberSequence
		{
			public IEnumerable<int> Take(int terms)
			{
				for (int i = 0; i < terms; i++)
					yield return Term(i);
			}

			public abstract int Term(int n);
		}

		public class FibonacciSequence : NumberSequence
		{
			public override int Term(int n)
			{
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				if (n < 2)
					return 1;
				return Term(n - 2) + Term(n - 1);
			}
		}

		public class TriangularNumberSequence : NumberSequence
		{
			public override int Term(int n)
			{
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				return (n + 2) * (n + 1) / 2;
			}
		}

		public void Generate()
		{
			new FibonacciSequence().Take(3);
			new TriangularNumberSequence().Take(3);
		}

	}

}
