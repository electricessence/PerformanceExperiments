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
		public void EqualityTest(string a, string b = null, StringComparison sc = StringComparison.Ordinal)
		{
			var test = new PerformanceExperiments.StringTests
			{
				A = a,
				B = b ?? a,
				Comparison = sc
			};
			AllTrue(test);

			test = new PerformanceExperiments.SpanTests
			{
				A = a,
				B = b ?? a,
				Comparison = sc
			};
			AllTrue(test);

			var custom = new PerformanceExperiments.IgnoreWhitespaceStringComparerTests
			{
				A = a,
				B = b ?? a,
				Comparison = sc
			};
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
