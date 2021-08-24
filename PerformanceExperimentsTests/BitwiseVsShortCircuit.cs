using Xunit;

namespace PerformanceExperimentsTests
{
	public class BitwiseVsShortCircuit
	{
		PerformanceExperiments.BitwiseVsShortCircuit _test = new();

		[Fact]
		public void TrueBW() => Assert.True(_test.TrueBW());

		[Fact]
		public void TrueSS() => Assert.True(_test.TrueSS());

		[Fact]
		public void FalseMiddleBW() => Assert.False(_test.FalseMiddleBW());

		[Fact]
		public void FalseMiddleSS() => Assert.False(_test.FalseMiddleSS());

		[Fact]
		public void FalseFirstBW() => Assert.False(_test.FalseFirstBW());

		[Fact]
		public void FalseFirstSS() => Assert.False(_test.FalseFirstSS());

		[Fact]
		public void False2BW() => Assert.False(_test.False2BW());

		[Fact]
		public void False2SS() => Assert.False(_test.False2SS());

		[Fact]
		public void False1BW() => Assert.False(_test.False1BW());

		[Fact]
		public void False1SS() => Assert.False(_test.False1SS());
	}
}
