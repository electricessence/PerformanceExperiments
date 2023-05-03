using System;
using Xunit;

namespace PerformanceExperiments.Tests;

public class StringTests
{
	[Theory]
	[InlineData("a")]
	[InlineData("ab")]
	[InlineData("ABC")]

	[InlineData("Abc", "aBC", StringComparison.OrdinalIgnoreCase)]
	public void EqualityTest(string a, string? b = null, StringComparison sc = StringComparison.Ordinal)
	{
		AllTrue(new PerformanceExperiments.StringTests
		{
			A = a,
			B = b ?? a,
			Comparison = sc
		});

		AllTrue(new PerformanceExperiments.SpanTests
		{
			A = a,
			B = b ?? a,
			Comparison = sc
		});

		var custom = new PerformanceExperiments.IgnoreWhitespaceStringComparerTests
		{
			A = a,
			B = b ?? a,
			Comparison = sc
		};
		Assert.True(custom.Equals());
	}

	[Theory]
	[InlineData("a", "A")]
	[InlineData("a", null)]
	public void InequalityTest(string a, string? b, StringComparison sc = StringComparison.Ordinal)
	{
		AllFalse(new PerformanceExperiments.StringTests
		{
			A = a,
			B = b,
			Comparison = sc
		});

		AllFalse(new PerformanceExperiments.SpanTests
		{
			A = a,
			B = b,
			Comparison = sc
		});
	}

	static void AllTrue(PerformanceExperiments.StringTestsBase t)
	{
		Assert.True(t.Equals());
		Assert.True(t.EqualsWithLen());
		Assert.True(t.TrimEqualityA());
		Assert.True(t.TrimEqualityAB());
		Assert.True(t.TrimEqualityWithLenA());
		Assert.True(t.TrimEqualityWithLenAB());
	}

	static void AllFalse(PerformanceExperiments.StringTestsBase t)
	{
		Assert.False(t.Equals());
		Assert.False(t.EqualsWithLen());
		Assert.False(t.TrimEqualityA());
		Assert.False(t.TrimEqualityAB());
		Assert.False(t.TrimEqualityWithLenA());
		Assert.False(t.TrimEqualityWithLenAB());
	}
}
