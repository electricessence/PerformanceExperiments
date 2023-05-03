using BenchmarkDotNet.Attributes;
using Open.Collections;
using Open.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace PerformanceExperiments;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>")]
public class DictionaryTests
{
	const int Size = 1000000;
	static readonly IEnumerable<int> Keys = Enumerable.Range(0, Size);

	// Scramble the order, but be repeatable.
	static readonly int[] KeyOrder = Keys.Shuffle().ToArray();

	static readonly Dictionary<int, int> Di
		= Keys.ToDictionary(k => k, k => Random.Shared.Next(Size));

	static readonly ImmutableDictionary<int, int> ImDi
		= Di.ToImmutableDictionary();

	static readonly SortedDictionary<int, int> SoDi
		= Di.ToSortedDictionary();

	[IterationSetup]
	public void Setup()
	{
		// Just make sure they're initialized.
		IDictionary<int, int> d = Di;
		d = ImDi;
		d = SoDi;
	}

	static TValue ReadFromDictionary<TValue>(IReadOnlyDictionary<int, TValue> d, int size = Size)
	{
		TValue result = default!;
		for (var i = 0; i < size; i++)
		{
			result = d[KeyOrder[i]];
		}
		return result;
	}

	[Benchmark(Baseline = true)]
	public int DictionaryRead() => ReadFromDictionary(Di);

	[Benchmark]
	public int ImmutableDictionaryRead() => ReadFromDictionary(ImDi);

	[Benchmark]
	public int SortedDictionaryRead() => ReadFromDictionary(SoDi);

	public static void TestAll()
	{
		var bench = new DictionaryTests();
		_ = bench.DictionaryRead();
		_ = bench.ImmutableDictionaryRead();
		_ = bench.SortedDictionaryRead();
		const int repeat = 100;

		Console.WriteLine("DictionaryRead: {0}", TimedResult.Measure(() =>
		{
			for (var i = 0; i < repeat; i++)
				_ = bench.DictionaryRead();
		}));

		Console.WriteLine("ImmutableDictionaryRead: {0}", TimedResult.Measure(() =>
		{
			for (var i = 0; i < repeat; i++)
				_ = bench.ImmutableDictionaryRead();
		}));

		Console.WriteLine("SortedDictionaryRead: {0}", TimedResult.Measure(() =>
		{
			for (var i = 0; i < repeat; i++)
				_ = bench.SortedDictionaryRead();
		}));
	}
}
