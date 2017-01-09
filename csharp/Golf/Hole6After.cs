using System;
using System.Collections.Generic;

namespace Golf
{
	public class Hole6After {

		public interface TermGenerator
		{
			int term (int i);
		}

		public class NumberSequence {
			TermGenerator termGenerator;

			public NumberSequence(TermGenerator termGenerator)
			{
				this.termGenerator = termGenerator;
				
			}

			public IEnumerable<int> take (int terms)
			{
				for (int i = 0; i < terms; i++)
					yield return termGenerator.term (i);
			}

		}

		public class FibonacciSequence : TermGenerator {
			
	        public int term(int n) {
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				if (n < 2)
					return 1;
	            return term(n - 2) + term(n - 1);
	        }

	    }

		public class TriangularNumberSequence : TermGenerator {

			public int term(int n) {
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
	            return (n + 2) * (n + 1) / 2;
	        }

	    }

	}

}
