﻿using BenchmarkDotNet.Running;

namespace PerformanceExperiments
{
	class Program
	{
		static void Main()
		{
			//BenchmarkRunner.Run<StringTests>();
			//BenchmarkRunner.Run<SpanTests>();
			//BenchmarkRunner.Run<IgnoreWhitespaceStringComparerTests>();
			//BenchmarkRunner.Run<StringEqualsTests>();
			//BenchmarkRunner.Run<SimpleStringEqualsTests>();
			//BenchmarkRunner.Run<SwitchTests>();
			BenchmarkRunner.Run<EnumParseTests>();
		}
	}
}
