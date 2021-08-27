using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceExperiments
{
	[MemoryDiagnoser]
	public abstract class ComparisonTestBase
	{
		const string y = "y";
		const string _y__ = " y  ";
		const string _n__ = " n  ";
		const string _yx__ = " yx  ";
		const string _Y__ = " Y  ";
		const string _N__ = " N  ";
		const string _Yx__ = " Yx  ";
		const string Hello_World = "Hello World";
		const string Hello_World_ = "Hello World ";
		const string Hello_world = "Hello world";
		const string Hello_world_ = "Hello world ";
		const string Fox1 = "The quick fox jumped over the lazy dog.";
		const string Fox2 = "The quick Fox jumped over the Lazy dog.";
		const string Fox3 = " The quick fox jumped over the lazy dog. ";
		const string Fox4 = " The quick Fox jumped over the Lazy dog. ";

		[Params(StringComparison.Ordinal, StringComparison.OrdinalIgnoreCase)]
		public virtual StringComparison Comparison { get; set; }

		[Params("", _y__, _n__, _yx__, Hello_World, Hello_world, Fox1, Fox2)]
		public string A { get; set; }

		[Params("", y, _y__, _n__, _yx__, _Y__, _N__, _Yx__, Hello_World, Hello_world, Hello_World_, Hello_world_, Fox1, Fox2, Fox3, Fox4)]
		public string B { get; set; }

		public abstract bool Equals();
	}
}

