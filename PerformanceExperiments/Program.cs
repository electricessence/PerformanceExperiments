using BenchmarkDotNet.Running;
using System;

namespace PerformanceExperiments
{
	class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<StringTrimToLowerTests>();
		}
	}
}
