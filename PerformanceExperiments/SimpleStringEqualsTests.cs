using BenchmarkDotNet.Attributes;

namespace PerformanceExperiments
{
	public class SimpleStringEqualsTests
	{
		string Empty = "";
		string Space = " ";

		[Benchmark]
		public bool IsEmptyStringEqual()
		{
			return Empty == string.Empty & Space == string.Empty;
		}


		[Benchmark]
		public bool IsEmptyStringEqualLength()
		{
			return Empty.Length == 0 & Space.Length == 0;
		}

		[Benchmark]
		public bool IsEmptyStringEqualNonNullLength()
		{
			return Empty is not null & Empty!.Length == 0 & Space is not null & Space!.Length == 0;
		}

		[Benchmark]
		public bool IsEmptyStringEqualIsObjectLength()
		{
			return Empty is object & Empty!.Length == 0 & Space is object & Space!.Length == 0;
		}

		[Benchmark]
		public bool IsEmptyStringRefEqualLength()
		{
			return ReferenceEquals(Empty, null) & Empty!.Length == 0 & ReferenceEquals(Space, null) & Space!.Length == 0;
		}

		[Benchmark]
		public bool IsNullOrEmpty()
		{
			return string.IsNullOrEmpty(Empty) & string.IsNullOrEmpty(Space);
		}
	}
}
