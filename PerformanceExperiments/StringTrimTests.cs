using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	[MemoryDiagnoser]
	public class StringTrimTests
	{
		const string y = "y";
		const string _n__ = " n  ";
		const string _y__ = " y  ";
		const string _yx__ = " yx  ";

		[Benchmark]
		public bool StringTrim() => _y__.Trim() == y;


		[Benchmark]
		public bool StringTrimLenChar()
		{
			var t = _y__.Trim();
			return t.Length == 1 && t[0] == 'y';
		}

		[Benchmark]
		public bool StringTrimLenY1()
		{
			var t = _y__.Trim();
			return t.Length == 1 && t == y;
		}

		[Benchmark]
		public bool StringTrimLenY2()
		{

			var t = _yx__.Trim();
			return t.Length == 1 && t == y;
		}

		[Benchmark]
		public bool StringTrimLenN()
		{
			var t = _n__.Trim();
			return t.Length == 1 && t == y;
		}



		[Benchmark]
		public bool SpanCharTrim() => MemoryExtensions.Equals(_y__.AsSpan().Trim(), y, StringComparison.Ordinal);


		[Benchmark]
		public bool SpanCharTrimLenChar()
		{
			var t = _y__.AsSpan().Trim();
			return t.Length == 1 && t[0] == 'y';
		}

		[Benchmark]
		public bool SpanCharTrimLenY1()
		{
			var t = _y__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.Ordinal);
		}

		[Benchmark]
		public bool SpanCharTrimLenY2()
		{

			var t = _yx__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.Ordinal);
		}

		[Benchmark]
		public bool SpanCharTrimLenN()
		{
			var t = _n__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.Ordinal);
		}
	}
}
