using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments;

public class DictionaryVsArray
{
	[Params(12, 14, 16)]
	public int N { get; set; }

	private Dictionary<string, int>? _dictionary;
	private KeyValuePair<string, int>[]? _array;
	private string[]? _keys;

	[GlobalSetup]
	public void Setup()
	{
		_dictionary = new Dictionary<string, int>(N);
		_array = new KeyValuePair<string, int>[N];
		_keys = new string[N];

		var random = new Random();
		for (int i = 0; i < N; i++)
		{
			string key = Guid.NewGuid().ToString();
			int value = random.Next(N * 2);

			_dictionary[key] = value;
			_array[i] = new KeyValuePair<string, int>(key, value);
			_keys[i] = key;
		}

		Array.Sort(_array, (x, y) => x.Key.CompareTo(y.Key));
	}

	[Benchmark(Baseline = true)]
	public int DictionaryLookup()
	{
		int result = 0;
		foreach (var key in _keys.AsSpan())
		{
			if (_dictionary!.TryGetValue(key, out var value))
				result += value;
		}
		return result;
	}

	[Benchmark]
	public int BruteForceArrayLookup()
	{
		int result = 0;
		var span = _array.AsSpan();
		foreach (var key in _keys.AsSpan())
		{
			foreach (var pair in span)
			{
				if (pair.Key == key)
				{
					result += pair.Value;
					break;
				}
			}
		}
		return result;
	}

	//[Benchmark]
	public int BruteForceDictionaryLookup()
	{
		int result = 0;
		foreach (var key in _keys.AsSpan())
		{
			foreach (var pair in _dictionary!)
			{
				if (pair.Key == key)
				{
					result += pair.Value;
					break;
				}
			}
		}
		return result;
	}

	//[Benchmark]
	public int BinarySearchArrayLookupSpan()
	{
		int result = 0;
		var arraySpan = _array.AsSpan();

		foreach (var key in _keys.AsSpan())
		{
			int index = BinarySearch(arraySpan, key);

			if (index == -1)
				continue;

			result += arraySpan[index].Value;
		}
		return result;
	}

	//[Benchmark]
	public int BinarySearchArrayLookupSpan2()
	{
		int result = 0;
		var arraySpan = _array.AsSpan();

		foreach (var key in _keys.AsSpan())
		{
			if(TryBinarySearch(arraySpan, key, out var value))
				result += value;
		}
		return result;
	}

	private static int BinarySearch<TKey, TValue>(Span<KeyValuePair<TKey, TValue>> span, TKey key)
		where TKey : IComparable<TKey>
	{
		int left = 0;
		int right = span.Length - 1;

		while (left <= right)
		{
			int middle = left + (right - left) / 2;
			var middleKey = span[middle].Key;

			if (right - left < 4 && middleKey.Equals(key))
				return middle;

			var comparison = middleKey.CompareTo(key);
			if (comparison < 0)
				left = middle + 1;
			else if(comparison > 0)
				right = middle - 1;
			else
				return middle;
		}

		return -1;
	}

	private static bool TryBinarySearch<TKey, TValue>(Span<KeyValuePair<TKey, TValue>> span, TKey key, out TValue value)
		where TKey : IComparable<TKey>
	{
	// Use a custom binary search to optimize for potentially larger cases.
	search:
		switch (span.Length)
		{
			case 1:
			{
				var (k, v) = span[0];
				if (k!.Equals(key))
				{
					value = v;
					return true;
				}

				break;
			}

			case 2:
			{
				var (k, v) = span[0];
				if (k!.Equals(key))
				{
					value = v;
					return true;
				}

				span = span.Slice(1, 1);
				goto search;
			}

			default:
			{
				int i = span.Length / 2;
				var (k, v) = span[i];
				var comparison = key.CompareTo(k);
				switch (Math.Sign(comparison))
				{
					case 0:
						value = v;
						return true;

					case -1:
						span = span[..i];
						goto search;

					case +1:
						span = span[(i + 1)..];
						goto search;
				}

				Debug.Fail("Should never have arrived here");

				break;
			}
		}

		value = default!;
		return false;
	}
}