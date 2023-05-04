using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

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
	[Params(100, 1000, 1000000)]
	public int SampleSize { get; set; }
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

	//[Benchmark(Baseline = true)]
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

	[Benchmark]
	public int CustomGetHashCodeFNV1a()
	{
		int result = 0;
		foreach (var charSpan in _sampleCharSpans!)
		{
			result += charSpan.Span.GetHashCodeFromCharsFNV1a();
		}
		return result;
	}

	//[Benchmark]
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
		int hash = 17;
		int length = chars.Length;
		for (var i = 0; i < length; i++)
		{
			ref readonly char c = ref chars[i];
			hash = (hash * 31) ^ c;
		}

		return hash;
	}

	private const int FNVPrime = 16777619;
	private const int FNVOffsetBasis = unchecked((int)2166136261);

	public static int GetHashCodeFromCharsFNV1a(this ReadOnlySpan<char> chars)
	{
		int hash = FNVOffsetBasis;
		int length = chars.Length;
		for (var i = 0; i < length; i++)
		{
			ref readonly char c = ref chars[i];
			hash = (hash ^ c) * FNVPrime;
		}

		return hash;
	}

	public static int GetHashCodeFromCharsUltraFast(this ReadOnlySpan<char> chars)
	{
		int hash = 0;

		for (int i = 0; i < chars.Length; i++)
		{
			hash += chars[i];
			hash += hash << 10;
			hash ^= hash >> 6;
		}

		hash += hash << 3;
		hash ^= hash >> 11;
		hash += hash << 15;

		return hash;
	}
}

public static class HashCollisionTest
{
	public static double Test(Func<string, int> hashFunction, int numStrings, int stringLength)
	{
		var random = new Random();
		var inputStrings = new HashSet<string>();
		var hashSet = new HashSet<int>();
		int collisions = 0;

		for (int i = 0; i < numStrings; i++)
		{
			string input = GenerateRandomString(random, stringLength);
			inputStrings.Add(input);
		}

		foreach (string input in inputStrings)
		{
			int hash = hashFunction(input);
			if (!hashSet.Add(hash))
			{
				collisions++;
			}
		}

		return (double)collisions / numStrings;
	}

	private static string GenerateRandomString(Random random, int length)
	{
		var builder = new StringBuilder(length);
		for (int i = 0; i < length; i++)
		{
			char c = (char)random.Next(32, 127); // Generate a random character in the printable ASCII range
			builder.Append(c);
		}
		return builder.ToString();
	}
}
