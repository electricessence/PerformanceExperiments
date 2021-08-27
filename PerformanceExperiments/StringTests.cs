using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments
{
	public class StringTests : StringTestsBase
	{
		[Benchmark]
		public override bool Equals() => base.Equals();

		[Benchmark]
		public override bool EqualsWithLen() => base.EqualsWithLen();

		[Benchmark]
		public override bool TrimEqualityA() => base.TrimEqualityA();

		[Benchmark]
		public override bool TrimEqualityAB() => base.TrimEqualityAB();

		[Benchmark]
		public override bool TrimEqualityWithLenA() => base.TrimEqualityWithLenA();

		[Benchmark]
		public override bool TrimEqualityWithLenAB() => base.TrimEqualityWithLenAB();
	}
}
