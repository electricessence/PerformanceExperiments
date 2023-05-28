using BenchmarkDotNet.Attributes;
using FastExpressionCompiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Linq.Expressions.Expression;

namespace PerformanceExperiments;

public enum GreekLetters
{
	Alpha,
	Beta,
	Gamma,
	Delta,
	Epsilon,
	Zeta,
	Eta,
	Theta,
	Iota,
	Kappa,
	Lambda,
	Mu,
	Nu,
	Xi,
	Omicron,
	Pi,
	Rho,
	Sigma,
	Tau,
	Upsilon,
	Phi,
	Chi,
	Psi,
	Omega
}

public class ExpressionTreeTest
{
	public static GreekLetters ParseGreekLetterHardCoded(string s)
	{
		switch (s.Length)
		{
			case 2:
				switch (s)
				{
					case "Mu": return GreekLetters.Mu;
					case "Nu": return GreekLetters.Nu;
					case "Pi": return GreekLetters.Pi;
				}
				break;

			case 3:
				switch (s)
				{
					case "Eta": return GreekLetters.Eta;
					case "Rho": return GreekLetters.Rho;
					case "Tau": return GreekLetters.Tau;
					case "Chi": return GreekLetters.Chi;
					case "Phi": return GreekLetters.Phi;
					case "Psi": return GreekLetters.Psi;
				}
				break;

			case 4:
				switch (s)
				{
					case "Beta": return GreekLetters.Beta;
					case "Zeta": return GreekLetters.Zeta;
					case "Iota": return GreekLetters.Iota;
				}
				break;

			case 5:
				switch (s)
				{
					case "Alpha": return GreekLetters.Alpha;
					case "Gamma": return GreekLetters.Gamma;
					case "Delta": return GreekLetters.Delta;
					case "Theta": return GreekLetters.Theta;
					case "Kappa": return GreekLetters.Kappa;
					case "Sigma": return GreekLetters.Sigma;
				}
				break;

			case 6:
				switch (s)
				{
					case "Lambda": return GreekLetters.Lambda;
				}
				break;

			case 7:
				switch (s)
				{
					case "Epsilon": return GreekLetters.Epsilon;
					case "Upsilon": return GreekLetters.Upsilon;
					case "Omicron": return GreekLetters.Omicron;
				}
				break;

			case 8:
				switch (s)
				{
					case "Omega": return GreekLetters.Omega;
				}
				break;
		}

		throw new ArgumentException($"Invalid Greek letter {s}");
	}

	internal static class DictCompile<TValue>
	{
		public static Func<string, ValueLookupResult> GetDictionaryTryParseDelegate(IDictionary<string, TValue> dictionary)
		{
			var valueParam = Parameter(typeof(string), "value");
			var lengthParam = Variable(typeof(int), "length");
			var defaultExpression = CreateNewTuple(false, default!);
			var dictValues = dictionary.Select(kvp => (value: kvp.Value, name: kvp.Key));
			var nameGroups = dictValues.GroupBy(v => v.name.Length).OrderBy(g => g.Key);
			var lengthCheckCases = nameGroups.Select(group =>
				SwitchCase(
					Switch(
						valueParam,
						defaultExpression,
						null,
						group.Select(v => SwitchCase(
							CreateNewTuple(true, v.value),
							Constant(v.name)
						)).ToArray()
					),
					Constant(group.Key)
				)
			).ToArray();

			return Lambda<Func<string, ValueLookupResult>>(
				Block(new[] { lengthParam },
					Assign(lengthParam, Property(valueParam, nameof(string.Length))),
					Switch(
						lengthParam,
						defaultExpression,
						null,
						lengthCheckCases
					)
				),
				valueParam
			).CompileFast();

			static Expression CreateNewTuple(bool success, TValue value)
				=> New(
					typeof(ValueLookupResult).GetConstructor(new[] { typeof(bool), typeof(TValue) })!,
					Constant(success),
					Constant(value)
				);
		}


		public readonly struct ValueLookupResult
		{
			public ValueLookupResult(bool success, TValue value)
			{
				Success = success;
				Value = value;
			}

			public bool Success { get; }
			public TValue Value { get; }

			public void Deconstruct(out bool success, out TValue value)
			{
				success = Success;
				value = Value;
			}
		}

	}


	static readonly Func<string, GreekLetters> GreekLetterLookup = CreateGreekLetterParser();

	private static readonly string[] greekLetterStrings = Enum.GetNames(typeof(GreekLetters));

	[Benchmark(Baseline = true)]
	public GreekLetters ParseGreekLetterHardCoded()
	{
		GreekLetters result = default;
		for (int i = 0; i < greekLetterStrings.Length; i++)
		{
			result = ParseGreekLetterHardCoded(greekLetterStrings[i]);
		}
		return result;
	}

	[Benchmark]
	public GreekLetters ParseGreekLetterExpressionTree()
	{
		GreekLetters result = default;
		for (int i = 0; i < greekLetterStrings.Length; i++)
		{
			result = GreekLetterLookup(greekLetterStrings[i]);
		}
		return result;
	}
}
