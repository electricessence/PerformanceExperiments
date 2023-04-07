using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments;

public class TypeofVsIs
{
	const int Iterations = 100000;

	[Benchmark]
	public double Is()
	{
		var result = double.NaN;
		for(int i = 0; i < Iterations; i++)
		{
			double d = i;
			if (!IsDouble(i)
			&& IsDouble(d)
			&& IsDouble(double.NaN))
				result = d;
		}
		return result;
	}

	[Benchmark]
	public double TypeOf()
	{
		var result = double.NaN;
		for (int i = 0; i < Iterations; i++)
		{
			double d = i;
			if (!TypeOfDouble(i)
			&& TypeOfDouble(d)
			&& TypeOfDouble(double.NaN))
				result = d;
		}
		return result;
	}

	static bool IsDouble<T>(T value)
		=> value is double;

	static bool TypeOfDouble<T>(T value)
		=> typeof(T)==typeof(double);
}
