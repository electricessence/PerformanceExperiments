using BenchmarkDotNet.Attributes;
using System;

/*
|                     Method |     Mean |    Error |   StdDev | Ratio |
|--------------------------- |---------:|---------:|---------:|------:|
|         BuiltInGetHashCode | 25.01 us | 0.013 us | 0.010 us |  1.00 |
|          CustomGetHashCode | 26.90 us | 0.009 us | 0.008 us |  1.08 |
| CustomGetHashCodeUltraFast | 20.25 us | 0.018 us | 0.017 us |  0.81 |
*/

namespace PerformanceExperiments;

//[MemoryDiagnoser]
public class HashCodeBenchmark
{
	private const int SampleSize = 1000;
	private string[]? _sampleData;
	private ReadOnlyMemory<char>[]? _sampleCharSpans;

	[GlobalSetup]
	public void Setup()
	{
		_sampleData = new string[SampleSize];
		_sampleCharSpans = new ReadOnlyMemory<char>[SampleSize];

		for (int i = 0; i < SampleSize; i++)
		{
			var guid = Guid.NewGuid().ToString();
			_sampleData[i] = guid;
			_sampleCharSpans[i] = guid.AsMemory();
		}
	}

	[Benchmark(Baseline = true)]
	public int BuiltInGetHashCode()
	{
		int result = 0;
		foreach (var s in _sampleData!)
		{
			result += s.GetHashCode();
		}
		return result;
	}

	[Benchmark]
	public int CustomGetHashCode()
	{
		int result = 0;
		foreach (var charSpan in _sampleCharSpans!)
		{
			result += charSpan.Span.GetHashCodeFromChars();
		}
		return result;
	}

	//[Benchmark]
	public int CustomGetHashCodeFNV1a()
	{
		int result = 0;
		foreach (var charSpan in _sampleCharSpans!)
		{
			result += charSpan.Span.GetHashCodeFromCharsFNV1a();
		}
		return result;
	}

	[Benchmark]
	public int CustomGetHashCodeUltraFast()
	{
		int result = 0;
		foreach (var charSpan in _sampleCharSpans!)
		{
			result += charSpan.Span.GetHashCodeFromCharsUltraFast();
		}
		return result;
	}
}

public static class CharArrayExtensions
{
	public static int GetHashCodeFromChars(this ReadOnlySpan<char> chars)
	{
		int hash_value = 0;
		int length = chars.Length;
		for (var i = 0; i < length; i++)
		{
			ref readonly char c = ref chars[i];
			hash_value = (hash_value * 31) ^ c;
		}

		return hash_value;
	}

	private const int FNVPrime = 16777619;
	private const int FNVOffsetBasis = unchecked((int)2166136261);

	public static int GetHashCodeFromCharsFNV1a(this ReadOnlySpan<char> chars)
	{
		int hash = FNVOffsetBasis;

		foreach (char c in chars)
		{
			hash ^= c;
			hash *= FNVPrime;
		}

		return hash;
	}

	public static int GetHashCodeFromCharsUltraFast(this ReadOnlySpan<char> chars)
	{
		long hash = 0;
		int length = chars.Length;

		for (int i = 0; i < length; i++)
		{
			ref readonly char c = ref chars[i];
			hash |= (long)c << (i * 8);
		}

		return (int)(hash ^ (hash >> 32));
	}
}