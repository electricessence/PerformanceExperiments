using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	[MemoryDiagnoser]
	public class StringTests : ComparisonTestBase
	{
		[Benchmark]
		public override bool Equals() => A.Equals(B, Comparison);

		[Benchmark]
		public virtual bool EqualsWithLen() => A.Length==B.Length && A.Equals(B, Comparison);

		[Benchmark]
		public virtual bool TrimEqualityA() => A.Trim().Equals(B, Comparison);

		[Benchmark]
		public virtual bool TrimEqualityAB() => A.Trim().Equals(B.Trim(), Comparison);

		[Benchmark]
		public virtual bool TrimEqualityWithLenA()
		{
			var t = A.Trim();
			return t.Length==B.Length && t.Equals(B, Comparison);
		}

		[Benchmark]
		public virtual bool TrimEqualityWithLenAB()
		{
			var tA = A.Trim();
			var tB = B.Trim();
			return tA.Length == tB.Length && tA.Equals(tB, Comparison);
		}
	}
}
