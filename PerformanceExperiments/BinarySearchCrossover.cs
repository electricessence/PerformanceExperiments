using BenchmarkDotNet.Attributes;
using System;
using System.Diagnostics;
using System.Linq;

namespace PerformanceExperiments;
public class BinarySearchCrossover
{
	private const int MaxArraySize = 100;
	private readonly int[] _array;

	public BinarySearchCrossover()
	{
		_array = Enumerable.Range(0, MaxArraySize).ToArray();
	}

	[Params(5, 10, 25, 50, 75, 100)]
	public int ArraySize { get; set; }

	private static int LinearSearch(
		ReadOnlySpan<int> span, int value)
	{
		var len = span.Length;
		for (var i = 0; i < len; i++)
		{
			if (span[i] == value)
			{
				return i;
			}
		}

		return -1;
	}

	private static int BinarySearch(
		ReadOnlySpan<int> span, int value)
	{
		var anchor = 0;

	search:
		switch (span.Length)
		{
			case 1:
				if (span[0] == value)
					return anchor;

				break;

			case 2:
				if (span[1] == value)
					return anchor + 1;

				span = span[..1];
				goto search;

			default:
				int i = span.Length / 2;
				var midValue = span[i];
				switch ((value.CompareTo(midValue) >> 31) | 1)
				{
					case 0:
						return anchor + i;

					case -1:
						span = span[..i];
						goto search;

					case +1:
						anchor = i + 1;
						span = span.Slice(anchor);
						goto search;
				}

				Debug.Fail("Should never have arrived here");

				break;
		}

		return -1;
	}

	[Benchmark]
	public int LinearSearch()
	{
		var span = _array.AsSpan(0, ArraySize);
		var x = -1;
		for (var i = 0; i < ArraySize; i++)
			x = LinearSearch(span, i);

		return x;
	}

	[Benchmark]
	public int BinarySearch()
	{
		var span = _array.AsSpan(0, ArraySize);
		var x = -1;
		for (var i = 0; i < ArraySize; i++)
			x = BinarySearch(span, i);

		return x;
	}
}