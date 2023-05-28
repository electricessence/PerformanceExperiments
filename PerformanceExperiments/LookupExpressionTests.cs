using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;
using Open.Collections;
using FastExpressionCompiler;
using static System.Linq.Expressions.Expression;

namespace PerformanceExperiments;

public class LookupExpresssionTests
{
	private Dictionary<string, string>? dictionary;
	private Func<string, DictCompile<string>.ValueLookupResult>? lookupFunction;
	private string[]? keys;

	[Params(1000)]//, 10000, 100000)]
	public int N;

	[GlobalSetup]
	public void Setup()
	{
		// Initialize the dictionary with N randomized keys and values
		var rnd = new Random();
		dictionary = Enumerable.Range(0, N)
			.ToDictionary(
				_ => GetRandomString(rnd, rnd.Next(10, 100)), // keys of length 10 to 100
				_ => Guid.NewGuid().ToString());

		// Create a list of shuffled keys for lookups
		keys = dictionary.Keys.OrderBy(_ => rnd.Next()).ToArray();

		// Create the lookup function
		lookupFunction = DictCompile<string>.GetDictionaryTryParseDelegate(dictionary);
	}

	private static string GetRandomString(Random rnd, int length)
	{
		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		return new string(Enumerable.Range(0, length)
			.Select(_ => chars[rnd.Next(chars.Length)]).ToArray());
	}


	[Benchmark(Baseline = true)]
	public string? TestDictionary()
	{
		string? value = null;
		foreach (var key in keys!)
		{
			dictionary!.TryGetValue(key, out value);
		}
		return value;
	}

	[Benchmark]
	public string? TestLookupFunction()
	{
		string? value = null;
		foreach (var key in keys!)
		{
			var x = lookupFunction!(key);
			if (x.Success) value = x.Value;
		}
		return value;
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
					Constant(value, typeof(TValue))
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
}
