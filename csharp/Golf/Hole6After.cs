using System;
using System.Collections.Generic;

namespace Golf
{
	public class Hole6After
	{

		public interface TermGenerator
		{
			int Term (int i);
		}

		public class NumberSequence
		{
			TermGenerator _termGenerator;

			public NumberSequence(TermGenerator termGenerator)
			{
				_termGenerator = termGenerator;
			}

			public IEnumerable<int> Take(int terms)
			{
				for (int i = 0; i < terms; i++)
					yield return _termGenerator.Term (i);
			}
		}

		public class FibonacciTerm : TermGenerator
		{
			public int Term(int n)
			{
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				if (n < 2)
					return 1;
				return Term(n - 2) + Term(n - 1);
			}
		}

		public class TriangularTerm : TermGenerator
		{
			public int Term(int n) {
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				return (n + 2) * (n + 1) / 2;
			}
		}

		public void Generate()
		{
			new NumberSequence(new FibonacciTerm()).Take(3);
			new NumberSequence(new TriangularTerm()).Take(3);
		}

	}

}
