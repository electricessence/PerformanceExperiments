# Performance Experiments

This repo uses BenchmarkDotNet to determine which operations perform better by speed and memory use.

## String vs Span Compare

### Case Sensitive

https://github.com/electricessence/PerformanceExperiments/blob/master/PerformanceExperiments/StringTrimTests.cs

|                    Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
|-------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
|                StringTrim | 22.770 ns | 0.2904 ns | 0.2716 ns | 22.740 ns | 0.0115 |      24 B |
|         StringTrimCompare | 24.343 ns | 0.2780 ns | 0.2321 ns | 24.404 ns | 0.0115 |      24 B |
|    StringTrimCompareFalse | 23.166 ns | 0.3120 ns | 0.2919 ns | 23.163 ns | 0.0115 |      24 B |
| StringTrimCompareLenFalse | 19.970 ns | 0.2649 ns | 0.2478 ns | 19.930 ns | 0.0115 |      24 B |
|         StringTrimLenChar | 20.591 ns | 0.3796 ns | 0.3551 ns | 20.691 ns | 0.0115 |      24 B |
|           StringTrimLenY1 | 25.045 ns | 0.4378 ns | 0.4095 ns | 24.991 ns | 0.0115 |      24 B |
|           StringTrimLenY2 | 22.356 ns | 0.3730 ns | 0.3489 ns | 22.409 ns | 0.0153 |      32 B |
|            StringTrimLenN | 27.194 ns | 0.5630 ns | 0.4991 ns | 27.216 ns | 0.0115 |      24 B |
|                           |           |           |           |           |        |           |
|              SpanCharTrim | 19.040 ns | 0.4128 ns | 0.4239 ns | 18.888 ns |      - |         - |
|         SpanCharTrimFalse | 15.995 ns | 0.3457 ns | 0.3395 ns | 15.946 ns |      - |         - |
|      SpanCharTrimLenFalse |  8.819 ns | 0.2347 ns | 0.6882 ns |  8.628 ns |      - |         - |
|  SpanCharTrimSpanLenFalse |  9.231 ns | 0.1156 ns | 0.1025 ns |  9.222 ns |      - |         - |
|       SpanCharTrimLenChar |  9.709 ns | 0.2269 ns | 0.2012 ns |  9.775 ns |      - |         - |
|         SpanCharTrimLenY1 | 17.023 ns | 0.3781 ns | 0.3714 ns | 16.981 ns |      - |         - |
|         SpanCharTrimLenY2 | 11.056 ns | 0.1378 ns | 0.1150 ns | 11.080 ns |      - |         - |
|          SpanCharTrimLenN | 17.537 ns | 0.2692 ns | 0.2518 ns | 17.546 ns |      - |         - |


### Case Insensitive

https://github.com/electricessence/PerformanceExperiments/blob/master/PerformanceExperiments/StringTrimToLowerTests.cs

|                    Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|-------------------------- |----------:|----------:|----------:|-------:|----------:|
|                StringTrim | 47.314 ns | 0.4928 ns | 0.4115 ns | 0.0229 |      48 B |
|         StringTrimCompare | 26.695 ns | 0.4850 ns | 0.4299 ns | 0.0115 |      24 B |
|    StringTrimCompareFalse | 23.393 ns | 0.2536 ns | 0.2248 ns | 0.0115 |      24 B |
| StringTrimCompareLenFalse | 20.956 ns | 0.4542 ns | 0.5231 ns | 0.0115 |      24 B |
|         StringTrimLenChar | 47.693 ns | 0.5257 ns | 0.4660 ns | 0.0229 |      48 B |
|           StringTrimLenY1 | 53.986 ns | 1.0904 ns | 1.1197 ns | 0.0229 |      48 B |
|           StringTrimLenY2 | 48.509 ns | 0.8332 ns | 0.7793 ns | 0.0306 |      64 B |
|            StringTrimLenN | 53.363 ns | 1.0987 ns | 1.0277 ns | 0.0229 |      48 B |
|                           |           |           |           |        |           |
|              SpanCharTrim | 16.426 ns | 0.3436 ns | 0.3214 ns |      - |         - |
|         SpanCharTrimFalse | 13.658 ns | 0.2282 ns | 0.2023 ns |      - |         - |
|      SpanCharTrimLenFalse |  9.306 ns | 0.2195 ns | 0.2440 ns |      - |         - |
|  SpanCharTrimSpanLenFalse | 10.351 ns | 0.1655 ns | 0.1548 ns |      - |         - |
|       SpanCharTrimLenChar |  9.540 ns | 0.1500 ns | 0.1329 ns |      - |         - |
|         SpanCharTrimLenY1 | 15.990 ns | 0.2528 ns | 0.2365 ns |      - |         - |
|         SpanCharTrimLenY2 | 10.241 ns | 0.1904 ns | 0.1781 ns |      - |         - |
|          SpanCharTrimLenN | 15.133 ns | 0.2833 ns | 0.2650 ns |      - |         - |
