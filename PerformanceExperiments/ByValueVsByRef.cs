using BenchmarkDotNet.Attributes;
using System.Linq;
using System;

namespace PerformanceExperiments;

public static class ByValueVsByRef
{
	public class IntBenchmark
	{
		private readonly int[] _values;

		public IntBenchmark()
		{
			// Create an array of ints that when summed do not exceed 256.
			_values = Enumerable.Range(12, 100).ToArray();
		}

		[Benchmark(Baseline = true)]
		public int ByValueDirect()
		{
			int result = 0;
			int len = _values.Length;
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(_values[i], _values[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByValueSpan()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(span[i], span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByRef()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(ref span[i], ref span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByIn()
		{
			int result = 0;
			int len = _values.Length;
			ReadOnlySpan<int> span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = SumIn(in span[i], in span[j]);
				}
			}
			return result;
		}

		// Other benchmarks for 'in' keyword and possibly for Span<T> direct access, if needed.

		// Sum methods for int
		private static int Sum(int a, int b) => a + b;
		private static int Sum(ref int a, ref int b) => a + b;
		private static int SumIn(in int a, in int b) => a + b;
		// Additional SumIn method, if required.
	}

	public class CharBenchmark
	{
		private readonly char[] _values;

		public CharBenchmark()
		{
			_values = Enumerable.Range(65, 5).Select(i => (char)i).ToArray();
		}


		[Benchmark(Baseline = true)]
		public int ByValueDirect()
		{
			int result = 0;
			int len = _values.Length;
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(_values[i], _values[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByValueSpan()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(span[i], span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByRef()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(ref span[i], ref span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByIn()
		{
			int result = 0;
			int len = _values.Length;
			ReadOnlySpan<char> span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = SumIn(in span[i], in span[j]);
				}
			}
			return result;
		}


		// Repeat other benchmarks here, similar to IntBenchmark...

		private static int Sum(char a, char b) => a + b;
		private static int Sum(ref char a, ref char b) => a + b;
		private static int SumIn(in char a, in char b) => a + b;
	}

	public class ShortBenchmark
	{
		private readonly short[] _values;

		public ShortBenchmark()
		{
			_values = Enumerable.Range(1, 20).Select(i => (short)i).ToArray();
		}


		[Benchmark(Baseline = true)]
		public int ByValueDirect()
		{
			int result = 0;
			int len = _values.Length;
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(_values[i], _values[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByValueSpan()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(span[i], span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByRef()
		{
			int result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(ref span[i], ref span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public int ByIn()
		{
			int result = 0;
			int len = _values.Length;
			ReadOnlySpan<short> span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = SumIn(in span[i], in span[j]);
				}
			}
			return result;
		}


		private static int Sum(short a, short b) => a + b;
		private static int Sum(ref short a, ref short b) => a + b;
		private static int SumIn(in short a, in short b) => a + b;
	}

	public class DecimalBenchmark
	{
		private readonly decimal[] _values;

		public DecimalBenchmark()
		{
			_values = Enumerable.Range(1, 10).Select(i => (decimal)i / 10m).ToArray();
		}


		[Benchmark(Baseline = true)]
		public decimal ByValueDirect()
		{
			decimal result = 0;
			int len = _values.Length;
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(_values[i], _values[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public decimal ByValueSpan()
		{
			decimal result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(span[i], span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public decimal ByRef()
		{
			decimal result = 0;
			int len = _values.Length;
			var span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = Sum(ref span[i], ref span[j]);
				}
			}
			return result;
		}

		[Benchmark]
		public decimal ByIn()
		{
			decimal result = 0;
			int len = _values.Length;
			ReadOnlySpan<decimal> span = _values.AsSpan();
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					result = SumIn(in span[i], in span[j]);
				}
			}
			return result;
		}


		private static decimal Sum(decimal a, decimal b) => a + b;
		private static decimal Sum(ref decimal a, ref decimal b) => a + b;
		private static decimal SumIn(in decimal a, in decimal b) => a + b;
	}

}