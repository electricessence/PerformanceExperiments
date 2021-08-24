using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments
{
	public class BitwiseVsShortCircuit
	{
		public int a = 1000;
		public int b = 10;

		[Benchmark]
		public bool TrueBW() => a > b & a > 10 & b < 100;

		[Benchmark]
		public bool TrueSS() => a > b && a > 10 && b < 100;

		[Benchmark]
		public bool FalseMiddleBW() => a > b & a < 10 & b < 100;

		[Benchmark]
		public bool FalseMiddleSS() => a > b && a < 10 && b < 100;

		[Benchmark]
		public bool FalseFirstBW() => a < b & a > 10 & b < 100;

		[Benchmark]
		public bool FalseFirstSS() => a < b && a > 10 && b < 100;

		[Benchmark]
		public bool FalseFirst2BW() => a < b & a > 10 & "hello there".Contains("er");

		[Benchmark]
		public bool FalseFirst2SS() => a < b && a > 10 && "hello there".Contains("er");

		[Benchmark]
		public bool False2BW() => a > b & a > 1000 & b < 10;

		[Benchmark]
		public bool False2SS() => a > b && a > 1000 && b < 10;

		[Benchmark]
		public bool False1BW() => a > b & a > 10 & b < 10;

		[Benchmark]
		public bool False1SS() => a > b && a > 10 && b < 10;
	}
}
