using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments;

[MemoryDiagnoser]
public class StringTestsBase : ComparisonTestBase
{
	public override bool Equals() => A.Equals(B, Comparison);

	public virtual bool EqualsWithLen() => B is not null && A.Length == B.Length && A.Equals(B, Comparison);

	public virtual bool TrimEqualityA() => A.Trim().Equals(B, Comparison);

	public virtual bool TrimEqualityAB() => A.Trim().Equals(B?.Trim(), Comparison);

	public virtual bool TrimEqualityWithLenA()
	{
		if (B is null) return false;
		var t = A.Trim();
		return t.Length == B.Length && t.Equals(B, Comparison);
	}

	public virtual bool TrimEqualityWithLenAB()
	{
		if (B is null) return false;
		var tA = A.Trim();
		var tB = B.Trim();
		return tA.Length == tB.Length && tA.Equals(tB, Comparison);
	}
}
