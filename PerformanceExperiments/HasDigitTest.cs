using BenchmarkDotNet.Attributes;
using System.Linq;

namespace PerformanceExperiments;

public static class HasDigitExtensions
{
	public static bool HasDigitFromString(this int value, char digit)
	{
		var s = value.ToString();
		return s.Contains(digit);
	}

	public static bool HasDigitFromString(this int value, int digit)
		=> value.HasDigitFromString(digit.ToString()[0]);

	public static bool HasDigit(this int value, int digit)
	{
		do
		{
			if (value % 10 == digit) return true;
			value /= 10;
		}
		while (value > 0);
		return false;
	}
}

public class HasDigitBenchmarks
{
	static readonly int[] Values = new int[] { 123456789, 987654321, 999991111 };
	static readonly string[] ValueStrings = Values.Select(v=>v.ToString()).ToArray();
	static readonly int[] Digits = new int[] { 2, 3, 5, 7, 8 };
	static readonly char[] CDigits = Digits.Select(d => d.ToString()[0]).ToArray();

	[Benchmark(Baseline = true)]
	public void HasDigitFromString()
	{
		foreach(var value in Values)
		{
			foreach(var digit in CDigits)
			{
				_ = value.HasDigitFromString(digit);
			}
		}
	}

	[Benchmark]
	public void FindCharInString()
	{
		foreach (var value in ValueStrings)
		{
			foreach (var digit in CDigits)
			{
				_ = value.Contains(digit);
			}
		}
	}

	[Benchmark]
	public void HasDigit()
	{
		foreach (var value in Values)
		{
			foreach (var digit in Digits)
			{
				_ = value.HasDigit(digit);
			}
		}
	}
}
