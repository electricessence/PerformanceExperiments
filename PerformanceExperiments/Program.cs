using BenchmarkDotNet.Running;

namespace PerformanceExperiments
{
	class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<StringTests>();
			BenchmarkRunner.Run<SpanTests>();
			BenchmarkRunner.Run<IgnoreWhitespaceStringComparerTests>();
		}
	}
}
