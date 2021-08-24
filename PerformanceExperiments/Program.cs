using BenchmarkDotNet.Running;
using System;

namespace PerformanceExperiments
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<StringTrimTests>();
		}
	}
}
