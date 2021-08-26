using BenchmarkDotNet.Attributes;
using System;
using Sylvan;

namespace PerformanceExperiments
{
	[MemoryDiagnoser]
	public class StringTrimToLowerTests
	{
		const string y = "y";
		const string _n__ = " N  ";
		const string _y__ = " Y  ";
		const string _yx__ = " Yx  ";

		[Benchmark]
		public bool StringTrim()
		{
			return _y__.Trim().ToLower() == y;
		}

		[Benchmark]
		public bool StringTrimCompare()
		{
			return _y__.Trim().Equals(y, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool StringTrimCompareFalse()
		{
			return _y__.Trim().Equals(_n__, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool StringTrimCompareLenFalse()
		{
			var t = _y__.Trim();
			var len = t.Length;
			return len == _n__.Length && t.Equals(_n__, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool StringTrimLenChar()
		{
			var t = _y__.Trim().ToLower();
			return t.Length == 1 && t[0] == 'y';
		}

		[Benchmark]
		public bool StringTrimLenY1()
		{
			var t = _y__.Trim().ToLower();
			return t.Length == 1 && t == y;
		}

		[Benchmark]
		public bool StringTrimLenY2()
		{

			var t = _yx__.Trim().ToLower();
			return t.Length == 1 && t == y;
		}

		[Benchmark]
		public bool StringTrimLenN()
		{
			var t = _n__.Trim().ToLower();
			return t.Length == 1 && t == y;
		}

		[Benchmark]
		public bool CustomStringTrimCompareFalse()
		{
			return IgnoreWhitespaceStringComparer.IgnoreCase.Equals(_y__, _n__);
		}

		[Benchmark]
		public bool CustomStringTrimLenY1()
		{
			return IgnoreWhitespaceStringComparer.IgnoreCase.Equals(_y__, y);
		}

		[Benchmark]
		public bool CustomStringTrimLenY2()
		{
			return IgnoreWhitespaceStringComparer.IgnoreCase.Equals(_yx__, y);
		}

		[Benchmark]
		public bool CustomStringTrimLenN()
		{
			return IgnoreWhitespaceStringComparer.IgnoreCase.Equals(_n__, y);
		}

		[Benchmark]
		public bool SpanCharTrim()
		{
			return MemoryExtensions.Equals(_y__.AsSpan().Trim(), y, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimFalse()
		{
			return MemoryExtensions.Equals(_y__.AsSpan().Trim(), _n__, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimLenFalse()
		{
			var t = _y__.AsSpan().Trim();
			var len = t.Length;
			return len == _n__.Length && MemoryExtensions.Equals(t, _n__, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimSpanLenFalse()
		{
			var t = _y__.AsSpan().Trim();
			var t2 = _n__.AsSpan();
			var len = t.Length;
			return len == t2.Length && MemoryExtensions.Equals(t, t2, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimLenChar()
		{
			var t = _y__.AsSpan().Trim();
			if (t.Length != 1) return false;
			ref readonly var f = ref t[0];
			return f == 'y' || f == 'Y';
		}

		[Benchmark]
		public bool SpanCharTrimLenY1()
		{
			var t = _y__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimLenY2()
		{

			var t = _yx__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool SpanCharTrimLenN()
		{
			var t = _n__.AsSpan().Trim();
			return t.Length == 1 && MemoryExtensions.Equals(t, y, StringComparison.OrdinalIgnoreCase);
		}
	}
}
