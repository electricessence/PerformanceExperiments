using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceExperiments
{
	public class SwitchTests
	{

		[Benchmark]
		public int If()
			=> Y(1) + Y(2) + Y(3) + Y(4) + Y(5) + Y(1) + Y(2) + Y(3) + Y(4) + Y(5);

		[Benchmark]
		public int Switch()
			=> X(1) + X(2) + X(3) + X(4) + X(5) + X(1) + X(2) + X(3) + X(4) + X(5);

		[Benchmark]
		public int SwitchExpression()
			=> XE(1) + XE(2) + XE(3) + XE(4) + XE(5) + XE(1) + XE(2) + XE(3) + XE(4) + XE(5);

		static int Y(int a)
		{
			if (a == 1)
				return 10;
			if (a == 2)
				return 20;
			if (a == 3)
				return 30;
			if (a == 4)
				return 40;
			return 0;
		}

		static int X(int a)
		{
			switch (a)
			{
				case 1:
					return 10;
				case 2:
					return 20;
				case 3:
					return 30;
				case 4:
					return 40;
				default:
					return 0;
			}
		}

		static int XE(int a)
		=> a switch
		{
			1 => 10,
			2 => 20,
			3 => 30,
			4 => 40,
			_ => 0,
		};
	}
}
