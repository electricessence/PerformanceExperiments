using BenchmarkDotNet.Attributes;
using Sylvan;
using System;
using System.Collections.Generic;

namespace PerformanceExperiments;

public class IgnoreWhitespaceStringComparerTests : ComparisonTestBase
{
	IEqualityComparer<string> Comparer = IgnoreWhitespaceStringComparer.Instance;

	[Params(StringComparison.Ordinal, StringComparison.OrdinalIgnoreCase)]
	public override StringComparison Comparison
	{
		get => base.Comparison;
		set
		{
			Comparer = value == StringComparison.OrdinalIgnoreCase
				? IgnoreWhitespaceStringComparer.IgnoreCase
				: IgnoreWhitespaceStringComparer.Instance;

			base.Comparison = value;
		}
	}

	[Benchmark]
	public override bool Equals() => Comparer.Equals(A, B);
}
