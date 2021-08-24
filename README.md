# Performance Experiments

This repo uses BenchmarkDotNet to determine which operations perform better by speed and memory use.

## String vs Span Compare

### Case Sensitive

https://github.com/electricessence/PerformanceExperiments/blob/master/PerformanceExperiments/StringTrimTests.cs

|              Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|-------------------- |----------:|----------:|----------:|-------:|----------:|
|          StringTrim | 22.838 ns | 0.2709 ns | 0.2534 ns | 0.0115 |      24 B |
|   StringTrimLenChar | 19.376 ns | 0.2803 ns | 0.2622 ns | 0.0115 |      24 B |
|     StringTrimLenY1 | 28.597 ns | 0.7921 ns | 2.3106 ns | 0.0115 |      24 B |
|     StringTrimLenY2 | 20.208 ns | 0.1858 ns | 0.1647 ns | 0.0153 |      32 B |
|      StringTrimLenN | 23.369 ns | 0.3616 ns | 0.3206 ns | 0.0115 |      24 B |
|        SpanCharTrim | 15.249 ns | 0.2099 ns | 0.1861 ns |      - |         - |
| SpanCharTrimLenChar |  9.510 ns | 0.1270 ns | 0.1248 ns |      - |         - |
|   SpanCharTrimLenY1 | 15.968 ns | 0.3410 ns | 0.3190 ns |      - |         - |
|   SpanCharTrimLenY2 | 10.244 ns | 0.2323 ns | 0.2282 ns |      - |         - |
|    SpanCharTrimLenN | 16.544 ns | 0.2941 ns | 0.2751 ns |      - |         - |


### Case Insensitive

https://github.com/electricessence/PerformanceExperiments/blob/master/PerformanceExperiments/StringTrimToLowerTests.cs

|              Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
|          StringTrim | 46.77 ns | 0.950 ns | 0.742 ns | 0.0229 |      48 B |
|   StringTrimCompare | 25.51 ns | 0.202 ns | 0.189 ns | 0.0115 |      24 B |
|   StringTrimLenChar | 42.61 ns | 0.528 ns | 0.494 ns | 0.0229 |      48 B |
|     StringTrimLenY1 | 47.25 ns | 0.455 ns | 0.403 ns | 0.0229 |      48 B |
|     StringTrimLenY2 | 45.52 ns | 0.671 ns | 0.628 ns | 0.0306 |      64 B |
|      StringTrimLenN | 50.87 ns | 0.875 ns | 0.818 ns | 0.0229 |      48 B |
|        SpanCharTrim | 16.38 ns | 0.342 ns | 0.320 ns |      - |         - |
| SpanCharTrimLenChar | 10.23 ns | 0.144 ns | 0.113 ns |      - |         - |
|   SpanCharTrimLenY1 | 18.22 ns | 0.380 ns | 0.390 ns |      - |         - |
|   SpanCharTrimLenY2 | 11.59 ns | 0.271 ns | 0.266 ns |      - |         - |
|    SpanCharTrimLenN | 18.76 ns | 0.307 ns | 0.329 ns |      - |         - |
