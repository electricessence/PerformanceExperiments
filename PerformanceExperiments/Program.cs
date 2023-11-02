using BenchmarkDotNet.Running;
using PerformanceExperiments;
using System;

BenchmarkRunner.Run(new[] { typeof(ByValueVsByRef.IntBenchmark), typeof(ByValueVsByRef.CharBenchmark), typeof(ByValueVsByRef.ShortBenchmark), typeof(ByValueVsByRef.DecimalBenchmark) });
//BenchmarkRunner.Run<ArrayTests>();
//BenchmarkRunner.Run<HasDigitBenchmarks>();
//BenchmarkRunner.Run<StringTests>();
//BenchmarkRunner.Run<SpanTests>();
//BenchmarkRunner.Run<IgnoreWhitespaceStringComparerTests>();
//BenchmarkRunner.Run<StringEqualsTests>();
//BenchmarkRunner.Run<SimpleStringEqualsTests>();
//BenchmarkRunner.Run<SwitchTests>();
//BenchmarkRunner.Run<EnumParseTests>();
//BenchmarkRunner.Run<TypeofVsIs>();
//BenchmarkRunner.Run<DictionaryTests>();
//DictionaryTests.TestAll();
//BenchmarkRunner.Run<BinarySearchCrossover>();
//BenchmarkRunner.Run<EnumToStringDTests>();
//BenchmarkRunner.Run<XmlDocumentTraversalBenchmarks>();
//BenchmarkRunner.Run<XmlChildNodesBenchmark>();
//BenchmarkRunner.Run<DictionaryVsArray>();
//BenchmarkRunner.Run<HashCodeBenchmark>();
//BenchmarkRunner.Run<XmlCopyBenchmark>();
//BenchmarkRunner.Run<RemoveNonNumbersTests>();
//BenchmarkRunner.Run<XmlLoadBenchmark>();
//BenchmarkRunner.Run<LookupExpresssionTests>();


//Console.WriteLine($"GetHashCodeFromChars 100 collision rate: {HashCollisionTest.Test(s => CharArrayExtensions.GetHashCodeFromChars(s.AsSpan()), 1000000, 100) * 100}%");
//Console.WriteLine($"GetHashCodeFromCharsFNV1a 100 collision rate: {HashCollisionTest.Test(s => CharArrayExtensions.GetHashCodeFromCharsFNV1a(s.AsSpan()), 1000000, 100) * 100}%");

//Console.WriteLine($"GetHashCodeFromChars 1000 collision rate: {HashCollisionTest.Test(s => CharArrayExtensions.GetHashCodeFromChars(s.AsSpan()), 1000000, 1000) * 100}%");
//Console.WriteLine($"GetHashCodeFromCharsFNV1a 1000 collision rate: {HashCollisionTest.Test(s => CharArrayExtensions.GetHashCodeFromCharsFNV1a(s.AsSpan()), 1000000, 1000) * 100}%");
