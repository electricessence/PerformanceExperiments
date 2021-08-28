using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	public class StringEqualsTests
	{
		static bool Standard(string a, string? b)
			=> a.Equals(b);

		static bool WithLengthFirst(string a, string? b)
			=> b is not null && a.Length == b.Length && a.Equals(b);

		static void Test(Func<string, string?, bool> method)
		{
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

		[Benchmark]
		public void Equals() => Test(Standard);



		[Benchmark]
		public void EqualsWithLengthTestFirst() => Test(WithLengthFirst);
	}
}
