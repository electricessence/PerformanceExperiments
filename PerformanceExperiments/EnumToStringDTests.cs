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
		foreach(var e in Values)
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
}
