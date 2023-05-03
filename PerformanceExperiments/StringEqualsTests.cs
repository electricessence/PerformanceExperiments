using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments;

public class StringEqualsTests
{
	static bool Standard(string a, string? b)
		=> a.Equals(b);

	static bool WithLengthFirst(string a, string? b)
		=> b is not null && a.Length == b.Length && a.Equals(b);

	static bool WithLengthFirstSpecial(string a, string? b)
	{
		if (b is null) return false;

		var len = a.Length;
		if (len != b.Length) return false;
		return len switch
		{
			0 => true,
			1 => a[0] == b[0],
			_ => a.Equals(b),
		};
	}

	static bool WithLengthFirstNoNull(string a, string b)
		=> a.Length == b.Length && a.Equals(b);

	static bool WithLengthFirstSpecialNoNull(string a, string b)
	{
		var len = a.Length;
		if (len != b.Length) return false;
		return len switch
		{
			0 => true,
			1 => a[0] == b[0],
			_ => a.Equals(b),
		};
	}

	static void Test1(Func<string, string?, bool> method)
	{
		method("", null);
		method("", "");
		method("a", null);
		method("a", "");
		method("a", "a");
		method("a", "b");
		method("a", "ab");
		method("ab", null);
		method("ab", "");
		method("ab", "ab");
		method("ab", "ac");
		method("ab", "abc");
		method("abc", null);
		method("abc", "");
		method("abc", "abc");
	}

	static void Test2(Func<string, string, bool> method)
	{
		method("", "null");
		method("", "");
		method("a", "null");
		method("a", "");
		method("a", "a");
		method("a", "b");
		method("a", "ab");
		method("ab", "null");
		method("ab", "");
		method("ab", "ab");
		method("ab", "ac");
		method("ab", "abc");
		method("abc", "null");
		method("abc", "");
		method("abc", "abc");
	}

	[Benchmark]
	public void Equals_WithNulls() => Test1(Standard);

	[Benchmark]
	public void EqualsWithLengthTestFirst_WithNulls() => Test1(WithLengthFirst);

	[Benchmark]
	public void Equals_NoNulls() => Test2(Standard);

	[Benchmark]
	public void EqualsWithLengthTestFirst_NoNulls() => Test2(WithLengthFirst);

	[Benchmark]
	public void EqualsWithLengthTestFirstNoNullCheck() => Test2(WithLengthFirstNoNull);

	[Benchmark]
	public void EqualsSpecial_WithNulls() => Test1(WithLengthFirstSpecial);

	[Benchmark]
	public void EqualsSpecial_NoNulls() => Test2(WithLengthFirstSpecial);

	[Benchmark]
	public void EqualsSpecialNoNullCheck() => Test2(WithLengthFirstSpecialNoNull);
}
