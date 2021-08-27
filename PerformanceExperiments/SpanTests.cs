using System;

namespace PerformanceExperiments
{
	public class SpanTests : StringTests
	{
		public override bool Equals() => A.AsSpan().Equals(B.AsSpan(), Comparison);

		public override bool EqualsWithLen() => A.AsSpan().Equals(B, Comparison);

		public override bool TrimEqualityA() => A.AsSpan().Trim().Equals(B.AsSpan(), Comparison);

		public override bool TrimEqualityAB() => A.AsSpan().Trim().Equals(B.AsSpan().Trim(), Comparison);

		public override bool TrimEqualityWithLenA() => A.AsSpan().Trim().Equals(B, Comparison);

		public override bool TrimEqualityWithLenAB()
		{
			var tA = A.AsSpan().Trim();
			var tB = B.AsSpan().Trim();
			return tA.Length == tB.Length && tA.Equals(tB, Comparison);
		}
	}
}
