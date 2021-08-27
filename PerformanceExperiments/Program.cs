using BenchmarkDotNet.Running;

namespace PerformanceExperiments
{
	class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<StringTrimTests>();
			BenchmarkRunner.Run<StringTrimToLowerTests>();
		}
	}
}
