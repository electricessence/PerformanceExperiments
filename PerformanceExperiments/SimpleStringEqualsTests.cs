using BenchmarkDotNet.Attributes;
using System.Diagnostics.CodeAnalysis;

namespace PerformanceExperiments
{
	[SuppressMessage("Roslynator", "RCS1156:Use string.Length instead of comparison with empty string.")]
	[SuppressMessage("Roslynator", "RCS1233:Use short-circuiting operator.")]
	[SuppressMessage("Roslynator", "RCS1169:Make field read-only.")]
	[SuppressMessage("Style", "IDE0044:Add readonly modifier")]
	[SuppressMessage("Style", "IDE0150:Prefer 'null' check over type check")]
	[SuppressMessage("Style", "IDE0041:Use 'is null' check")]
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
