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
		public bool StringTrimCompare() => _y__.Trim().Equals(y, StringComparison.Ordinal);

		[Benchmark]
		public bool StringTrimCompareFalse() => _y__.Trim().Equals(_n__, StringComparison.Ordinal);

		[Benchmark]
		public bool StringTrimCompareLenFalse()
		{
			var t = _y__.Trim();
			var len = t.Length;
			return len == _n__.Length && t.Equals(_n__, StringComparison.Ordinal);
		}

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
		public bool SpanCharTrimFalse() => MemoryExtensions.Equals(_y__.AsSpan().Trim(), _n__, StringComparison.Ordinal);


		[Benchmark]
		public bool SpanCharTrimLenFalse()
		{
			var t = _y__.AsSpan().Trim();
			var len = t.Length;
			return len == _n__.Length && MemoryExtensions.Equals(t, _n__, StringComparison.Ordinal);
		}

		[Benchmark]
		public bool SpanCharTrimSpanLenFalse()
		{
			var t = _y__.AsSpan().Trim();
			var t2 = _n__.AsSpan();
			var len = t.Length;
			return len == t2.Length && MemoryExtensions.Equals(t, t2, StringComparison.Ordinal);
		}


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
