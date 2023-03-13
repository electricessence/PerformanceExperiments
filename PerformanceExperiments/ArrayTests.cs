using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Collections.ObjectModel;

namespace PerformanceExperiments;

[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>")]
public class ArrayTests
{
	const int Size = 200000000;

	static readonly int[] Values = Enumerable.Range(0, Size).ToArray();
	static readonly ReadOnlyCollection<int> ValuesReadOnly = Array.AsReadOnly(Values);
	static readonly ReadOnlyMemory<int> ValuesMemory = Values;
	static readonly ImmutableArray<int> ValuesImmutable = Values.ToImmutableArray();

	[Benchmark]
	public int ArrayRead()
	{
		int x = -1;
		for(var i = 0; i < Size; i++)
		{
			x = Values[i];
		}
		return x;
	}

	//[Benchmark]
	//public int ArrayReadOnlyRead()
	//{
	//	int x = -1;
	//	for (var i = 0; i < Size; i++)
	//	{
	//		x = ValuesReadOnly[i];
	//	}
	//	return x;
	//}

	[Benchmark]
	public int MemoryRead()
	{
		int x = -1;
		var span = ValuesMemory.Span;
		for (var i = 0; i < Size; i++)
		{
			x = span[i];
		}
		return x;
	}

	[Benchmark]
	public int ImmutableRead()
	{
		int x = -1;
		for (var i = 0; i < Size; i++)
		{
			x = ValuesImmutable[i];
		}
		return x;
	}

	[Benchmark]
	public int ImmutableReadRef()
	{
		var x = ValuesImmutable.ItemRef(0);
		for (var i = 1; i < Size; i++)
		{
			 x = ValuesImmutable.ItemRef(i);
		}
		return x;
	}

	[Benchmark]
	public int ImmutableReadSpan()
	{
		int x = -1;
		var span = ValuesImmutable.AsSpan();
		for (var i = 0; i < Size; i++)
		{
			x = span[i];
		}
		return x;
	}

}
