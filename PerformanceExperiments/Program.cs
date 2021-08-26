using BenchmarkDotNet.Running;

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
