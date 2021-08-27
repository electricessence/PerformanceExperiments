using Xunit;
using System;

namespace PerformanceExperimentsTests
{

	public class StringTests
	{
		[Theory]
		[InlineData("a")]
		[InlineData("ab")]
		[InlineData("ABC")]

		[InlineData("Abc", "aBC", StringComparison.OrdinalIgnoreCase)]
		public void EqualityTest(string a, string? b = null, System.StringComparison sc = System.StringComparison.Ordinal)
		{
			var test = new PerformanceExperiments.StringTests();
			test.A = a;
			test.B = b ?? a;
			test.Comparison = sc;
			AllTrue(test);

			test = new PerformanceExperiments.SpanTests();
			test.A = a;
			test.B = b ?? a;
			test.Comparison = sc;
			AllTrue(test);

			var custom = new PerformanceExperiments.IgnoreWhitespaceStringComparerTests();
			custom.A = a;
			custom.B = b ?? a;
			custom.Comparison = sc;
			Assert.True(custom.Equals());
		}

		static void AllTrue(PerformanceExperiments.StringTests t)
		{
			Assert.True(t.Equals());
			Assert.True(t.EqualsWithLen());
			Assert.True(t.TrimEqualityA());
			Assert.True(t.TrimEqualityAB());
			Assert.True(t.TrimEqualityWithLenA());
			Assert.True(t.TrimEqualityWithLenAB());
		}
	}
}
