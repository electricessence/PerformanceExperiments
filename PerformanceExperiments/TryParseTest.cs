using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments;

public class TryParseTest
{
	readonly string[] Values = new[] { "9", "1000", "0", "xxx", "000xxx", "hello", "$123", "55.66" };

	[Benchmark]
	public void BranchTest()
	{
		foreach (var s in Values) _ = Parse(s);
		static int Parse(string s)
			=> int.TryParse(s, out var val) ? val : 0;
	}

	[Benchmark]
	public void ValueTest()
	{
		foreach (var s in Values) _ = Parse(s);
		static int Parse(string s)
		{
			_ = int.TryParse(s, out int val);
			return val;
		}
	}
}
