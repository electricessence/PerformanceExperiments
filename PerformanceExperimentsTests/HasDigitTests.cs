using Xunit;

namespace PerformanceExperiments.Tests;

public class HasDigitTests
{
	[Theory]
	[InlineData(1234567890, 5)]
	[InlineData(987654321, 5)]
	[InlineData(1234567890, 9)]
	[InlineData(987654321, 9)]
	[InlineData(234567890, 3)]
	[InlineData(987654321, 3)]
	[InlineData(1234567890, 1)]
	[InlineData(987654321, 1)]
	[InlineData(1234567890, 0)]
	[InlineData(987654321, 0)]
	[InlineData(98765421, 3)]
	[InlineData(234567890, 1)]
	[InlineData(98765432, 1)]
	[InlineData(123456789, 0)]
	public void VerifyBehavior(int value, int digit)
	{
		Assert.Equal(value.HasDigitFromString(digit), value.HasDigit(digit));
	}
}
