using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System;

namespace PerformanceExperiments;

/*
|                            Method |     Mean |    Error |   StdDev |   Median | Ratio |   Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |---------:|---------:|---------:|---------:|------:|-------:|----------:|------------:|
|                  RemoveNonNumbers | 897.9 ns | 17.53 ns | 30.23 ns | 900.5 ns |  1.00 | 0.5579 |    1168 B |        1.00 |
| RemoveNonNumbersWithStringBuilder | 152.1 ns |  2.88 ns |  5.75 ns | 149.3 ns |  0.17 | 0.3135 |     656 B |        0.56 |
|          RemoveNonNumbersWithSpan | 136.3 ns |  0.21 ns |  0.19 ns | 136.3 ns |  0.15 | 0.0648 |     136 B |        0.12 |
*/

internal static class RemoveNonNumbersMethods
{
	public static string RemoveNonNumbers(this string input)
	{
		if (string.IsNullOrEmpty(input)) return input;
		var trimmed = input.Where(c => char.IsDigit(c)).ToArray();
		var len = trimmed.Length;
		if (len == 0) return string.Empty;
		return len == input.Length ? input : new string(trimmed);
	}

	public static string RemoveNonNumbersWithStringBuilder(this string input)
	{
		if (string.IsNullOrEmpty(input)) return input;
		var sb = new StringBuilder();
		foreach (var c in input)
		{
			if (char.IsDigit(c))
				sb.Append(c);
		}

		var len = sb.Length;
		if (len == 0) return string.Empty;
		return len == input.Length ? input : sb.ToString();
	}

	public static string RemoveNonNumbersWithSpan(this string input)
	{
		if (string.IsNullOrEmpty(input)) return input;
		var len = input.Length;
		Span<char> a = stackalloc char[len];
		var newLen = 0;
		var span = input.AsSpan();
		for (var i = 0; i < len; i++)
		{
			ref readonly var c = ref span[i];
			if (char.IsDigit(c))
			{
				a[newLen] = c;
				newLen++;
			}
		}
		if (newLen == 0) return string.Empty;
		return newLen == input.Length ? input : a.Slice(0, newLen).ToString();
	}
}

[MemoryDiagnoser]
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Benchmarking")]
public class RemoveNonNumbersTests
{
	static readonly string[] TestValues = new[] { "0123456789", "555-555-5555", " ", "", " xxx-555-7777", " 555-555-5555  " };

	[Benchmark(Baseline = true)]
	public string RemoveNonNumbers()
	{
		string s = string.Empty;
		foreach (var value in TestValues)
		{
			s = value.RemoveNonNumbers();
		}
		return s;
	}

	[Benchmark]
	public string RemoveNonNumbersWithStringBuilder()
	{
		string s = string.Empty;
		foreach (var value in TestValues)
		{
			s = value.RemoveNonNumbersWithStringBuilder();
		}
		return s;
	}

	[Benchmark]
	public string RemoveNonNumbersWithSpan()
	{
		string s = string.Empty;
		foreach (var value in TestValues)
		{
			s = value.RemoveNonNumbersWithSpan();
		}
		return s;
	}
}
