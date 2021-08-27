using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	public class SpanTests : StringTestsBase
	{
		[Benchmark]
		public override bool Equals() => A.AsSpan().Equals(B.AsSpan(), Comparison);

		[Benchmark]
		public override bool EqualsWithLen() => A.AsSpan().Equals(B, Comparison);


		[Benchmark]
		public override bool TrimEqualityA() => A.AsSpan().Trim().Equals(B.AsSpan(), Comparison);


		[Benchmark]
		public override bool TrimEqualityAB() => A.AsSpan().Trim().Equals(B.AsSpan().Trim(), Comparison);


		[Benchmark]
		public override bool TrimEqualityWithLenA() => A.AsSpan().Trim().Equals(B, Comparison);


		[Benchmark]
		public override bool TrimEqualityWithLenAB()
		{
			var tA = A.AsSpan().Trim();
			var tB = B.AsSpan().Trim();
			return tA.Length == tB.Length && tA.Equals(tB, Comparison);
		}
	}
}
