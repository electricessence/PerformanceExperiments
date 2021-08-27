using Xunit;

namespace PerformanceExperimentsTests
{

	public class StringTrimTests
	{
		readonly PerformanceExperiments.StringTrimTests tests = new();

		[Fact]
		public void StringTrim() => Assert.True(tests.StringTrim());


		[Fact]
		public void StringTrimLenChar() => Assert.True(tests.StringTrimLenChar());

		[Fact]
		public void StringTrimLenY1() => Assert.True(tests.StringTrimLenY1());

		[Fact]
		public void StringTrimLenY2() => Assert.False(tests.StringTrimLenY2());

		[Fact]
		public void StringTrimLenN() => Assert.False(tests.StringTrimLenN());


		[Fact]
		public void SpanCharTrim() => Assert.True(tests.SpanCharTrim());


		[Fact]
		public void SpanCharTrimLenChar() => Assert.True(tests.SpanCharTrimLenChar());

		[Fact]
		public void SpanCharTrimLenY1() => Assert.True(tests.SpanCharTrimLenY1());

		[Fact]
		public void SpanCharTrimLenY2() => Assert.False(tests.SpanCharTrimLenY2());

		[Fact]
		public void SpanCharTrimLenN() => Assert.False(tests.SpanCharTrimLenN());
	}
}
