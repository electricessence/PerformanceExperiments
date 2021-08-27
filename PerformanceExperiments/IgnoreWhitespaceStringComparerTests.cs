using Sylvan;
using System;
using System.Collections.Generic;

namespace PerformanceExperiments
{
	public class IgnoreWhitespaceStringComparerTests : ComparisonTestBase
	{

		IEqualityComparer<string> Comparer = IgnoreWhitespaceStringComparer.Instance;

		public override StringComparison Comparison {
			get => base.Comparison;
			set
			{
				Comparer = value == StringComparison.OrdinalIgnoreCase
					? IgnoreWhitespaceStringComparer.IgnoreCase
					: IgnoreWhitespaceStringComparer.Instance;

				base.Comparison = value;
			}
		}

		public override bool Equals() => Comparer.Equals(A, B);
	}
}
