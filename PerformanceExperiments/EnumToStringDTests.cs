using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace PerformanceExperiments;

[MemoryDiagnoser]
public class EnumToStringDTests
{
	private static readonly IReadOnlyList<Greek> Values = Array.AsReadOnly(Enum.GetValues<Greek>());

	[Benchmark]
	public string IntToString()
	{
		var s = "";
		foreach (var e in Values)
		{
			var i = (int)e;
			s = i.ToString();
		}

		return s;
	}

	[Benchmark]
	public string ToStringD()
	{
		var s = "";
		foreach (var e in Values)
			s = e.ToString("D");

		return s;
	}

	[Benchmark]
	public string ToIntString()
	{
		var s = "";
		foreach (var e in Values)
			s = ToIntString(e);

		return s;
	}

	private static string ToIntString<T>(T e)
		where T : Enum
	{
		var i = (int)Convert.ChangeType(e, typeof(int));
		return i.ToString();
	}
}
