using BenchmarkDotNet.Attributes;
using System;

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
		public bool StringTrim() => _y__.Trim().ToLower() == y;


		[Benchmark]
		public bool StringTrimCompare() => _y__.Trim().Equals(y, StringComparison.OrdinalIgnoreCase);


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
		public bool SpanCharTrim() => MemoryExtensions.Equals(_y__.AsSpan().Trim(), y, StringComparison.OrdinalIgnoreCase);


		[Benchmark]
		public bool SpanCharTrimLenChar()
		{
			var t = _y__.AsSpan().Trim();
			if (t.Length != 1) return false;
			ref readonly var f = ref t[0];
			return f=='y' || f=='Y';
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
