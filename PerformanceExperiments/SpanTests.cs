using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	public class SpanTests : StringTestsBase
	{
		[Benchmark]
		public override bool Equals() => B is not null && A.AsSpan().Equals(B.AsSpan(), Comparison);

		[Benchmark]
		public override bool EqualsWithLen() => A.AsSpan().Equals(B, Comparison);


		[Benchmark]
		public override bool TrimEqualityA() => B is not null && A.AsSpan().Trim().Equals(B.AsSpan(), Comparison);


		[Benchmark]
		public override bool TrimEqualityAB() => B is not null && A.AsSpan().Trim().Equals(B.AsSpan().Trim(), Comparison);


		[Benchmark]
		public override bool TrimEqualityWithLenA() => A.AsSpan().Trim().Equals(B, Comparison);


		[Benchmark]
		public override bool TrimEqualityWithLenAB()
		{
			if (B is null) return false;
			var tA = A.AsSpan().Trim();
			var tB = B.AsSpan().Trim();
			return tA.Length == tB.Length && tA.Equals(tB, Comparison);
		}
	}
}
