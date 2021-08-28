``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|                Method |        Comparison |                    A |                    B |      Mean |     Error |    StdDev |    Median | Allocated |
|---------------------- |------------------ |--------------------- |--------------------- |----------:|----------:|----------:|----------:|----------:|
|                **Equals** |           **Ordinal** |                     **** |                     **** |  **6.127 ns** | **0.1146 ns** | **0.1016 ns** |  **6.096 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                      |  4.119 ns | 0.0906 ns | 0.0847 ns |  4.130 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                      |  9.114 ns | 0.1861 ns | 0.1741 ns |  9.163 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                      | 12.655 ns | 0.1281 ns | 0.1198 ns | 12.638 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                      |  7.085 ns | 0.0838 ns | 0.0700 ns |  7.087 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                      | 12.915 ns | 0.1312 ns | 0.1227 ns | 12.869 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                 ** N  ** |  **5.718 ns** | **0.0422 ns** | **0.0353 ns** |  **5.728 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                  N   |  3.987 ns | 0.0605 ns | 0.0566 ns |  3.992 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                  N   | 10.025 ns | 0.2280 ns | 0.3196 ns |  9.971 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                  N   | 19.840 ns | 0.4012 ns | 0.3752 ns | 19.824 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                  N   |  6.939 ns | 0.1701 ns | 0.1671 ns |  6.989 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                  N   | 13.881 ns | 0.1862 ns | 0.1651 ns | 13.826 ns |         - |
|                **Equals** |           **Ordinal** |                     **** | ** The (...)dog.  [41]** |  **5.741 ns** | **0.0823 ns** | **0.0770 ns** |  **5.732 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |  The (...)dog.  [41] |  3.411 ns | 0.0641 ns | 0.0600 ns |  3.406 ns |         - |
|         TrimEqualityA |           Ordinal |                      |  The (...)dog.  [41] |  8.746 ns | 0.1442 ns | 0.1349 ns |  8.730 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |  The (...)dog.  [41] | 16.615 ns | 0.3041 ns | 0.2845 ns | 16.539 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |  The (...)dog.  [41] |  6.634 ns | 0.0785 ns | 0.0735 ns |  6.664 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |  The (...)dog.  [41] | 12.357 ns | 0.1764 ns | 0.1564 ns | 12.339 ns |         - |
|                Equals |           Ordinal |                      |  The (...)dog.  [41] |  6.174 ns | 0.1349 ns | 0.1262 ns |  6.151 ns |         - |
|         EqualsWithLen |           Ordinal |                      |  The (...)dog.  [41] |  3.426 ns | 0.0764 ns | 0.0715 ns |  3.437 ns |         - |
|         TrimEqualityA |           Ordinal |                      |  The (...)dog.  [41] |  8.749 ns | 0.1256 ns | 0.1175 ns |  8.740 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |  The (...)dog.  [41] | 16.572 ns | 0.1806 ns | 0.1689 ns | 16.564 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |  The (...)dog.  [41] |  6.665 ns | 0.1582 ns | 0.1554 ns |  6.580 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |  The (...)dog.  [41] | 12.379 ns | 0.1152 ns | 0.1078 ns | 12.412 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                 ** Y  ** |  **6.126 ns** | **0.1573 ns** | **0.1872 ns** |  **6.136 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                  Y   |  3.872 ns | 0.1032 ns | 0.0965 ns |  3.865 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                  Y   | 10.417 ns | 0.1871 ns | 0.1659 ns | 10.387 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                  Y   | 20.489 ns | 0.3926 ns | 0.3480 ns | 20.357 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                  Y   |  7.587 ns | 0.1838 ns | 0.1435 ns |  7.650 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                  Y   | 13.573 ns | 0.2545 ns | 0.2499 ns | 13.570 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                ** Yx  ** |  **5.841 ns** | **0.1537 ns** | **0.1998 ns** |  **5.816 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                 Yx   |  3.405 ns | 0.0560 ns | 0.0524 ns |  3.399 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                 Yx   |  8.749 ns | 0.1605 ns | 0.1501 ns |  8.754 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                 Yx   | 18.009 ns | 0.2982 ns | 0.2789 ns | 17.884 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                 Yx   |  7.082 ns | 0.1727 ns | 0.2305 ns |  7.048 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                 Yx   | 13.702 ns | 0.2942 ns | 0.3021 ns | 13.567 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                 ** n  ** |  **5.678 ns** | **0.0597 ns** | **0.0498 ns** |  **5.673 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                  n   |  3.432 ns | 0.0756 ns | 0.0707 ns |  3.399 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                  n   |  8.739 ns | 0.1078 ns | 0.1009 ns |  8.786 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                  n   | 16.913 ns | 0.2822 ns | 0.2501 ns | 16.940 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                  n   |  6.659 ns | 0.1417 ns | 0.1257 ns |  6.599 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                  n   | 12.812 ns | 0.2294 ns | 0.2455 ns | 12.747 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                 ** y  ** |  **5.718 ns** | **0.0546 ns** | **0.0510 ns** |  **5.715 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                  y   |  3.417 ns | 0.0491 ns | 0.0460 ns |  3.410 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                  y   |  8.756 ns | 0.1433 ns | 0.1340 ns |  8.728 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                  y   | 16.847 ns | 0.2163 ns | 0.2023 ns | 16.817 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                  y   |  6.587 ns | 0.0792 ns | 0.0661 ns |  6.576 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                  y   | 12.707 ns | 0.2436 ns | 0.2278 ns | 12.594 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                ** yx  ** |  **6.668 ns** | **0.2982 ns** | **0.8313 ns** |  **6.510 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                 yx   |  3.403 ns | 0.1032 ns | 0.2531 ns |  3.391 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                 yx   | 10.026 ns | 0.2249 ns | 0.4387 ns | 10.018 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                 yx   | 19.723 ns | 0.4154 ns | 0.4945 ns | 19.724 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                 yx   |  7.249 ns | 0.1769 ns | 0.1967 ns |  7.286 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                 yx   | 14.835 ns | 0.3280 ns | 0.3646 ns | 14.839 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |          **Hello World** |  **6.197 ns** | **0.1589 ns** | **0.2067 ns** |  **6.237 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |          Hello World |  3.722 ns | 0.1048 ns | 0.1165 ns |  3.739 ns |         - |
|         TrimEqualityA |           Ordinal |                      |          Hello World |  9.350 ns | 0.2197 ns | 0.3962 ns |  9.298 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |          Hello World | 15.424 ns | 0.3382 ns | 0.3619 ns | 15.290 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |          Hello World |  7.054 ns | 0.1051 ns | 0.0983 ns |  7.000 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |          Hello World | 10.052 ns | 0.2186 ns | 0.4515 ns |  9.967 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |         **Hello World ** |  **5.982 ns** | **0.1296 ns** | **0.1213 ns** |  **5.944 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |         Hello World  |  4.895 ns | 0.0676 ns | 0.0599 ns |  4.906 ns |         - |
|         TrimEqualityA |           Ordinal |                      |         Hello World  |  8.975 ns | 0.2076 ns | 0.2132 ns |  8.955 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |         Hello World  | 15.482 ns | 0.3080 ns | 0.2730 ns | 15.506 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |         Hello World  |  6.730 ns | 0.1234 ns | 0.1031 ns |  6.761 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |         Hello World  | 11.063 ns | 0.2470 ns | 0.2940 ns | 11.001 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |          **Hello world** |  **5.773 ns** | **0.0971 ns** | **0.0908 ns** |  **5.767 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |          Hello world |  3.425 ns | 0.0617 ns | 0.0577 ns |  3.399 ns |         - |
|         TrimEqualityA |           Ordinal |                      |          Hello world |  8.812 ns | 0.0860 ns | 0.0718 ns |  8.828 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |          Hello world | 15.118 ns | 0.3235 ns | 0.3177 ns | 15.044 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |          Hello world |  6.762 ns | 0.1365 ns | 0.1277 ns |  6.727 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |          Hello world | 10.024 ns | 0.2251 ns | 0.2105 ns | 10.062 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |         **Hello world ** |  **6.001 ns** | **0.1368 ns** | **0.1213 ns** |  **5.997 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |         Hello world  |  3.855 ns | 0.1118 ns | 0.1772 ns |  3.831 ns |         - |
|         TrimEqualityA |           Ordinal |                      |         Hello world  |  9.327 ns | 0.2039 ns | 0.2791 ns |  9.314 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |         Hello world  | 16.528 ns | 0.3585 ns | 0.4267 ns | 16.502 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |         Hello world  |  7.117 ns | 0.1341 ns | 0.1189 ns |  7.138 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |         Hello world  | 11.412 ns | 0.2606 ns | 0.3388 ns | 11.413 ns |         - |
|                **Equals** |           **Ordinal** |                     **** | **The q(...) dog. [39]** |  **6.040 ns** | **0.1177 ns** | **0.1101 ns** |  **6.063 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      | The q(...) dog. [39] |  3.523 ns | 0.0960 ns | 0.1214 ns |  3.501 ns |         - |
|         TrimEqualityA |           Ordinal |                      | The q(...) dog. [39] |  9.182 ns | 0.2199 ns | 0.1836 ns |  9.178 ns |         - |
|        TrimEqualityAB |           Ordinal |                      | The q(...) dog. [39] | 14.870 ns | 0.3186 ns | 0.2980 ns | 14.909 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      | The q(...) dog. [39] |  6.805 ns | 0.1357 ns | 0.1269 ns |  6.790 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      | The q(...) dog. [39] |  9.754 ns | 0.2087 ns | 0.1630 ns |  9.714 ns |         - |
|                Equals |           Ordinal |                      | The q(...) dog. [39] |  5.828 ns | 0.1082 ns | 0.1012 ns |  5.848 ns |         - |
|         EqualsWithLen |           Ordinal |                      | The q(...) dog. [39] |  3.987 ns | 0.0971 ns | 0.0861 ns |  3.995 ns |         - |
|         TrimEqualityA |           Ordinal |                      | The q(...) dog. [39] |  8.744 ns | 0.1525 ns | 0.1426 ns |  8.704 ns |         - |
|        TrimEqualityAB |           Ordinal |                      | The q(...) dog. [39] | 14.687 ns | 0.2072 ns | 0.1730 ns | 14.675 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      | The q(...) dog. [39] |  7.004 ns | 0.1672 ns | 0.2174 ns |  7.044 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      | The q(...) dog. [39] |  9.798 ns | 0.1569 ns | 0.1391 ns |  9.798 ns |         - |
|                **Equals** |           **Ordinal** |                     **** |                    **y** |  **5.809 ns** | **0.1239 ns** | **0.1098 ns** |  **5.777 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                      |                    y |  3.628 ns | 0.0562 ns | 0.0498 ns |  3.616 ns |         - |
|         TrimEqualityA |           Ordinal |                      |                    y |  8.798 ns | 0.1039 ns | 0.0921 ns |  8.810 ns |         - |
|        TrimEqualityAB |           Ordinal |                      |                    y | 13.588 ns | 0.2563 ns | 0.2272 ns | 13.579 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                      |                    y |  6.950 ns | 0.1627 ns | 0.1741 ns |  6.940 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                      |                    y | 10.647 ns | 0.1688 ns | 0.1409 ns | 10.647 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                     **** |  **5.715 ns** | **0.0771 ns** | **0.0684 ns** |  **5.701 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                      |  3.441 ns | 0.0524 ns | 0.0491 ns |  3.421 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                      | 13.494 ns | 0.2096 ns | 0.1750 ns | 13.445 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                      | 17.173 ns | 0.2107 ns | 0.1867 ns | 17.168 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                      | 11.623 ns | 0.1456 ns | 0.1362 ns | 11.591 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                      | 13.070 ns | 0.2090 ns | 0.1955 ns | 13.018 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                 ** N  ** |  **8.561 ns** | **0.1170 ns** | **0.1094 ns** |  **8.542 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                  N   | 11.747 ns | 0.1258 ns | 0.1177 ns | 11.757 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                  N   | 13.478 ns | 0.1546 ns | 0.1446 ns | 13.408 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                  N   | 23.796 ns | 0.2572 ns | 0.2406 ns | 23.834 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                  N   | 11.657 ns | 0.1240 ns | 0.1160 ns | 11.690 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                  N   | 25.926 ns | 0.2091 ns | 0.1746 ns | 25.947 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** | ** The (...)dog.  [41]** |  **5.741 ns** | **0.0641 ns** | **0.0599 ns** |  **5.728 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |  The (...)dog.  [41] |  3.398 ns | 0.0507 ns | 0.0449 ns |  3.393 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |  The (...)dog.  [41] | 13.572 ns | 0.2852 ns | 0.2668 ns | 13.537 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |  The (...)dog.  [41] | 22.747 ns | 0.4609 ns | 0.5993 ns | 22.738 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |  The (...)dog.  [41] | 11.707 ns | 0.1846 ns | 0.1727 ns | 11.740 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |  The (...)dog.  [41] | 17.663 ns | 0.2139 ns | 0.2001 ns | 17.660 ns |         - |
|                Equals |           Ordinal |                  n   |  The (...)dog.  [41] |  5.799 ns | 0.0729 ns | 0.0682 ns |  5.805 ns |         - |
|         EqualsWithLen |           Ordinal |                  n   |  The (...)dog.  [41] |  3.433 ns | 0.0636 ns | 0.0563 ns |  3.423 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |  The (...)dog.  [41] | 13.504 ns | 0.1733 ns | 0.1536 ns | 13.460 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |  The (...)dog.  [41] | 21.501 ns | 0.1594 ns | 0.1413 ns | 21.480 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |  The (...)dog.  [41] | 11.581 ns | 0.0805 ns | 0.0753 ns | 11.599 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |  The (...)dog.  [41] | 17.732 ns | 0.2007 ns | 0.1877 ns | 17.696 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                 ** Y  ** |  **8.150 ns** | **0.0741 ns** | **0.0657 ns** |  **8.155 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                  Y   | 11.729 ns | 0.1235 ns | 0.1155 ns | 11.726 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                  Y   | 13.539 ns | 0.2315 ns | 0.2166 ns | 13.462 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                  Y   | 23.785 ns | 0.2812 ns | 0.2630 ns | 23.737 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                  Y   | 11.563 ns | 0.1230 ns | 0.1090 ns | 11.544 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                  Y   | 25.407 ns | 0.2713 ns | 0.2538 ns | 25.424 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                ** Yx  ** |  **5.698 ns** | **0.0434 ns** | **0.0363 ns** |  **5.704 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                 Yx   |  3.422 ns | 0.0590 ns | 0.0492 ns |  3.423 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                 Yx   | 13.439 ns | 0.1181 ns | 0.0986 ns | 13.398 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                 Yx   | 24.306 ns | 0.2137 ns | 0.1999 ns | 24.352 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                 Yx   | 12.244 ns | 0.2772 ns | 0.3604 ns | 12.215 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                 Yx   | 21.010 ns | 0.4576 ns | 0.6708 ns | 20.972 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                 ** n  ** |  **8.634 ns** | **0.2257 ns** | **0.6655 ns** |  **8.395 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                  n   | 11.182 ns | 0.2611 ns | 0.3745 ns | 11.151 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                  n   | 14.322 ns | 0.2083 ns | 0.1739 ns | 14.286 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                  n   | 25.415 ns | 0.5440 ns | 0.6681 ns | 25.436 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                  n   | 15.110 ns | 0.2747 ns | 0.2435 ns | 15.063 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                  n   | 25.304 ns | 0.5132 ns | 0.4800 ns | 25.197 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                 ** y  ** |  **8.874 ns** | **0.2112 ns** | **0.2960 ns** |  **8.824 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                  y   | 12.209 ns | 0.2782 ns | 0.2733 ns | 12.202 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                  y   | 14.904 ns | 0.2998 ns | 0.2805 ns | 14.810 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                  y   | 24.130 ns | 0.4466 ns | 0.3959 ns | 24.110 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                  y   | 11.956 ns | 0.1625 ns | 0.1357 ns | 11.942 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                  y   | 24.719 ns | 0.4735 ns | 0.4429 ns | 24.676 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                ** yx  ** |  **5.780 ns** | **0.1271 ns** | **0.1127 ns** |  **5.774 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                 yx   |  3.466 ns | 0.0854 ns | 0.0799 ns |  3.453 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                 yx   | 13.487 ns | 0.1644 ns | 0.1457 ns | 13.450 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                 yx   | 23.651 ns | 0.2029 ns | 0.1898 ns | 23.569 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                 yx   | 11.682 ns | 0.1859 ns | 0.1739 ns | 11.646 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                 yx   | 19.153 ns | 0.2430 ns | 0.2273 ns | 19.079 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |          **Hello World** |  **5.929 ns** | **0.1243 ns** | **0.1102 ns** |  **5.902 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |          Hello World |  3.520 ns | 0.0813 ns | 0.0721 ns |  3.527 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |          Hello World | 13.683 ns | 0.2842 ns | 0.2659 ns | 13.574 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |          Hello World | 19.068 ns | 0.1851 ns | 0.1546 ns | 19.103 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |          Hello World | 11.587 ns | 0.1162 ns | 0.1087 ns | 11.573 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |          Hello World | 14.619 ns | 0.1659 ns | 0.1470 ns | 14.601 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |         **Hello World ** |  **5.856 ns** | **0.1469 ns** | **0.1442 ns** |  **5.833 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |         Hello World  |  3.335 ns | 0.0934 ns | 0.0828 ns |  3.359 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |         Hello World  | 14.848 ns | 0.2659 ns | 0.2487 ns | 14.747 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |         Hello World  | 20.108 ns | 0.2269 ns | 0.2122 ns | 20.029 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |         Hello World  | 13.038 ns | 0.0824 ns | 0.0770 ns | 13.032 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |         Hello World  | 17.306 ns | 0.2184 ns | 0.2043 ns | 17.239 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |          **Hello world** |  **5.731 ns** | **0.1030 ns** | **0.0964 ns** |  **5.711 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |          Hello world |  3.407 ns | 0.0399 ns | 0.0373 ns |  3.410 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |          Hello world | 13.584 ns | 0.2241 ns | 0.2097 ns | 13.527 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |          Hello world | 19.026 ns | 0.2882 ns | 0.2555 ns | 19.052 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |          Hello world | 12.179 ns | 0.2691 ns | 0.2991 ns | 12.179 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |          Hello world | 15.294 ns | 0.3421 ns | 0.3200 ns | 15.336 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |         **Hello world ** |  **5.931 ns** | **0.1317 ns** | **0.1232 ns** |  **5.930 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |         Hello world  |  3.584 ns | 0.1066 ns | 0.1529 ns |  3.557 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |         Hello world  | 15.291 ns | 0.2160 ns | 0.2021 ns | 15.264 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |         Hello world  | 23.051 ns | 0.3335 ns | 0.2785 ns | 23.075 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |         Hello world  | 11.672 ns | 0.1672 ns | 0.1397 ns | 11.660 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |         Hello world  | 15.949 ns | 0.1391 ns | 0.1161 ns | 15.930 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** | **The q(...) dog. [39]** |  **5.792 ns** | **0.1001 ns** | **0.0887 ns** |  **5.821 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   | The q(...) dog. [39] |  4.252 ns | 0.0770 ns | 0.0720 ns |  4.260 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   | The q(...) dog. [39] | 13.492 ns | 0.1592 ns | 0.1489 ns | 13.451 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   | The q(...) dog. [39] | 19.034 ns | 0.1902 ns | 0.1686 ns | 19.067 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   | The q(...) dog. [39] | 11.579 ns | 0.1051 ns | 0.0983 ns | 11.616 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   | The q(...) dog. [39] | 14.569 ns | 0.1601 ns | 0.1337 ns | 14.540 ns |         - |
|                Equals |           Ordinal |                  n   | The q(...) dog. [39] |  5.815 ns | 0.0813 ns | 0.0760 ns |  5.818 ns |         - |
|         EqualsWithLen |           Ordinal |                  n   | The q(...) dog. [39] |  3.561 ns | 0.1040 ns | 0.1021 ns |  3.553 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   | The q(...) dog. [39] | 15.756 ns | 0.3346 ns | 0.3580 ns | 15.675 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   | The q(...) dog. [39] | 20.803 ns | 0.4062 ns | 0.3392 ns | 20.755 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   | The q(...) dog. [39] | 11.741 ns | 0.1430 ns | 0.1267 ns | 11.728 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   | The q(...) dog. [39] | 14.860 ns | 0.3178 ns | 0.2972 ns | 14.802 ns |         - |
|                **Equals** |           **Ordinal** |                 ** n  ** |                    **y** |  **5.890 ns** | **0.1216 ns** | **0.1078 ns** |  **5.875 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  n   |                    y |  3.250 ns | 0.0819 ns | 0.0684 ns |  3.234 ns |         - |
|         TrimEqualityA |           Ordinal |                  n   |                    y | 15.593 ns | 0.2468 ns | 0.2309 ns | 15.576 ns |         - |
|        TrimEqualityAB |           Ordinal |                  n   |                    y | 20.083 ns | 0.3211 ns | 0.2847 ns | 20.010 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  n   |                    y | 12.118 ns | 0.1292 ns | 0.1209 ns | 12.100 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  n   |                    y | 22.116 ns | 0.2666 ns | 0.2494 ns | 22.130 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                     **** |  **5.731 ns** | **0.0736 ns** | **0.0653 ns** |  **5.745 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                      |  3.416 ns | 0.0559 ns | 0.0523 ns |  3.404 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                      | 13.551 ns | 0.2562 ns | 0.2397 ns | 13.444 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                      | 17.212 ns | 0.2390 ns | 0.2236 ns | 17.181 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                      | 11.584 ns | 0.1290 ns | 0.1207 ns | 11.545 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                      | 13.516 ns | 0.2699 ns | 0.2525 ns | 13.508 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                 ** N  ** |  **8.883 ns** | **0.2135 ns** | **0.2622 ns** |  **8.825 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                  N   | 12.249 ns | 0.1388 ns | 0.1298 ns | 12.255 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                  N   | 13.596 ns | 0.2511 ns | 0.2349 ns | 13.541 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                  N   | 24.072 ns | 0.3277 ns | 0.3066 ns | 24.157 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                  N   | 13.219 ns | 0.7116 ns | 2.0982 ns | 11.755 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                  N   | 24.561 ns | 0.3272 ns | 0.2901 ns | 24.512 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** | ** The (...)dog.  [41]** |  **5.869 ns** | **0.1397 ns** | **0.1238 ns** |  **5.876 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |  The (...)dog.  [41] |  3.575 ns | 0.0993 ns | 0.0880 ns |  3.602 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |  The (...)dog.  [41] | 13.914 ns | 0.2218 ns | 0.1966 ns | 13.827 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |  The (...)dog.  [41] | 21.965 ns | 0.4446 ns | 0.3942 ns | 21.950 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |  The (...)dog.  [41] | 11.682 ns | 0.1335 ns | 0.1249 ns | 11.708 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |  The (...)dog.  [41] | 17.711 ns | 0.2125 ns | 0.1775 ns | 17.710 ns |         - |
|                Equals |           Ordinal |                  y   |  The (...)dog.  [41] |  5.843 ns | 0.1466 ns | 0.1569 ns |  5.826 ns |         - |
|         EqualsWithLen |           Ordinal |                  y   |  The (...)dog.  [41] |  3.434 ns | 0.0604 ns | 0.0535 ns |  3.450 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |  The (...)dog.  [41] | 14.713 ns | 0.2799 ns | 0.2481 ns | 14.628 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |  The (...)dog.  [41] | 21.661 ns | 0.2655 ns | 0.2483 ns | 21.576 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |  The (...)dog.  [41] | 11.627 ns | 0.1066 ns | 0.0997 ns | 11.615 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |  The (...)dog.  [41] | 17.751 ns | 0.2323 ns | 0.2173 ns | 17.653 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                 ** Y  ** |  **8.711 ns** | **0.1763 ns** | **0.2030 ns** |  **8.694 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                  Y   | 11.734 ns | 0.1002 ns | 0.0937 ns | 11.744 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                  Y   | 13.616 ns | 0.2804 ns | 0.2486 ns | 13.520 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                  Y   | 23.760 ns | 0.2322 ns | 0.2058 ns | 23.686 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                  Y   | 11.597 ns | 0.1374 ns | 0.1285 ns | 11.556 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                  Y   | 24.389 ns | 0.2205 ns | 0.1955 ns | 24.382 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                ** Yx  ** |  **5.720 ns** | **0.0572 ns** | **0.0478 ns** |  **5.720 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                 Yx   |  3.518 ns | 0.0968 ns | 0.0906 ns |  3.547 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                 Yx   | 14.189 ns | 0.2849 ns | 0.2665 ns | 14.212 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                 Yx   | 26.163 ns | 0.5603 ns | 0.9959 ns | 26.228 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                 Yx   | 13.743 ns | 0.3145 ns | 0.3089 ns | 13.805 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                 Yx   | 22.274 ns | 0.4817 ns | 1.0473 ns | 22.019 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                 ** n  ** |  **9.827 ns** | **0.2176 ns** | **0.4245 ns** |  **9.738 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                  n   | 13.143 ns | 0.2887 ns | 0.3089 ns | 13.183 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                  n   | 16.024 ns | 0.3580 ns | 0.3831 ns | 16.047 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                  n   | 26.493 ns | 0.5177 ns | 0.4590 ns | 26.560 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                  n   | 12.692 ns | 0.2904 ns | 0.4165 ns | 12.625 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                  n   | 26.448 ns | 0.5306 ns | 0.4431 ns | 26.554 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                 ** y  ** |  **8.256 ns** | **0.1913 ns** | **0.2127 ns** |  **8.268 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                  y   | 11.233 ns | 0.2613 ns | 0.4293 ns | 11.167 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                  y   | 15.527 ns | 0.1914 ns | 0.1696 ns | 15.510 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                  y   | 25.083 ns | 0.5388 ns | 0.5533 ns | 25.092 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                  y   | 12.050 ns | 0.1910 ns | 0.1787 ns | 12.139 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                  y   | 25.202 ns | 0.4242 ns | 0.3761 ns | 25.328 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                ** yx  ** |  **6.028 ns** | **0.1454 ns** | **0.1360 ns** |  **6.018 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                 yx   |  3.342 ns | 0.0906 ns | 0.0804 ns |  3.347 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                 yx   | 13.814 ns | 0.2383 ns | 0.2229 ns | 13.793 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                 yx   | 24.142 ns | 0.3619 ns | 0.3386 ns | 24.166 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                 yx   | 13.191 ns | 0.2140 ns | 0.1671 ns | 13.251 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                 yx   | 19.993 ns | 0.1684 ns | 0.1315 ns | 20.029 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |          **Hello World** |  **5.754 ns** | **0.0592 ns** | **0.0494 ns** |  **5.756 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |          Hello World |  3.428 ns | 0.0698 ns | 0.0583 ns |  3.425 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |          Hello World | 14.065 ns | 0.2859 ns | 0.2534 ns | 13.998 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |          Hello World | 20.746 ns | 0.4357 ns | 0.3862 ns | 20.760 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |          Hello World | 11.728 ns | 0.2128 ns | 0.1887 ns | 11.668 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |          Hello World | 14.856 ns | 0.3153 ns | 0.3374 ns | 14.903 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |         **Hello World ** |  **5.785 ns** | **0.0641 ns** | **0.0599 ns** |  **5.775 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |         Hello World  |  4.356 ns | 0.0586 ns | 0.0548 ns |  4.338 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |         Hello World  | 17.267 ns | 0.1615 ns | 0.1510 ns | 17.167 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |         Hello World  | 20.086 ns | 0.0993 ns | 0.0929 ns | 20.089 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |         Hello World  | 11.746 ns | 0.1115 ns | 0.1043 ns | 11.737 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |         Hello World  | 15.986 ns | 0.2856 ns | 0.2532 ns | 15.900 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |          **Hello world** |  **5.709 ns** | **0.0862 ns** | **0.0764 ns** |  **5.715 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |          Hello world |  3.428 ns | 0.0662 ns | 0.0619 ns |  3.432 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |          Hello world | 15.467 ns | 0.2026 ns | 0.1796 ns | 15.546 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |          Hello world | 20.850 ns | 0.4461 ns | 0.8701 ns | 20.676 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |          Hello world | 13.313 ns | 0.2750 ns | 0.2572 ns | 13.303 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |          Hello world | 19.269 ns | 0.4175 ns | 0.4101 ns | 19.327 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |         **Hello world ** |  **6.518 ns** | **0.1580 ns** | **0.1998 ns** |  **6.501 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |         Hello world  |  3.794 ns | 0.0929 ns | 0.1272 ns |  3.819 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |         Hello world  | 15.178 ns | 0.2689 ns | 0.2515 ns | 15.089 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |         Hello world  | 21.969 ns | 0.4491 ns | 0.7252 ns | 21.885 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |         Hello world  | 12.668 ns | 0.2861 ns | 0.4194 ns | 12.693 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |         Hello world  | 17.016 ns | 0.3736 ns | 0.4588 ns | 16.986 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** | **The q(...) dog. [39]** |  **6.266 ns** | **0.1529 ns** | **0.1570 ns** |  **6.246 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   | The q(...) dog. [39] |  3.706 ns | 0.1109 ns | 0.1402 ns |  3.703 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   | The q(...) dog. [39] | 14.376 ns | 0.2223 ns | 0.2080 ns | 14.351 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   | The q(...) dog. [39] | 22.901 ns | 0.4407 ns | 0.6032 ns | 22.747 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   | The q(...) dog. [39] | 12.120 ns | 0.2502 ns | 0.2340 ns | 12.036 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   | The q(...) dog. [39] | 15.235 ns | 0.2919 ns | 0.2731 ns | 15.158 ns |         - |
|                Equals |           Ordinal |                  y   | The q(...) dog. [39] |  5.928 ns | 0.1306 ns | 0.1221 ns |  5.987 ns |         - |
|         EqualsWithLen |           Ordinal |                  y   | The q(...) dog. [39] |  3.536 ns | 0.1064 ns | 0.0888 ns |  3.530 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   | The q(...) dog. [39] | 15.761 ns | 0.3486 ns | 0.4150 ns | 15.730 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   | The q(...) dog. [39] | 19.427 ns | 0.4102 ns | 0.3636 ns | 19.373 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   | The q(...) dog. [39] | 11.720 ns | 0.1781 ns | 0.1666 ns | 11.677 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   | The q(...) dog. [39] | 14.763 ns | 0.3256 ns | 0.3046 ns | 14.616 ns |         - |
|                **Equals** |           **Ordinal** |                 ** y  ** |                    **y** |  **5.727 ns** | **0.1079 ns** | **0.0956 ns** |  **5.734 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                  y   |                    y |  5.030 ns | 0.0510 ns | 0.0477 ns |  5.043 ns |         - |
|         TrimEqualityA |           Ordinal |                  y   |                    y | 15.509 ns | 0.1844 ns | 0.1725 ns | 15.470 ns |         - |
|        TrimEqualityAB |           Ordinal |                  y   |                    y | 22.131 ns | 0.4190 ns | 0.3920 ns | 22.067 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                  y   |                    y | 12.595 ns | 0.1953 ns | 0.1827 ns | 12.595 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                  y   |                    y | 20.577 ns | 0.3930 ns | 0.3484 ns | 20.527 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                     **** |  **5.725 ns** | **0.1429 ns** | **0.1337 ns** |  **5.645 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                      |  3.398 ns | 0.0394 ns | 0.0307 ns |  3.401 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                      | 14.703 ns | 0.1471 ns | 0.1376 ns | 14.706 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                      | 18.358 ns | 0.2742 ns | 0.2565 ns | 18.313 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                      | 18.251 ns | 0.3747 ns | 0.4165 ns | 18.171 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                      | 14.390 ns | 0.3168 ns | 0.3254 ns | 14.340 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                 ** N  ** |  **5.877 ns** | **0.1474 ns** | **0.1447 ns** |  **5.841 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                  N   |  3.900 ns | 0.1113 ns | 0.0987 ns |  3.885 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                  N   | 14.898 ns | 0.2812 ns | 0.3009 ns | 14.813 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                  N   | 23.501 ns | 0.3951 ns | 0.3695 ns | 23.368 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                  N   | 12.728 ns | 0.1333 ns | 0.1182 ns | 12.694 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                  N   | 21.047 ns | 0.2999 ns | 0.2806 ns | 20.981 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** | ** The (...)dog.  [41]** |  **5.730 ns** | **0.1181 ns** | **0.1105 ns** |  **5.671 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |  The (...)dog.  [41] |  3.419 ns | 0.0831 ns | 0.0649 ns |  3.390 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |  The (...)dog.  [41] | 14.902 ns | 0.2916 ns | 0.2728 ns | 14.772 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |  The (...)dog.  [41] | 22.759 ns | 0.1238 ns | 0.1097 ns | 22.735 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |  The (...)dog.  [41] | 13.424 ns | 0.2703 ns | 0.2397 ns | 13.522 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |  The (...)dog.  [41] | 20.576 ns | 0.4276 ns | 0.4391 ns | 20.602 ns |         - |
|                Equals |           Ordinal |                 yx   |  The (...)dog.  [41] |  6.651 ns | 0.1639 ns | 0.1683 ns |  6.614 ns |         - |
|         EqualsWithLen |           Ordinal |                 yx   |  The (...)dog.  [41] |  3.688 ns | 0.1104 ns | 0.1133 ns |  3.705 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |  The (...)dog.  [41] | 15.412 ns | 0.3255 ns | 0.3045 ns | 15.512 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |  The (...)dog.  [41] | 23.921 ns | 0.4395 ns | 0.5232 ns | 23.872 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |  The (...)dog.  [41] | 13.108 ns | 0.2330 ns | 0.2065 ns | 13.188 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |  The (...)dog.  [41] | 19.375 ns | 0.3502 ns | 0.3105 ns | 19.398 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                 ** Y  ** |  **6.006 ns** | **0.1488 ns** | **0.1528 ns** |  **5.950 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                  Y   |  3.970 ns | 0.1043 ns | 0.0924 ns |  3.949 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                  Y   | 15.092 ns | 0.2302 ns | 0.2153 ns | 15.092 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                  Y   | 23.624 ns | 0.4978 ns | 0.5112 ns | 23.607 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                  Y   | 12.841 ns | 0.2146 ns | 0.2007 ns | 12.752 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                  Y   | 19.321 ns | 0.2049 ns | 0.1817 ns | 19.271 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                ** Yx  ** |  **8.687 ns** | **0.1567 ns** | **0.1466 ns** |  **8.631 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                 Yx   | 11.709 ns | 0.0895 ns | 0.0837 ns | 11.715 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                 Yx   | 14.779 ns | 0.1980 ns | 0.1852 ns | 14.747 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                 Yx   | 26.226 ns | 0.1630 ns | 0.1445 ns | 26.191 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                 Yx   | 16.762 ns | 0.1805 ns | 0.1689 ns | 16.688 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                 Yx   | 26.448 ns | 0.2138 ns | 0.1895 ns | 26.431 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                 ** n  ** |  **5.816 ns** | **0.0980 ns** | **0.0917 ns** |  **5.788 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                  n   |  3.417 ns | 0.0474 ns | 0.0443 ns |  3.418 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                  n   | 15.177 ns | 0.2600 ns | 0.2432 ns | 15.095 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                  n   | 25.846 ns | 0.4265 ns | 0.3781 ns | 25.780 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                  n   | 13.276 ns | 0.2467 ns | 0.2307 ns | 13.253 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                  n   | 19.705 ns | 0.4069 ns | 0.3807 ns | 19.620 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                 ** y  ** |  **5.985 ns** | **0.1428 ns** | **0.1336 ns** |  **5.956 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                  y   |  3.531 ns | 0.0935 ns | 0.1510 ns |  3.478 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                  y   | 15.039 ns | 0.2574 ns | 0.2408 ns | 15.102 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                  y   | 23.542 ns | 0.4455 ns | 0.4167 ns | 23.481 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                  y   | 13.557 ns | 0.2214 ns | 0.2071 ns | 13.479 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                  y   | 19.486 ns | 0.3431 ns | 0.3209 ns | 19.329 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                ** yx  ** |  **7.782 ns** | **0.1006 ns** | **0.0941 ns** |  **7.780 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                 yx   | 10.524 ns | 0.0980 ns | 0.0819 ns | 10.551 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                 yx   | 14.806 ns | 0.2548 ns | 0.2384 ns | 14.802 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                 yx   | 26.778 ns | 0.4489 ns | 0.4199 ns | 26.711 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                 yx   | 12.999 ns | 0.2565 ns | 0.2400 ns | 12.901 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                 yx   | 26.430 ns | 0.1859 ns | 0.1648 ns | 26.459 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |          **Hello World** |  **5.795 ns** | **0.1210 ns** | **0.1131 ns** |  **5.777 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |          Hello World |  3.441 ns | 0.0850 ns | 0.0795 ns |  3.424 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |          Hello World | 14.755 ns | 0.2898 ns | 0.2710 ns | 14.640 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |          Hello World | 20.162 ns | 0.1771 ns | 0.1570 ns | 20.120 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |          Hello World | 12.762 ns | 0.1816 ns | 0.1698 ns | 12.671 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |          Hello World | 15.847 ns | 0.3208 ns | 0.3001 ns | 15.932 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |         **Hello World ** |  **5.708 ns** | **0.0873 ns** | **0.0729 ns** |  **5.702 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |         Hello World  |  3.405 ns | 0.0405 ns | 0.0379 ns |  3.393 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |         Hello World  | 14.942 ns | 0.3082 ns | 0.2883 ns | 14.916 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |         Hello World  | 23.456 ns | 0.2409 ns | 0.2254 ns | 23.412 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |         Hello World  | 12.813 ns | 0.1272 ns | 0.1190 ns | 12.777 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |         Hello World  | 16.927 ns | 0.2738 ns | 0.2428 ns | 16.834 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |          **Hello world** |  **5.800 ns** | **0.1109 ns** | **0.0983 ns** |  **5.773 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |          Hello world |  3.812 ns | 0.1098 ns | 0.1865 ns |  3.801 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |          Hello world | 16.527 ns | 0.2859 ns | 0.2535 ns | 16.504 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |          Hello world | 28.848 ns | 2.0260 ns | 5.9736 ns | 24.901 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |          Hello world | 14.726 ns | 0.3147 ns | 0.3367 ns | 14.772 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |          Hello world | 18.009 ns | 0.3916 ns | 0.4353 ns | 17.936 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |         **Hello world ** |  **6.488 ns** | **0.1654 ns** | **0.1969 ns** |  **6.504 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |         Hello world  |  3.697 ns | 0.1071 ns | 0.1146 ns |  3.701 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |         Hello world  | 18.496 ns | 0.3853 ns | 0.5274 ns | 18.427 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |         Hello world  | 23.435 ns | 0.4850 ns | 0.5773 ns | 23.320 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |         Hello world  | 14.081 ns | 0.3153 ns | 0.2949 ns | 14.017 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |         Hello world  | 18.313 ns | 0.3922 ns | 0.5100 ns | 18.326 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** | **The q(...) dog. [39]** |  **6.334 ns** | **0.1594 ns** | **0.1491 ns** |  **6.309 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   | The q(...) dog. [39] |  3.751 ns | 0.1120 ns | 0.1711 ns |  3.751 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   | The q(...) dog. [39] | 17.698 ns | 0.3818 ns | 0.5097 ns | 17.593 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   | The q(...) dog. [39] | 21.269 ns | 0.4261 ns | 0.6759 ns | 21.146 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   | The q(...) dog. [39] | 13.315 ns | 0.2531 ns | 0.2243 ns | 13.251 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   | The q(...) dog. [39] | 16.248 ns | 0.3180 ns | 0.2975 ns | 16.226 ns |         - |
|                Equals |           Ordinal |                 yx   | The q(...) dog. [39] |  6.028 ns | 0.1514 ns | 0.1487 ns |  6.063 ns |         - |
|         EqualsWithLen |           Ordinal |                 yx   | The q(...) dog. [39] |  3.620 ns | 0.0934 ns | 0.1146 ns |  3.621 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   | The q(...) dog. [39] | 15.253 ns | 0.2358 ns | 0.2206 ns | 15.310 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   | The q(...) dog. [39] | 20.587 ns | 0.4264 ns | 0.5076 ns | 20.645 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   | The q(...) dog. [39] | 13.010 ns | 0.1268 ns | 0.1186 ns | 13.003 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   | The q(...) dog. [39] | 15.614 ns | 0.2625 ns | 0.2455 ns | 15.528 ns |         - |
|                **Equals** |           **Ordinal** |                ** yx  ** |                    **y** |  **5.822 ns** | **0.1400 ns** | **0.1375 ns** |  **5.836 ns** |         **-** |
|         EqualsWithLen |           Ordinal |                 yx   |                    y |  3.460 ns | 0.0911 ns | 0.0852 ns |  3.478 ns |         - |
|         TrimEqualityA |           Ordinal |                 yx   |                    y | 14.649 ns | 0.1272 ns | 0.1128 ns | 14.633 ns |         - |
|        TrimEqualityAB |           Ordinal |                 yx   |                    y | 19.387 ns | 0.2088 ns | 0.1851 ns | 19.382 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |                 yx   |                    y | 13.517 ns | 0.2437 ns | 0.2279 ns | 13.442 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |                 yx   |                    y | 14.793 ns | 0.2713 ns | 0.2537 ns | 14.687 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                     **** |  **5.956 ns** | **0.1139 ns** | **0.1065 ns** |  **5.961 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                      |  3.453 ns | 0.0877 ns | 0.1044 ns |  3.436 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                      | 10.994 ns | 0.1526 ns | 0.1427 ns | 11.028 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                      | 16.260 ns | 0.2995 ns | 0.2802 ns | 16.219 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                      |  8.418 ns | 0.1056 ns | 0.0936 ns |  8.401 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                      | 10.368 ns | 0.2415 ns | 0.4101 ns | 10.397 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                 ** N  ** |  **5.958 ns** | **0.1339 ns** | **0.1118 ns** |  **5.944 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                  N   |  3.495 ns | 0.1026 ns | 0.1439 ns |  3.448 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                  N   | 10.488 ns | 0.2181 ns | 0.2040 ns | 10.501 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                  N   | 19.404 ns | 0.3486 ns | 0.3730 ns | 19.277 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                  N   |  8.343 ns | 0.0840 ns | 0.0701 ns |  8.340 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                  N   | 15.155 ns | 0.2490 ns | 0.2329 ns | 15.158 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** | ** The (...)dog.  [41]** |  **5.829 ns** | **0.1169 ns** | **0.1094 ns** |  **5.788 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |  The (...)dog.  [41] |  3.416 ns | 0.0504 ns | 0.0472 ns |  3.423 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |  The (...)dog.  [41] | 10.455 ns | 0.1659 ns | 0.1552 ns | 10.443 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |  The (...)dog.  [41] | 18.966 ns | 0.3998 ns | 0.5337 ns | 18.811 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |  The (...)dog.  [41] |  9.262 ns | 0.2011 ns | 0.2948 ns |  9.212 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |  The (...)dog.  [41] | 16.651 ns | 0.2794 ns | 0.2614 ns | 16.688 ns |         - |
|                Equals |           Ordinal |          Hello World |  The (...)dog.  [41] |  7.002 ns | 0.1700 ns | 0.2696 ns |  7.007 ns |         - |
|         EqualsWithLen |           Ordinal |          Hello World |  The (...)dog.  [41] |  4.002 ns | 0.1197 ns | 0.1281 ns |  4.027 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |  The (...)dog.  [41] | 11.779 ns | 0.2665 ns | 0.2493 ns | 11.807 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |  The (...)dog.  [41] | 20.640 ns | 0.4437 ns | 0.4932 ns | 20.659 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |  The (...)dog.  [41] |  9.317 ns | 0.2191 ns | 0.2691 ns |  9.331 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |  The (...)dog.  [41] | 15.697 ns | 0.3508 ns | 0.4436 ns | 15.754 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                 ** Y  ** |  **6.274 ns** | **0.1328 ns** | **0.1242 ns** |  **6.211 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                  Y   |  3.852 ns | 0.1080 ns | 0.0958 ns |  3.872 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                  Y   | 11.316 ns | 0.2591 ns | 0.4110 ns | 11.211 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                  Y   | 20.154 ns | 0.4173 ns | 0.7736 ns | 19.994 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                  Y   |  8.947 ns | 0.2141 ns | 0.4788 ns |  8.808 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                  Y   | 15.126 ns | 0.3203 ns | 0.4165 ns | 14.998 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                ** Yx  ** |  **6.023 ns** | **0.1331 ns** | **0.1180 ns** |  **6.004 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                 Yx   |  3.573 ns | 0.1019 ns | 0.1173 ns |  3.562 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                 Yx   | 10.580 ns | 0.2209 ns | 0.1958 ns | 10.626 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                 Yx   | 20.453 ns | 0.4261 ns | 0.5541 ns | 20.401 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                 Yx   |  8.448 ns | 0.1876 ns | 0.1754 ns |  8.470 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                 Yx   | 16.852 ns | 0.3624 ns | 0.3559 ns | 16.775 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                 ** n  ** |  **5.801 ns** | **0.0828 ns** | **0.0734 ns** |  **5.798 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                  n   |  3.409 ns | 0.0613 ns | 0.0573 ns |  3.395 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                  n   | 10.787 ns | 0.1886 ns | 0.1764 ns | 10.816 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                  n   | 20.343 ns | 0.4115 ns | 0.7525 ns | 20.450 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                  n   |  9.635 ns | 0.2264 ns | 0.2224 ns |  9.605 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                  n   | 17.209 ns | 0.3784 ns | 0.4786 ns | 17.235 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                 ** y  ** |  **6.626 ns** | **0.1560 ns** | **0.1460 ns** |  **6.605 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                  y   |  3.830 ns | 0.1131 ns | 0.1257 ns |  3.856 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                  y   | 11.565 ns | 0.1601 ns | 0.1337 ns | 11.569 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                  y   | 20.482 ns | 0.4449 ns | 0.7433 ns | 20.379 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                  y   |  9.179 ns | 0.2215 ns | 0.3700 ns |  9.131 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                  y   | 16.410 ns | 0.2582 ns | 0.2415 ns | 16.378 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                ** yx  ** |  **6.232 ns** | **0.1578 ns** | **0.1996 ns** |  **6.167 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                 yx   |  4.299 ns | 0.1225 ns | 0.1907 ns |  4.242 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                 yx   | 11.028 ns | 0.2373 ns | 0.3085 ns | 10.962 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                 yx   | 20.547 ns | 0.4367 ns | 0.5198 ns | 20.590 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                 yx   |  8.708 ns | 0.2086 ns | 0.3484 ns |  8.649 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                 yx   | 16.591 ns | 0.3378 ns | 0.2994 ns | 16.574 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |          **Hello World** |  **7.863 ns** | **0.1874 ns** | **0.1753 ns** |  **7.761 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |          Hello World | 10.667 ns | 0.1812 ns | 0.1695 ns | 10.611 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |          Hello World | 12.398 ns | 0.1788 ns | 0.1672 ns | 12.346 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |          Hello World | 17.973 ns | 0.3463 ns | 0.3070 ns | 17.893 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |          Hello World | 14.678 ns | 0.2936 ns | 0.2747 ns | 14.686 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |          Hello World | 17.894 ns | 0.2511 ns | 0.2349 ns | 17.828 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |         **Hello World ** |  **6.001 ns** | **0.1532 ns** | **0.1824 ns** |  **5.990 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |         Hello World  |  3.404 ns | 0.1021 ns | 0.1002 ns |  3.381 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |         Hello World  | 10.397 ns | 0.1614 ns | 0.1510 ns | 10.374 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |         Hello World  | 20.449 ns | 0.2156 ns | 0.1911 ns | 20.435 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |         Hello World  |  8.373 ns | 0.1542 ns | 0.1442 ns |  8.340 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |         Hello World  | 21.412 ns | 0.4632 ns | 0.5334 ns | 21.471 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |          **Hello world** | **11.240 ns** | **0.2638 ns** | **0.7612 ns** | **11.279 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |          Hello world | 13.571 ns | 0.3117 ns | 0.3465 ns | 13.444 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |          Hello world | 15.604 ns | 0.3265 ns | 0.3054 ns | 15.555 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |          Hello world | 21.955 ns | 0.4130 ns | 0.5370 ns | 22.009 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |          Hello world | 18.817 ns | 0.4132 ns | 0.8626 ns | 18.698 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |          Hello world | 21.142 ns | 0.4023 ns | 0.5770 ns | 21.283 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |         **Hello world ** |  **6.511 ns** | **0.1376 ns** | **0.1220 ns** |  **6.525 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |         Hello world  |  4.636 ns | 0.1257 ns | 0.1114 ns |  4.639 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |         Hello world  | 13.064 ns | 0.2918 ns | 0.4277 ns | 13.052 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |         Hello world  | 22.514 ns | 0.4810 ns | 0.4724 ns | 22.509 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |         Hello world  |  9.105 ns | 0.2171 ns | 0.4855 ns |  9.006 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |         Hello world  | 20.874 ns | 0.4441 ns | 0.5114 ns | 20.803 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** | **The q(...) dog. [39]** |  **6.094 ns** | **0.0946 ns** | **0.0884 ns** |  **6.120 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World | The q(...) dog. [39] |  3.645 ns | 0.0980 ns | 0.1129 ns |  3.670 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World | The q(...) dog. [39] | 10.778 ns | 0.2437 ns | 0.2806 ns | 10.793 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World | The q(...) dog. [39] | 16.575 ns | 0.3112 ns | 0.2911 ns | 16.511 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World | The q(...) dog. [39] |  8.577 ns | 0.1937 ns | 0.2306 ns |  8.571 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World | The q(...) dog. [39] | 11.870 ns | 0.1921 ns | 0.1703 ns | 11.847 ns |         - |
|                Equals |           Ordinal |          Hello World | The q(...) dog. [39] |  5.840 ns | 0.0801 ns | 0.0669 ns |  5.843 ns |         - |
|         EqualsWithLen |           Ordinal |          Hello World | The q(...) dog. [39] |  3.509 ns | 0.1005 ns | 0.0940 ns |  3.497 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World | The q(...) dog. [39] | 10.499 ns | 0.2288 ns | 0.2140 ns | 10.488 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World | The q(...) dog. [39] | 18.234 ns | 0.3170 ns | 0.2965 ns | 18.191 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World | The q(...) dog. [39] |  8.429 ns | 0.1763 ns | 0.1649 ns |  8.421 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World | The q(...) dog. [39] | 11.882 ns | 0.2254 ns | 0.1882 ns | 11.929 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello World** |                    **y** |  **5.986 ns** | **0.1543 ns** | **0.1584 ns** |  **5.932 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello World |                    y |  3.436 ns | 0.1006 ns | 0.0941 ns |  3.413 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello World |                    y | 10.908 ns | 0.1510 ns | 0.1413 ns | 10.885 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello World |                    y | 17.357 ns | 0.3325 ns | 0.3110 ns | 17.318 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello World |                    y |  8.654 ns | 0.2041 ns | 0.1909 ns |  8.589 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello World |                    y | 10.687 ns | 0.2349 ns | 0.2197 ns | 10.750 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                     **** |  **5.647 ns** | **0.0503 ns** | **0.0393 ns** |  **5.639 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                      |  3.409 ns | 0.0759 ns | 0.0710 ns |  3.390 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                      | 10.366 ns | 0.1293 ns | 0.1209 ns | 10.348 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                      | 14.133 ns | 0.1649 ns | 0.1543 ns | 14.101 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                      |  8.346 ns | 0.1096 ns | 0.1025 ns |  8.301 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                      |  9.815 ns | 0.1950 ns | 0.1824 ns |  9.749 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                 ** N  ** |  **6.190 ns** | **0.1582 ns** | **0.1480 ns** |  **6.194 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                  N   |  4.487 ns | 0.1257 ns | 0.1957 ns |  4.490 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                  N   | 12.193 ns | 0.2576 ns | 0.4303 ns | 12.107 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                  N   | 22.025 ns | 0.4507 ns | 0.7406 ns | 21.979 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                  N   | 10.288 ns | 0.2238 ns | 0.2988 ns | 10.321 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                  N   | 16.165 ns | 0.3582 ns | 0.3833 ns | 16.043 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** | ** The (...)dog.  [41]** |  **8.361 ns** | **0.5245 ns** | **1.5466 ns** |  **8.519 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |  The (...)dog.  [41] |  3.736 ns | 0.1047 ns | 0.1163 ns |  3.754 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |  The (...)dog.  [41] | 11.172 ns | 0.2428 ns | 0.2028 ns | 11.234 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |  The (...)dog.  [41] | 19.480 ns | 0.4246 ns | 0.8956 ns | 19.231 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |  The (...)dog.  [41] |  8.825 ns | 0.2092 ns | 0.3001 ns |  8.820 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |  The (...)dog.  [41] | 15.041 ns | 0.3166 ns | 0.3110 ns | 14.940 ns |         - |
|                Equals |           Ordinal |          Hello world |  The (...)dog.  [41] |  5.948 ns | 0.1256 ns | 0.1175 ns |  5.901 ns |         - |
|         EqualsWithLen |           Ordinal |          Hello world |  The (...)dog.  [41] |  3.568 ns | 0.1038 ns | 0.1111 ns |  3.575 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |  The (...)dog.  [41] | 10.592 ns | 0.1649 ns | 0.1377 ns | 10.581 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |  The (...)dog.  [41] | 19.930 ns | 0.3896 ns | 0.3254 ns | 20.048 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |  The (...)dog.  [41] |  8.540 ns | 0.1516 ns | 0.1862 ns |  8.529 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |  The (...)dog.  [41] | 14.534 ns | 0.2958 ns | 0.2309 ns | 14.507 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                 ** Y  ** |  **5.769 ns** | **0.1248 ns** | **0.1107 ns** |  **5.744 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                  Y   |  5.031 ns | 0.0814 ns | 0.0761 ns |  5.045 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                  Y   | 10.389 ns | 0.1349 ns | 0.1261 ns | 10.387 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                  Y   | 18.827 ns | 0.3023 ns | 0.2828 ns | 18.699 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                  Y   |  8.530 ns | 0.1880 ns | 0.1758 ns |  8.532 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                  Y   | 15.418 ns | 0.3405 ns | 0.3643 ns | 15.434 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                ** Yx  ** |  **6.216 ns** | **0.1555 ns** | **0.1663 ns** |  **6.224 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                 Yx   |  4.010 ns | 0.1108 ns | 0.1186 ns |  4.016 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                 Yx   | 12.078 ns | 0.2688 ns | 0.3495 ns | 12.035 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                 Yx   | 22.937 ns | 0.4864 ns | 0.6151 ns | 23.039 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                 Yx   | 10.085 ns | 0.2388 ns | 0.3500 ns | 10.005 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                 Yx   | 17.354 ns | 0.3769 ns | 0.5978 ns | 17.270 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                 ** n  ** |  **6.402 ns** | **0.1396 ns** | **0.1306 ns** |  **6.412 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                  n   |  3.798 ns | 0.1127 ns | 0.1543 ns |  3.781 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                  n   | 11.183 ns | 0.2490 ns | 0.2867 ns | 11.217 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                  n   | 20.671 ns | 0.4434 ns | 0.5766 ns | 20.561 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                  n   |  8.992 ns | 0.2153 ns | 0.4349 ns |  8.844 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                  n   | 15.280 ns | 0.1888 ns | 0.1766 ns | 15.289 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                 ** y  ** |  **6.018 ns** | **0.1525 ns** | **0.1497 ns** |  **5.981 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                  y   |  3.559 ns | 0.0973 ns | 0.1571 ns |  3.533 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                  y   | 10.762 ns | 0.2501 ns | 0.2456 ns | 10.684 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                  y   | 19.076 ns | 0.3960 ns | 0.4402 ns | 18.984 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                  y   |  9.540 ns | 0.1319 ns | 0.1101 ns |  9.524 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                  y   | 14.863 ns | 0.2119 ns | 0.1983 ns | 14.945 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                ** yx  ** |  **5.843 ns** | **0.1017 ns** | **0.0901 ns** |  **5.848 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                 yx   |  3.252 ns | 0.0665 ns | 0.0622 ns |  3.247 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                 yx   | 10.456 ns | 0.1598 ns | 0.1495 ns | 10.468 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                 yx   | 21.038 ns | 0.3998 ns | 0.5199 ns | 20.969 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                 yx   |  8.571 ns | 0.1878 ns | 0.1664 ns |  8.565 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                 yx   | 15.950 ns | 0.2152 ns | 0.1680 ns | 15.992 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |          **Hello World** |  **8.752 ns** | **0.1654 ns** | **0.1547 ns** |  **8.729 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |          Hello World | 11.465 ns | 0.1403 ns | 0.1243 ns | 11.424 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |          Hello World | 13.307 ns | 0.1687 ns | 0.1578 ns | 13.294 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |          Hello World | 18.613 ns | 0.2186 ns | 0.2045 ns | 18.498 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |          Hello World | 15.564 ns | 0.2473 ns | 0.2313 ns | 15.466 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |          Hello World | 18.778 ns | 0.3562 ns | 0.3157 ns | 18.734 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |         **Hello World ** |  **6.003 ns** | **0.1218 ns** | **0.1139 ns** |  **5.973 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |         Hello World  |  4.759 ns | 0.1167 ns | 0.1034 ns |  4.733 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |         Hello World  | 10.346 ns | 0.1432 ns | 0.1340 ns | 10.327 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |         Hello World  | 20.620 ns | 0.2471 ns | 0.2190 ns | 20.530 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |         Hello World  |  8.360 ns | 0.1111 ns | 0.1039 ns |  8.354 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |         Hello World  | 20.130 ns | 0.4345 ns | 0.4462 ns | 20.072 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |          **Hello world** |  **8.216 ns** | **0.1941 ns** | **0.2077 ns** |  **8.223 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |          Hello world | 10.560 ns | 0.1309 ns | 0.1161 ns | 10.569 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |          Hello world | 12.233 ns | 0.1526 ns | 0.1428 ns | 12.217 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |          Hello world | 17.796 ns | 0.2772 ns | 0.2593 ns | 17.798 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |          Hello world | 15.582 ns | 0.3423 ns | 0.3804 ns | 15.439 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |          Hello world | 18.029 ns | 0.2239 ns | 0.1869 ns | 18.042 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |         **Hello world ** |  **5.782 ns** | **0.1163 ns** | **0.1088 ns** |  **5.763 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |         Hello world  |  4.149 ns | 0.0794 ns | 0.0704 ns |  4.138 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |         Hello world  | 10.335 ns | 0.1235 ns | 0.1095 ns | 10.328 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |         Hello world  | 20.215 ns | 0.2490 ns | 0.2329 ns | 20.200 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |         Hello world  |  8.609 ns | 0.2022 ns | 0.1985 ns |  8.622 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |         Hello world  | 22.970 ns | 0.4523 ns | 0.4231 ns | 22.973 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** | **The q(...) dog. [39]** |  **5.753 ns** | **0.1479 ns** | **0.1452 ns** |  **5.685 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world | The q(...) dog. [39] |  3.421 ns | 0.0550 ns | 0.0514 ns |  3.404 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world | The q(...) dog. [39] | 10.356 ns | 0.1205 ns | 0.1127 ns | 10.388 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world | The q(...) dog. [39] | 15.829 ns | 0.1563 ns | 0.1305 ns | 15.820 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world | The q(...) dog. [39] |  8.397 ns | 0.1250 ns | 0.1169 ns |  8.409 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world | The q(...) dog. [39] | 11.624 ns | 0.1626 ns | 0.1441 ns | 11.581 ns |         - |
|                Equals |           Ordinal |          Hello world | The q(...) dog. [39] |  6.102 ns | 0.1563 ns | 0.1535 ns |  6.094 ns |         - |
|         EqualsWithLen |           Ordinal |          Hello world | The q(...) dog. [39] |  3.927 ns | 0.1127 ns | 0.1687 ns |  3.895 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world | The q(...) dog. [39] | 10.936 ns | 0.2514 ns | 0.4336 ns | 10.961 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world | The q(...) dog. [39] | 18.109 ns | 0.3663 ns | 0.4632 ns | 18.079 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world | The q(...) dog. [39] |  8.594 ns | 0.1946 ns | 0.2241 ns |  8.591 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world | The q(...) dog. [39] | 11.844 ns | 0.2719 ns | 0.2410 ns | 11.784 ns |         - |
|                **Equals** |           **Ordinal** |          **Hello world** |                    **y** |  **5.912 ns** | **0.0351 ns** | **0.0311 ns** |  **5.921 ns** |         **-** |
|         EqualsWithLen |           Ordinal |          Hello world |                    y |  3.447 ns | 0.0804 ns | 0.0671 ns |  3.432 ns |         - |
|         TrimEqualityA |           Ordinal |          Hello world |                    y | 10.589 ns | 0.1629 ns | 0.1523 ns | 10.578 ns |         - |
|        TrimEqualityAB |           Ordinal |          Hello world |                    y | 15.623 ns | 0.2379 ns | 0.2109 ns | 15.687 ns |         - |
|  TrimEqualityWithLenA |           Ordinal |          Hello world |                    y |  8.406 ns | 0.1390 ns | 0.1300 ns |  8.407 ns |         - |
| TrimEqualityWithLenAB |           Ordinal |          Hello world |                    y | 10.599 ns | 0.1506 ns | 0.1409 ns | 10.560 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                     **** |  **5.961 ns** | **0.0991 ns** | **0.0927 ns** |  **5.972 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                      |  3.462 ns | 0.0800 ns | 0.0748 ns |  3.455 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                      | 10.436 ns | 0.1349 ns | 0.1127 ns | 10.430 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                      | 14.326 ns | 0.3044 ns | 0.2847 ns | 14.314 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                      |  8.367 ns | 0.1021 ns | 0.0955 ns |  8.367 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                      |  9.732 ns | 0.1381 ns | 0.1292 ns |  9.703 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** N  ** |  **5.834 ns** | **0.1141 ns** | **0.1011 ns** |  **5.852 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  N   |  3.766 ns | 0.1082 ns | 0.1808 ns |  3.733 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  N   | 12.079 ns | 0.2574 ns | 0.4083 ns | 12.101 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  N   | 20.843 ns | 0.4432 ns | 0.5442 ns | 20.939 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  N   |  9.289 ns | 0.2221 ns | 0.3710 ns |  9.196 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  N   | 16.594 ns | 0.3138 ns | 0.4885 ns | 16.643 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** |  **6.200 ns** | **0.1140 ns** | **0.1066 ns** |  **6.207 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  3.778 ns | 0.1113 ns | 0.1890 ns |  3.745 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 11.049 ns | 0.2140 ns | 0.3001 ns | 11.053 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 24.700 ns | 0.5216 ns | 0.7139 ns | 24.658 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  8.639 ns | 0.1645 ns | 0.2020 ns |  8.651 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 23.876 ns | 0.5114 ns | 0.5472 ns | 23.913 ns |         - |
|                Equals |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  5.940 ns | 0.1443 ns | 0.1349 ns |  5.893 ns |         - |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  3.586 ns | 0.1048 ns | 0.1969 ns |  3.500 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 10.475 ns | 0.1820 ns | 0.1520 ns | 10.501 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 21.750 ns | 0.4503 ns | 0.4213 ns | 21.732 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  8.448 ns | 0.1980 ns | 0.2034 ns |  8.403 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 21.535 ns | 0.3117 ns | 0.2763 ns | 21.461 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** Y  ** |  **6.098 ns** | **0.1538 ns** | **0.2156 ns** |  **6.086 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  Y   |  3.328 ns | 0.1008 ns | 0.1311 ns |  3.295 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  Y   | 10.359 ns | 0.1559 ns | 0.1458 ns | 10.309 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  Y   | 18.863 ns | 0.3263 ns | 0.3052 ns | 18.876 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  Y   |  8.811 ns | 0.2039 ns | 0.2003 ns |  8.754 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  Y   | 14.853 ns | 0.2985 ns | 0.2792 ns | 14.896 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** Yx  ** |  **5.786 ns** | **0.1169 ns** | **0.1148 ns** |  **5.788 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                 Yx   |  4.477 ns | 0.0492 ns | 0.0436 ns |  4.481 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                 Yx   | 10.454 ns | 0.1913 ns | 0.1790 ns | 10.434 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                 Yx   | 19.916 ns | 0.3922 ns | 0.3669 ns | 19.863 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                 Yx   |  8.383 ns | 0.1428 ns | 0.1336 ns |  8.392 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                 Yx   | 15.930 ns | 0.3294 ns | 0.3081 ns | 15.800 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** n  ** |  **5.789 ns** | **0.0856 ns** | **0.0669 ns** |  **5.799 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  n   |  3.402 ns | 0.0419 ns | 0.0350 ns |  3.410 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  n   | 10.364 ns | 0.1136 ns | 0.1063 ns | 10.373 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  n   | 18.836 ns | 0.3377 ns | 0.3159 ns | 18.710 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  n   |  8.403 ns | 0.1762 ns | 0.1648 ns |  8.395 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  n   | 16.761 ns | 0.2973 ns | 0.2781 ns | 16.630 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** y  ** |  **6.334 ns** | **0.1591 ns** | **0.1488 ns** |  **6.294 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  y   |  3.464 ns | 0.0988 ns | 0.0970 ns |  3.442 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  y   | 11.677 ns | 0.1902 ns | 0.1686 ns | 11.643 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  y   | 18.769 ns | 0.2455 ns | 0.2176 ns | 18.719 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  y   |  8.337 ns | 0.1058 ns | 0.0989 ns |  8.299 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  y   | 14.663 ns | 0.1228 ns | 0.1026 ns | 14.657 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** yx  ** |  **6.020 ns** | **0.1380 ns** | **0.1291 ns** |  **6.014 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                 yx   |  3.482 ns | 0.0895 ns | 0.0958 ns |  3.503 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                 yx   | 10.711 ns | 0.2354 ns | 0.2519 ns | 10.748 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                 yx   | 19.990 ns | 0.3785 ns | 0.3540 ns | 20.003 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                 yx   |  8.358 ns | 0.1383 ns | 0.1294 ns |  8.308 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                 yx   | 15.870 ns | 0.2704 ns | 0.2530 ns | 15.826 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello World** |  **5.753 ns** | **0.0657 ns** | **0.0615 ns** |  **5.754 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |          Hello World |  3.603 ns | 0.0576 ns | 0.0510 ns |  3.587 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |          Hello World | 10.849 ns | 0.2511 ns | 0.2989 ns | 10.813 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |          Hello World | 17.136 ns | 0.3741 ns | 0.5825 ns | 17.079 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |          Hello World |  9.724 ns | 0.2303 ns | 0.2464 ns |  9.736 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |          Hello World | 13.880 ns | 0.3004 ns | 0.2950 ns | 13.882 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello World ** |  **6.984 ns** | **0.1814 ns** | **0.2601 ns** |  **6.985 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |         Hello World  |  5.217 ns | 0.4569 ns | 1.3473 ns |  5.187 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |         Hello World  | 11.720 ns | 0.2725 ns | 0.3244 ns | 11.637 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |         Hello World  | 18.664 ns | 0.3739 ns | 0.4728 ns | 18.694 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |         Hello World  |  9.236 ns | 0.1992 ns | 0.3791 ns |  9.186 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |         Hello World  | 14.975 ns | 0.3369 ns | 0.3152 ns | 14.842 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello world** |  **6.316 ns** | **0.1586 ns** | **0.1629 ns** |  **6.278 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |          Hello world |  3.763 ns | 0.1082 ns | 0.1684 ns |  3.711 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |          Hello world | 11.068 ns | 0.2031 ns | 0.1800 ns | 11.016 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |          Hello world | 16.641 ns | 0.3692 ns | 0.3791 ns | 16.683 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |          Hello world |  9.406 ns | 0.2179 ns | 0.3392 ns |  9.331 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |          Hello world | 12.170 ns | 0.2692 ns | 0.3204 ns | 12.097 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello world ** |  **6.011 ns** | **0.1475 ns** | **0.1698 ns** |  **5.990 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |         Hello world  |  3.538 ns | 0.1031 ns | 0.1751 ns |  3.514 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |         Hello world  | 10.630 ns | 0.2291 ns | 0.2031 ns | 10.628 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |         Hello world  | 17.184 ns | 0.2643 ns | 0.2473 ns | 17.164 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |         Hello world  |  8.473 ns | 0.1992 ns | 0.1765 ns |  8.441 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |         Hello world  | 13.223 ns | 0.1716 ns | 0.1521 ns | 13.195 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** | **The q(...) dog. [39]** |  **7.753 ns** | **0.1235 ns** | **0.1155 ns** |  **7.728 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 10.542 ns | 0.1806 ns | 0.1690 ns | 10.477 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 12.214 ns | 0.1416 ns | 0.1325 ns | 12.229 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 17.751 ns | 0.2555 ns | 0.2390 ns | 17.664 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 14.603 ns | 0.3200 ns | 0.2994 ns | 14.578 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 18.317 ns | 0.3808 ns | 0.3180 ns | 18.255 ns |         - |
|                Equals |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] |  9.383 ns | 0.2200 ns | 0.3359 ns |  9.314 ns |         - |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 11.791 ns | 0.2668 ns | 0.3073 ns | 11.781 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 13.708 ns | 0.3098 ns | 0.3043 ns | 13.693 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 19.787 ns | 0.4293 ns | 0.9056 ns | 19.490 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 16.089 ns | 0.2362 ns | 0.2210 ns | 16.091 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 19.326 ns | 0.4159 ns | 0.5964 ns | 19.209 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                    **y** |  **5.813 ns** | **0.1067 ns** | **0.0945 ns** |  **5.809 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                    y |  3.460 ns | 0.1016 ns | 0.1130 ns |  3.452 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                    y | 10.536 ns | 0.1637 ns | 0.1532 ns | 10.545 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                    y | 15.264 ns | 0.1716 ns | 0.1521 ns | 15.202 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                    y |  8.367 ns | 0.1436 ns | 0.1343 ns |  8.346 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                    y | 10.592 ns | 0.2069 ns | 0.1834 ns | 10.581 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                     **** |  **6.027 ns** | **0.1495 ns** | **0.1468 ns** |  **6.040 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                      |  3.886 ns | 0.1140 ns | 0.1740 ns |  3.874 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                      | 12.160 ns | 0.2569 ns | 0.2145 ns | 12.182 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                      | 16.153 ns | 0.3541 ns | 0.5190 ns | 16.166 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                      |  9.425 ns | 0.2197 ns | 0.3848 ns |  9.346 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                      | 10.781 ns | 0.2507 ns | 0.3079 ns | 10.733 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** N  ** |  **6.294 ns** | **0.1597 ns** | **0.1640 ns** |  **6.270 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  N   |  3.795 ns | 0.1018 ns | 0.1251 ns |  3.789 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  N   | 11.358 ns | 0.2649 ns | 0.2602 ns | 11.419 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  N   | 20.481 ns | 0.4475 ns | 0.4974 ns | 20.516 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  N   |  8.890 ns | 0.1929 ns | 0.2641 ns |  8.870 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  N   | 16.123 ns | 0.3010 ns | 0.2816 ns | 16.135 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** |  **6.129 ns** | **0.1512 ns** | **0.1553 ns** |  **6.119 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  3.613 ns | 0.1040 ns | 0.2101 ns |  3.576 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 10.736 ns | 0.2281 ns | 0.2022 ns | 10.726 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 22.074 ns | 0.4573 ns | 0.4491 ns | 22.167 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  8.589 ns | 0.1785 ns | 0.1582 ns |  8.543 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 22.099 ns | 0.4688 ns | 0.4385 ns | 22.147 ns |         - |
|                Equals |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  5.782 ns | 0.1154 ns | 0.1079 ns |  5.759 ns |         - |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  3.484 ns | 0.0971 ns | 0.0860 ns |  3.502 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 10.348 ns | 0.0827 ns | 0.0733 ns | 10.334 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 23.080 ns | 0.4426 ns | 0.3923 ns | 22.973 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  8.432 ns | 0.1165 ns | 0.1033 ns |  8.432 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 23.856 ns | 0.4920 ns | 0.6042 ns | 23.719 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** Y  ** |  **5.804 ns** | **0.1111 ns** | **0.0985 ns** |  **5.813 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  Y   |  4.198 ns | 0.1035 ns | 0.0968 ns |  4.211 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  Y   | 11.205 ns | 0.2470 ns | 0.2310 ns | 11.240 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  Y   | 20.389 ns | 0.4417 ns | 0.9122 ns | 20.223 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  Y   |  8.890 ns | 0.2080 ns | 0.2136 ns |  8.946 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  Y   | 15.311 ns | 0.2708 ns | 0.2400 ns | 15.370 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** Yx  ** |  **6.036 ns** | **0.1064 ns** | **0.0943 ns** |  **6.030 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                 Yx   |  3.627 ns | 0.0893 ns | 0.1337 ns |  3.665 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                 Yx   | 10.774 ns | 0.2335 ns | 0.2184 ns | 10.813 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                 Yx   | 20.847 ns | 0.3913 ns | 0.3268 ns | 20.786 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                 Yx   |  8.617 ns | 0.1707 ns | 0.1827 ns |  8.580 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                 Yx   | 15.937 ns | 0.3108 ns | 0.2755 ns | 15.953 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** n  ** |  **5.851 ns** | **0.1173 ns** | **0.1040 ns** |  **5.846 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  n   |  3.472 ns | 0.0865 ns | 0.0850 ns |  3.442 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  n   | 10.456 ns | 0.1327 ns | 0.1176 ns | 10.448 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  n   | 18.821 ns | 0.3864 ns | 0.3795 ns | 18.671 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  n   |  8.408 ns | 0.1465 ns | 0.1370 ns |  8.341 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  n   | 14.725 ns | 0.2463 ns | 0.2304 ns | 14.641 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** y  ** |  **5.910 ns** | **0.1372 ns** | **0.1283 ns** |  **5.945 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                  y   |  3.415 ns | 0.0564 ns | 0.0500 ns |  3.413 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                  y   | 10.400 ns | 0.1127 ns | 0.1055 ns | 10.409 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                  y   | 23.007 ns | 0.3050 ns | 0.2853 ns | 22.894 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                  y   |  8.391 ns | 0.1358 ns | 0.1204 ns |  8.374 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                  y   | 14.848 ns | 0.3121 ns | 0.3205 ns | 14.862 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** yx  ** |  **5.734 ns** | **0.0542 ns** | **0.0480 ns** |  **5.745 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                 yx   |  3.418 ns | 0.0625 ns | 0.0585 ns |  3.401 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                 yx   | 10.411 ns | 0.1782 ns | 0.1667 ns | 10.369 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                 yx   | 19.888 ns | 0.2303 ns | 0.2154 ns | 19.927 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                 yx   |  9.319 ns | 0.2194 ns | 0.4770 ns |  9.219 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                 yx   | 19.262 ns | 0.4183 ns | 0.7542 ns | 19.089 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello World** |  **6.355 ns** | **0.1634 ns** | **0.1528 ns** |  **6.394 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |          Hello World |  3.869 ns | 0.1086 ns | 0.1207 ns |  3.874 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |          Hello World | 11.379 ns | 0.2589 ns | 0.3543 ns | 11.385 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |          Hello World | 19.366 ns | 0.3991 ns | 0.6558 ns | 19.242 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |          Hello World |  9.623 ns | 0.2267 ns | 0.3323 ns |  9.683 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |          Hello World | 18.910 ns | 0.4026 ns | 0.3766 ns | 18.856 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello World ** |  **6.095 ns** | **0.1595 ns** | **0.2338 ns** |  **5.985 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |         Hello World  |  3.701 ns | 0.1083 ns | 0.1981 ns |  3.659 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |         Hello World  | 10.850 ns | 0.2517 ns | 0.3529 ns | 10.872 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |         Hello World  | 17.759 ns | 0.3890 ns | 0.5453 ns | 17.617 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |         Hello World  |  8.555 ns | 0.2020 ns | 0.1791 ns |  8.531 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |         Hello World  | 13.597 ns | 0.1892 ns | 0.1580 ns | 13.612 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello world** |  **5.909 ns** | **0.1506 ns** | **0.1611 ns** |  **5.880 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |          Hello world |  3.496 ns | 0.1045 ns | 0.1118 ns |  3.503 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |          Hello world | 10.726 ns | 0.2170 ns | 0.2030 ns | 10.655 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |          Hello world | 16.098 ns | 0.2183 ns | 0.1935 ns | 16.134 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |          Hello world |  8.376 ns | 0.2011 ns | 0.1782 ns |  8.346 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |          Hello world | 11.535 ns | 0.1111 ns | 0.0985 ns | 11.512 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello world ** |  **5.732 ns** | **0.1097 ns** | **0.0973 ns** |  **5.700 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |         Hello world  |  3.502 ns | 0.0671 ns | 0.0984 ns |  3.499 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |         Hello world  | 10.672 ns | 0.1570 ns | 0.1392 ns | 10.637 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |         Hello world  | 17.243 ns | 0.2458 ns | 0.2299 ns | 17.130 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |         Hello world  |  8.326 ns | 0.1040 ns | 0.0972 ns |  8.300 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |         Hello world  | 13.641 ns | 0.3015 ns | 0.5201 ns | 13.564 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **10.015 ns** | **0.2368 ns** | **0.4331 ns** | **10.041 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 13.530 ns | 0.1344 ns | 0.1122 ns | 13.543 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 14.873 ns | 0.3307 ns | 0.4526 ns | 14.767 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 20.913 ns | 0.4358 ns | 0.5352 ns | 20.848 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 17.191 ns | 0.3303 ns | 0.4522 ns | 17.068 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 20.460 ns | 0.4468 ns | 0.6823 ns | 20.334 ns |         - |
|                Equals |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] |  8.346 ns | 0.1939 ns | 0.2155 ns |  8.311 ns |         - |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 11.128 ns | 0.2592 ns | 0.2881 ns | 11.186 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 12.999 ns | 0.2664 ns | 0.2492 ns | 12.993 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 18.974 ns | 0.4149 ns | 0.4439 ns | 19.106 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 15.333 ns | 0.3383 ns | 0.4027 ns | 15.262 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 18.582 ns | 0.3605 ns | 0.3196 ns | 18.480 ns |         - |
|                **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                    **y** |  **5.953 ns** | **0.1503 ns** | **0.1476 ns** |  **5.966 ns** |         **-** |
|         EqualsWithLen |           Ordinal | The q(...) dog. [39] |                    y |  3.584 ns | 0.1029 ns | 0.0963 ns |  3.601 ns |         - |
|         TrimEqualityA |           Ordinal | The q(...) dog. [39] |                    y | 10.663 ns | 0.1459 ns | 0.1139 ns | 10.678 ns |         - |
|        TrimEqualityAB |           Ordinal | The q(...) dog. [39] |                    y | 15.173 ns | 0.3145 ns | 0.2788 ns | 15.195 ns |         - |
|  TrimEqualityWithLenA |           Ordinal | The q(...) dog. [39] |                    y |  8.588 ns | 0.1499 ns | 0.1402 ns |  8.543 ns |         - |
| TrimEqualityWithLenAB |           Ordinal | The q(...) dog. [39] |                    y | 11.988 ns | 0.2687 ns | 0.2987 ns | 11.909 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                     **** |  **5.357 ns** | **0.0919 ns** | **0.0815 ns** |  **5.365 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                      |  3.768 ns | 0.0717 ns | 0.0636 ns |  3.762 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                      |  8.484 ns | 0.1611 ns | 0.1507 ns |  8.437 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                      | 12.775 ns | 0.1800 ns | 0.1684 ns | 12.700 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                      |  7.357 ns | 0.1816 ns | 0.1699 ns |  7.347 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                      | 12.666 ns | 0.2198 ns | 0.1949 ns | 12.653 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** N  ** |  **4.729 ns** | **0.0810 ns** | **0.0677 ns** |  **4.691 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                  N   |  3.822 ns | 0.0981 ns | 0.0819 ns |  3.787 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                  N   |  9.216 ns | 0.5978 ns | 1.7627 ns |  8.120 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                  N   | 16.552 ns | 0.3256 ns | 0.2886 ns | 16.495 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                  N   |  7.323 ns | 0.1515 ns | 0.1343 ns |  7.314 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                  N   | 12.806 ns | 0.2828 ns | 0.2646 ns | 12.720 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** | ** The (...)dog.  [41]** |  **4.815 ns** | **0.1167 ns** | **0.1092 ns** |  **4.820 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  3.489 ns | 0.0765 ns | 0.0716 ns |  3.477 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  8.407 ns | 0.1918 ns | 0.1794 ns |  8.425 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |  The (...)dog.  [41] | 16.692 ns | 0.2652 ns | 0.2351 ns | 16.675 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  6.775 ns | 0.1263 ns | 0.1119 ns |  6.754 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |  The (...)dog.  [41] | 12.608 ns | 0.2342 ns | 0.2697 ns | 12.560 ns |         - |
|                Equals | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  4.887 ns | 0.1073 ns | 0.1004 ns |  4.861 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  3.457 ns | 0.0965 ns | 0.0902 ns |  3.448 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  8.154 ns | 0.1563 ns | 0.1386 ns |  8.100 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |  The (...)dog.  [41] | 16.238 ns | 0.2920 ns | 0.2732 ns | 16.255 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |  6.694 ns | 0.1682 ns | 0.1573 ns |  6.616 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |  The (...)dog.  [41] | 12.683 ns | 0.1800 ns | 0.1684 ns | 12.597 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** Y  ** |  **5.309 ns** | **0.1154 ns** | **0.1023 ns** |  **5.307 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                  Y   |  3.224 ns | 0.0623 ns | 0.0583 ns |  3.212 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                  Y   |  8.107 ns | 0.0725 ns | 0.0605 ns |  8.122 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                  Y   | 16.498 ns | 0.1907 ns | 0.1783 ns | 16.483 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                  Y   |  6.839 ns | 0.1220 ns | 0.1082 ns |  6.805 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                  Y   | 13.446 ns | 0.3032 ns | 0.4982 ns | 13.295 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                ** Yx  ** |  **4.768 ns** | **0.1100 ns** | **0.1029 ns** |  **4.745 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                 Yx   |  3.406 ns | 0.0478 ns | 0.0423 ns |  3.411 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                 Yx   |  8.211 ns | 0.1761 ns | 0.1561 ns |  8.166 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                 Yx   | 17.572 ns | 0.2176 ns | 0.2036 ns | 17.514 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                 Yx   |  6.658 ns | 0.1199 ns | 0.1122 ns |  6.632 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                 Yx   | 18.601 ns | 0.2954 ns | 0.2764 ns | 18.478 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** n  ** |  **4.727 ns** | **0.0844 ns** | **0.0789 ns** |  **4.717 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                  n   |  3.443 ns | 0.0712 ns | 0.0666 ns |  3.425 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                  n   |  8.145 ns | 0.1394 ns | 0.1304 ns |  8.098 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                  n   | 16.483 ns | 0.1674 ns | 0.1484 ns | 16.449 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                  n   |  7.228 ns | 0.1682 ns | 0.1574 ns |  7.143 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                  n   | 12.697 ns | 0.1081 ns | 0.1011 ns | 12.661 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** y  ** |  **5.073 ns** | **0.1347 ns** | **0.1751 ns** |  **5.098 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                  y   |  4.057 ns | 0.1177 ns | 0.2456 ns |  4.043 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                  y   |  8.913 ns | 0.2128 ns | 0.2767 ns |  8.891 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                  y   | 20.223 ns | 0.4219 ns | 0.4143 ns | 20.130 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                  y   |  7.176 ns | 0.1761 ns | 0.2162 ns |  7.172 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                  y   | 13.522 ns | 0.2988 ns | 0.3669 ns | 13.453 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                ** yx  ** |  **5.080 ns** | **0.1336 ns** | **0.1784 ns** |  **5.041 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                 yx   |  3.602 ns | 0.1071 ns | 0.1848 ns |  3.577 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                 yx   |  8.589 ns | 0.2072 ns | 0.2467 ns |  8.614 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                 yx   | 17.967 ns | 0.3566 ns | 0.4637 ns | 17.941 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                 yx   |  6.940 ns | 0.1706 ns | 0.1513 ns |  6.992 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                 yx   | 13.864 ns | 0.2812 ns | 0.2630 ns | 13.776 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |          **Hello World** |  **4.835 ns** | **0.1289 ns** | **0.1324 ns** |  **4.830 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |          Hello World |  3.497 ns | 0.0924 ns | 0.0865 ns |  3.501 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |          Hello World |  8.170 ns | 0.1373 ns | 0.1147 ns |  8.133 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |          Hello World | 13.896 ns | 0.2631 ns | 0.2461 ns | 13.797 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |          Hello World |  7.024 ns | 0.1684 ns | 0.1871 ns |  7.017 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |          Hello World |  9.841 ns | 0.2100 ns | 0.1861 ns |  9.858 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |         **Hello World ** |  **4.875 ns** | **0.1271 ns** | **0.1513 ns** |  **4.847 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |         Hello World  |  3.484 ns | 0.0679 ns | 0.0602 ns |  3.488 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |         Hello World  |  8.413 ns | 0.1708 ns | 0.1597 ns |  8.358 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |         Hello World  | 14.838 ns | 0.2433 ns | 0.2276 ns | 14.807 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |         Hello World  |  6.729 ns | 0.0755 ns | 0.0706 ns |  6.712 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |         Hello World  | 11.004 ns | 0.2016 ns | 0.1885 ns | 10.915 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |          **Hello world** |  **4.781 ns** | **0.1180 ns** | **0.1104 ns** |  **4.764 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |          Hello world |  3.417 ns | 0.0669 ns | 0.0593 ns |  3.405 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |          Hello world |  8.231 ns | 0.1590 ns | 0.1487 ns |  8.195 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |          Hello world | 13.848 ns | 0.2340 ns | 0.2074 ns | 13.780 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |          Hello world |  6.695 ns | 0.1013 ns | 0.0947 ns |  6.679 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |          Hello world | 10.273 ns | 0.2377 ns | 0.4908 ns | 10.267 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |         **Hello world ** |  **5.302 ns** | **0.1436 ns** | **0.2360 ns** |  **5.291 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |         Hello world  |  3.841 ns | 0.1124 ns | 0.2111 ns |  3.807 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |         Hello world  |  8.883 ns | 0.2093 ns | 0.3380 ns |  8.865 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |         Hello world  | 15.512 ns | 0.2985 ns | 0.2792 ns | 15.505 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |         Hello world  |  6.953 ns | 0.1191 ns | 0.1114 ns |  6.934 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |         Hello world  | 11.137 ns | 0.2050 ns | 0.1917 ns | 11.086 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** | **The q(...) dog. [39]** |  **4.944 ns** | **0.1285 ns** | **0.1479 ns** |  **4.908 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  3.479 ns | 0.1034 ns | 0.1269 ns |  3.463 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  8.293 ns | 0.1582 ns | 0.1402 ns |  8.328 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      | The q(...) dog. [39] | 14.440 ns | 0.2627 ns | 0.2811 ns | 14.374 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  6.721 ns | 0.1633 ns | 0.1604 ns |  6.695 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      | The q(...) dog. [39] | 10.158 ns | 0.2261 ns | 0.2514 ns | 10.070 ns |         - |
|                Equals | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  4.999 ns | 0.1315 ns | 0.1230 ns |  4.996 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  3.529 ns | 0.1063 ns | 0.1382 ns |  3.511 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  8.322 ns | 0.1936 ns | 0.1716 ns |  8.261 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      | The q(...) dog. [39] | 13.906 ns | 0.2125 ns | 0.1774 ns | 13.960 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  6.518 ns | 0.1237 ns | 0.1097 ns |  6.486 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      | The q(...) dog. [39] |  9.681 ns | 0.1927 ns | 0.1802 ns |  9.630 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                     **** |                    **y** |  **5.027 ns** | **0.1308 ns** | **0.1834 ns** |  **5.023 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                      |                    y |  4.996 ns | 0.0462 ns | 0.0410 ns |  4.994 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                      |                    y |  9.375 ns | 0.1128 ns | 0.1055 ns |  9.373 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                      |                    y | 13.052 ns | 0.1129 ns | 0.1056 ns | 13.069 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                      |                    y |  6.833 ns | 0.1685 ns | 0.1731 ns |  6.809 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                      |                    y |  9.664 ns | 0.2240 ns | 0.3553 ns |  9.648 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                     **** |  **5.133 ns** | **0.0973 ns** | **0.0910 ns** |  **5.132 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                      |  3.468 ns | 0.0684 ns | 0.0639 ns |  3.493 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                      | 17.406 ns | 0.1713 ns | 0.1602 ns | 17.344 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                      | 20.708 ns | 0.2579 ns | 0.2412 ns | 20.694 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                      | 14.358 ns | 0.1238 ns | 0.1158 ns | 14.395 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                      | 13.012 ns | 0.1081 ns | 0.1011 ns | 13.032 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** N  ** |  **8.165 ns** | **0.0934 ns** | **0.0873 ns** |  **8.172 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                  N   | 10.464 ns | 0.1541 ns | 0.1441 ns | 10.504 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                  N   | 13.034 ns | 0.2880 ns | 0.2694 ns | 12.919 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                  N   | 24.073 ns | 0.2546 ns | 0.2257 ns | 24.128 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                  N   | 11.098 ns | 0.1851 ns | 0.1731 ns | 11.023 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                  N   | 24.024 ns | 0.2207 ns | 0.2065 ns | 24.037 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** | ** The (...)dog.  [41]** |  **4.719 ns** | **0.0705 ns** | **0.0659 ns** |  **4.715 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] |  3.417 ns | 0.0821 ns | 0.0768 ns |  3.381 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 13.022 ns | 0.1062 ns | 0.0941 ns | 13.024 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 23.332 ns | 0.2193 ns | 0.2051 ns | 23.308 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 11.639 ns | 0.1517 ns | 0.1419 ns | 11.658 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 17.752 ns | 0.2071 ns | 0.1937 ns | 17.718 ns |         - |
|                Equals | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] |  4.745 ns | 0.0795 ns | 0.0744 ns |  4.749 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] |  3.407 ns | 0.0669 ns | 0.0626 ns |  3.384 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 13.073 ns | 0.2180 ns | 0.2039 ns | 12.999 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 21.259 ns | 0.2038 ns | 0.1807 ns | 21.241 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 11.982 ns | 0.2731 ns | 0.3454 ns | 11.870 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] | 17.710 ns | 0.2130 ns | 0.1888 ns | 17.639 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** Y  ** |  **7.510 ns** | **0.1311 ns** | **0.1226 ns** |  **7.502 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                  Y   |  9.795 ns | 0.2156 ns | 0.2017 ns |  9.727 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                  Y   | 13.026 ns | 0.1309 ns | 0.1224 ns | 13.009 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                  Y   | 24.015 ns | 0.2678 ns | 0.2505 ns | 23.957 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                  Y   | 13.056 ns | 0.1245 ns | 0.1165 ns | 13.046 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                  Y   | 24.051 ns | 0.2270 ns | 0.2123 ns | 24.034 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                ** Yx  ** |  **4.742 ns** | **0.0835 ns** | **0.0781 ns** |  **4.725 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                 Yx   |  3.397 ns | 0.0426 ns | 0.0398 ns |  3.399 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                 Yx   | 13.349 ns | 0.1546 ns | 0.1446 ns | 13.330 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                 Yx   | 23.965 ns | 0.2573 ns | 0.2406 ns | 23.886 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                 Yx   | 12.276 ns | 0.2691 ns | 0.3859 ns | 12.398 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                 Yx   | 21.161 ns | 0.4497 ns | 0.6731 ns | 21.193 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** n  ** |  **8.299 ns** | **0.1673 ns** | **0.2345 ns** |  **8.293 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                  n   | 10.481 ns | 0.1568 ns | 0.1467 ns | 10.469 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                  n   | 13.089 ns | 0.1244 ns | 0.1102 ns | 13.060 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                  n   | 23.355 ns | 0.3305 ns | 0.3091 ns | 23.485 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                  n   | 12.451 ns | 0.0808 ns | 0.0716 ns | 12.459 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                  n   | 23.975 ns | 0.2243 ns | 0.2098 ns | 24.014 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** y  ** |  **7.536 ns** | **0.1477 ns** | **0.1382 ns** |  **7.484 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                  y   | 10.265 ns | 0.1804 ns | 0.1687 ns | 10.233 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                  y   | 15.319 ns | 0.3821 ns | 1.1266 ns | 15.281 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                  y   | 25.584 ns | 0.5498 ns | 0.6751 ns | 25.536 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                  y   | 11.634 ns | 0.1841 ns | 0.1722 ns | 11.592 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                  y   | 23.996 ns | 0.3268 ns | 0.2897 ns | 23.875 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                ** yx  ** |  **4.734 ns** | **0.0713 ns** | **0.0667 ns** |  **4.759 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                 yx   |  3.426 ns | 0.0525 ns | 0.0491 ns |  3.425 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                 yx   | 12.957 ns | 0.1928 ns | 0.1709 ns | 12.912 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                 yx   | 26.092 ns | 1.3752 ns | 4.0547 ns | 23.382 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                 yx   | 11.681 ns | 0.1451 ns | 0.1357 ns | 11.674 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                 yx   | 19.526 ns | 0.1984 ns | 0.1759 ns | 19.497 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |          **Hello World** |  **4.717 ns** | **0.0826 ns** | **0.0773 ns** |  **4.709 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |          Hello World |  3.387 ns | 0.0504 ns | 0.0447 ns |  3.370 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |          Hello World | 13.015 ns | 0.0702 ns | 0.0586 ns | 13.029 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |          Hello World | 22.472 ns | 0.2579 ns | 0.2412 ns | 22.418 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |          Hello World | 15.211 ns | 0.1027 ns | 0.0960 ns | 15.158 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |          Hello World | 14.808 ns | 0.2056 ns | 0.1923 ns | 14.821 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |         **Hello World ** |  **4.725 ns** | **0.0760 ns** | **0.0711 ns** |  **4.738 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |         Hello World  |  3.429 ns | 0.0846 ns | 0.0791 ns |  3.404 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |         Hello World  | 13.032 ns | 0.1996 ns | 0.1867 ns | 12.947 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |         Hello World  | 19.759 ns | 0.3134 ns | 0.2931 ns | 19.657 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |         Hello World  | 11.636 ns | 0.1405 ns | 0.1314 ns | 11.613 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |         Hello World  | 15.963 ns | 0.1826 ns | 0.1618 ns | 15.880 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |          **Hello world** |  **4.830 ns** | **0.0766 ns** | **0.0716 ns** |  **4.844 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |          Hello world |  3.403 ns | 0.0364 ns | 0.0304 ns |  3.402 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |          Hello world | 16.487 ns | 0.2295 ns | 0.2147 ns | 16.373 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |          Hello world | 18.376 ns | 0.2138 ns | 0.1895 ns | 18.391 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |          Hello world | 11.912 ns | 0.1041 ns | 0.0923 ns | 11.904 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |          Hello world | 14.619 ns | 0.2532 ns | 0.2369 ns | 14.526 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |         **Hello world ** |  **5.067 ns** | **0.0862 ns** | **0.0806 ns** |  **5.065 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |         Hello world  |  3.911 ns | 0.0700 ns | 0.0655 ns |  3.885 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |         Hello world  | 12.988 ns | 0.1341 ns | 0.1120 ns | 12.958 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |         Hello world  | 19.691 ns | 0.2219 ns | 0.1967 ns | 19.608 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |         Hello world  | 11.626 ns | 0.1479 ns | 0.1383 ns | 11.623 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |         Hello world  | 16.022 ns | 0.1971 ns | 0.1844 ns | 15.952 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** | **The q(...) dog. [39]** |  **4.831 ns** | **0.0600 ns** | **0.0532 ns** |  **4.832 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] |  3.424 ns | 0.0959 ns | 0.0850 ns |  3.401 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 13.031 ns | 0.1427 ns | 0.1265 ns | 13.037 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 18.849 ns | 0.3689 ns | 0.3450 ns | 18.855 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 11.632 ns | 0.1654 ns | 0.1547 ns | 11.620 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 14.649 ns | 0.2440 ns | 0.2282 ns | 14.595 ns |         - |
|                Equals | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] |  4.724 ns | 0.0838 ns | 0.0783 ns |  4.702 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] |  3.406 ns | 0.0411 ns | 0.0384 ns |  3.417 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 13.034 ns | 0.0985 ns | 0.0873 ns | 13.046 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 18.402 ns | 0.3727 ns | 0.3486 ns | 18.297 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 11.687 ns | 0.2038 ns | 0.1906 ns | 11.601 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] | 14.737 ns | 0.3133 ns | 0.3483 ns | 14.539 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                    **y** |  **4.716 ns** | **0.0875 ns** | **0.0819 ns** |  **4.686 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  n   |                    y |  3.435 ns | 0.0739 ns | 0.0691 ns |  3.413 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  n   |                    y | 15.399 ns | 0.2727 ns | 0.2551 ns | 15.270 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  n   |                    y | 20.074 ns | 0.2954 ns | 0.2764 ns | 19.982 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  n   |                    y | 17.832 ns | 0.3833 ns | 0.4260 ns | 17.817 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  n   |                    y | 22.086 ns | 0.4569 ns | 0.6255 ns | 22.128 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                     **** |  **5.633 ns** | **0.1504 ns** | **0.1477 ns** |  **5.623 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                      |  3.707 ns | 0.1682 ns | 0.4961 ns |  3.627 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                      | 13.173 ns | 0.1213 ns | 0.1135 ns | 13.172 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                      | 16.651 ns | 0.2641 ns | 0.2470 ns | 16.618 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                      | 11.627 ns | 0.1290 ns | 0.1207 ns | 11.597 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                      | 12.922 ns | 0.1202 ns | 0.1004 ns | 12.910 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** N  ** |  **7.124 ns** | **0.1297 ns** | **0.1213 ns** |  **7.107 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                  N   | 10.224 ns | 0.1156 ns | 0.1081 ns | 10.250 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                  N   | 13.338 ns | 0.1208 ns | 0.1071 ns | 13.331 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                  N   | 24.377 ns | 0.5164 ns | 0.5740 ns | 24.287 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                  N   | 11.593 ns | 0.1181 ns | 0.1047 ns | 11.576 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                  N   | 24.145 ns | 0.3074 ns | 0.2876 ns | 24.175 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** | ** The (...)dog.  [41]** |  **5.058 ns** | **0.1345 ns** | **0.2133 ns** |  **5.067 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] |  3.179 ns | 0.0292 ns | 0.0228 ns |  3.177 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 13.074 ns | 0.2189 ns | 0.2047 ns | 13.058 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 21.208 ns | 0.1919 ns | 0.1795 ns | 21.214 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 11.603 ns | 0.1035 ns | 0.0968 ns | 11.569 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 17.684 ns | 0.1893 ns | 0.1678 ns | 17.698 ns |         - |
|                Equals | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] |  4.726 ns | 0.0874 ns | 0.0817 ns |  4.701 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] |  3.417 ns | 0.0598 ns | 0.0559 ns |  3.393 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 13.260 ns | 0.1530 ns | 0.1432 ns | 13.216 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 21.260 ns | 0.2782 ns | 0.2602 ns | 21.155 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 11.627 ns | 0.1623 ns | 0.1519 ns | 11.627 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] | 17.752 ns | 0.1955 ns | 0.1829 ns | 17.697 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** Y  ** |  **7.946 ns** | **0.0976 ns** | **0.0913 ns** |  **7.926 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                  Y   | 10.488 ns | 0.1598 ns | 0.1495 ns | 10.457 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                  Y   | 13.001 ns | 0.2231 ns | 0.1978 ns | 12.929 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                  Y   | 23.993 ns | 0.2390 ns | 0.2236 ns | 24.022 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                  Y   | 11.596 ns | 0.1052 ns | 0.0933 ns | 11.602 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                  Y   | 24.142 ns | 0.3295 ns | 0.3082 ns | 24.109 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                ** Yx  ** |  **4.726 ns** | **0.0793 ns** | **0.0742 ns** |  **4.698 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                 Yx   |  3.437 ns | 0.0899 ns | 0.0841 ns |  3.425 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                 Yx   | 13.266 ns | 0.2439 ns | 0.2162 ns | 13.173 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                 Yx   | 22.773 ns | 0.2844 ns | 0.2521 ns | 22.810 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                 Yx   | 11.598 ns | 0.1452 ns | 0.1358 ns | 11.542 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                 Yx   | 19.143 ns | 0.1766 ns | 0.1651 ns | 19.155 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** n  ** |  **7.481 ns** | **0.1135 ns** | **0.1062 ns** |  **7.447 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                  n   | 10.247 ns | 0.1362 ns | 0.1274 ns | 10.186 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                  n   | 13.233 ns | 0.1266 ns | 0.1184 ns | 13.261 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                  n   | 23.949 ns | 0.3584 ns | 0.3353 ns | 23.888 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                  n   | 11.736 ns | 0.1379 ns | 0.1222 ns | 11.704 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                  n   | 24.509 ns | 0.3019 ns | 0.2824 ns | 24.535 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** y  ** |  **7.922 ns** | **0.0868 ns** | **0.0769 ns** |  **7.908 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                  y   | 10.401 ns | 0.1433 ns | 0.1270 ns | 10.381 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                  y   | 13.045 ns | 0.1266 ns | 0.1184 ns | 13.063 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                  y   | 23.252 ns | 0.3097 ns | 0.2897 ns | 23.242 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                  y   | 11.618 ns | 0.1101 ns | 0.1030 ns | 11.609 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                  y   | 24.218 ns | 0.2535 ns | 0.2371 ns | 24.140 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                ** yx  ** |  **4.845 ns** | **0.0830 ns** | **0.0776 ns** |  **4.834 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                 yx   |  3.393 ns | 0.0440 ns | 0.0367 ns |  3.396 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                 yx   | 13.088 ns | 0.2747 ns | 0.2570 ns | 13.004 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                 yx   | 22.766 ns | 0.2622 ns | 0.2453 ns | 22.724 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                 yx   | 11.711 ns | 0.1782 ns | 0.1667 ns | 11.683 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                 yx   | 19.136 ns | 0.3452 ns | 0.3229 ns | 19.051 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |          **Hello World** |  **4.721 ns** | **0.0772 ns** | **0.0722 ns** |  **4.713 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |          Hello World |  3.460 ns | 0.0717 ns | 0.0671 ns |  3.421 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |          Hello World | 15.007 ns | 0.1525 ns | 0.1273 ns | 14.996 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |          Hello World | 18.578 ns | 0.4010 ns | 0.4291 ns | 18.615 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |          Hello World | 11.629 ns | 0.1095 ns | 0.1024 ns | 11.614 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |          Hello World | 14.703 ns | 0.2585 ns | 0.2655 ns | 14.566 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |         **Hello World ** |  **4.726 ns** | **0.0756 ns** | **0.0707 ns** |  **4.722 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |         Hello World  |  3.425 ns | 0.0712 ns | 0.0666 ns |  3.426 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |         Hello World  | 13.098 ns | 0.2921 ns | 0.3125 ns | 12.949 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |         Hello World  | 22.126 ns | 0.2797 ns | 0.2479 ns | 22.007 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |         Hello World  | 11.645 ns | 0.1676 ns | 0.1568 ns | 11.603 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |         Hello World  | 15.939 ns | 0.2209 ns | 0.1959 ns | 15.884 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |          **Hello world** |  **4.735 ns** | **0.0779 ns** | **0.0728 ns** |  **4.706 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |          Hello world |  3.400 ns | 0.0655 ns | 0.0580 ns |  3.373 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |          Hello world | 12.997 ns | 0.1622 ns | 0.1438 ns | 12.939 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |          Hello world | 21.641 ns | 0.3680 ns | 0.3442 ns | 21.515 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |          Hello world | 15.297 ns | 0.1158 ns | 0.1027 ns | 15.292 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |          Hello world | 16.305 ns | 0.3421 ns | 0.3360 ns | 16.338 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |         **Hello world ** |  **5.453 ns** | **0.1426 ns** | **0.1904 ns** |  **5.497 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |         Hello world  |  3.346 ns | 0.1072 ns | 0.2013 ns |  3.298 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |         Hello world  | 14.388 ns | 0.2191 ns | 0.2049 ns | 14.372 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |         Hello world  | 23.406 ns | 0.2221 ns | 0.2077 ns | 23.343 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |         Hello world  | 11.580 ns | 0.1048 ns | 0.0929 ns | 11.575 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |         Hello world  | 15.971 ns | 0.2036 ns | 0.1805 ns | 15.939 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** | **The q(...) dog. [39]** |  **4.719 ns** | **0.0505 ns** | **0.0473 ns** |  **4.708 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] |  3.424 ns | 0.0571 ns | 0.0506 ns |  3.424 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 13.284 ns | 0.2864 ns | 0.2813 ns | 13.256 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 18.288 ns | 0.2354 ns | 0.2087 ns | 18.221 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 11.612 ns | 0.1114 ns | 0.1042 ns | 11.613 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 14.660 ns | 0.2659 ns | 0.2488 ns | 14.578 ns |         - |
|                Equals | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] |  4.687 ns | 0.0477 ns | 0.0423 ns |  4.691 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] |  3.976 ns | 0.0612 ns | 0.0542 ns |  3.984 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 14.518 ns | 0.2432 ns | 0.2156 ns | 14.427 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 18.297 ns | 0.2413 ns | 0.2139 ns | 18.251 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 12.650 ns | 0.1093 ns | 0.1023 ns | 12.646 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] | 16.284 ns | 0.2282 ns | 0.2135 ns | 16.186 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                    **y** |  **4.732 ns** | **0.0719 ns** | **0.0673 ns** |  **4.730 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                  y   |                    y |  3.424 ns | 0.0757 ns | 0.0708 ns |  3.421 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                  y   |                    y | 15.336 ns | 0.2527 ns | 0.2364 ns | 15.309 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                  y   |                    y | 20.695 ns | 0.3081 ns | 0.2882 ns | 20.592 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                  y   |                    y | 19.457 ns | 0.3129 ns | 0.2927 ns | 19.469 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                  y   |                    y | 19.761 ns | 0.2556 ns | 0.2391 ns | 19.693 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                     **** |  **4.731 ns** | **0.0891 ns** | **0.0833 ns** |  **4.718 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                      |  3.241 ns | 0.0697 ns | 0.0652 ns |  3.217 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                      | 16.043 ns | 0.2628 ns | 0.2458 ns | 15.995 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                      | 17.770 ns | 0.3145 ns | 0.2942 ns | 17.654 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                      | 12.820 ns | 0.1697 ns | 0.1587 ns | 12.824 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                      | 15.961 ns | 0.2804 ns | 0.2622 ns | 15.836 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** N  ** |  **4.858 ns** | **0.0915 ns** | **0.0856 ns** |  **4.859 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                  N   |  3.646 ns | 0.0786 ns | 0.0735 ns |  3.602 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                  N   | 14.388 ns | 0.3011 ns | 0.3092 ns | 14.242 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                  N   | 23.014 ns | 0.2057 ns | 0.1924 ns | 23.056 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                  N   | 12.807 ns | 0.1390 ns | 0.1300 ns | 12.807 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                  N   | 21.641 ns | 0.7649 ns | 2.2554 ns | 21.720 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** | ** The (...)dog.  [41]** |  **4.709 ns** | **0.0762 ns** | **0.0712 ns** |  **4.693 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] |  3.423 ns | 0.1003 ns | 0.0938 ns |  3.407 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 14.324 ns | 0.1608 ns | 0.1425 ns | 14.312 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 23.544 ns | 0.2592 ns | 0.2298 ns | 23.545 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 13.447 ns | 0.2855 ns | 0.2804 ns | 13.524 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 20.273 ns | 0.4215 ns | 0.4510 ns | 20.282 ns |         - |
|                Equals | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] |  5.967 ns | 0.1577 ns | 0.3257 ns |  5.935 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] |  3.629 ns | 0.1090 ns | 0.0967 ns |  3.627 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 14.451 ns | 0.2775 ns | 0.2460 ns | 14.429 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 22.540 ns | 0.2261 ns | 0.2115 ns | 22.522 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 12.808 ns | 0.1622 ns | 0.1517 ns | 12.747 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] | 19.130 ns | 0.2536 ns | 0.2248 ns | 19.062 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** Y  ** |  **4.697 ns** | **0.0679 ns** | **0.0602 ns** |  **4.676 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                  Y   |  3.414 ns | 0.0557 ns | 0.0494 ns |  3.408 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                  Y   | 15.686 ns | 0.3137 ns | 0.2781 ns | 15.593 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                  Y   | 23.146 ns | 0.4084 ns | 0.3620 ns | 23.212 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                  Y   | 16.609 ns | 0.1695 ns | 0.1585 ns | 16.549 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                  Y   | 23.829 ns | 0.2902 ns | 0.2715 ns | 23.876 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                ** Yx  ** |  **8.181 ns** | **0.1181 ns** | **0.1047 ns** |  **8.165 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                 Yx   | 11.495 ns | 0.1595 ns | 0.1492 ns | 11.516 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                 Yx   | 14.284 ns | 0.1494 ns | 0.1324 ns | 14.243 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                 Yx   | 26.844 ns | 0.2061 ns | 0.1928 ns | 26.842 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                 Yx   | 12.779 ns | 0.1493 ns | 0.1397 ns | 12.775 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                 Yx   | 26.858 ns | 0.2731 ns | 0.2555 ns | 26.927 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** n  ** |  **4.729 ns** | **0.0831 ns** | **0.0778 ns** |  **4.723 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                  n   |  3.415 ns | 0.0798 ns | 0.0707 ns |  3.404 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                  n   | 14.357 ns | 0.2585 ns | 0.2418 ns | 14.314 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                  n   | 23.174 ns | 0.3768 ns | 0.3525 ns | 23.120 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                  n   | 12.705 ns | 0.1236 ns | 0.1032 ns | 12.676 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                  n   | 19.466 ns | 0.3427 ns | 0.3038 ns | 19.351 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** y  ** |  **4.852 ns** | **0.0674 ns** | **0.0631 ns** |  **4.839 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                  y   |  3.410 ns | 0.0737 ns | 0.0689 ns |  3.378 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                  y   | 14.872 ns | 0.2582 ns | 0.2415 ns | 14.783 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                  y   | 22.951 ns | 0.2039 ns | 0.1807 ns | 22.898 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                  y   | 12.746 ns | 0.0957 ns | 0.0895 ns | 12.749 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                  y   | 19.419 ns | 0.3517 ns | 0.3290 ns | 19.253 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                ** yx  ** |  **8.182 ns** | **0.1106 ns** | **0.0981 ns** |  **8.178 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                 yx   | 11.483 ns | 0.1494 ns | 0.1398 ns | 11.513 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                 yx   | 14.370 ns | 0.2555 ns | 0.2390 ns | 14.328 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                 yx   | 26.717 ns | 0.2879 ns | 0.2552 ns | 26.659 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                 yx   | 12.859 ns | 0.1442 ns | 0.1349 ns | 12.892 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                 yx   | 26.815 ns | 0.2648 ns | 0.2477 ns | 26.854 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |          **Hello World** |  **4.790 ns** | **0.0650 ns** | **0.0608 ns** |  **4.787 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |          Hello World |  4.028 ns | 0.0641 ns | 0.0600 ns |  4.025 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |          Hello World | 14.373 ns | 0.2872 ns | 0.2687 ns | 14.358 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |          Hello World | 20.119 ns | 0.3824 ns | 0.3577 ns | 20.066 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |          Hello World | 12.755 ns | 0.1239 ns | 0.1034 ns | 12.723 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |          Hello World | 15.519 ns | 0.1210 ns | 0.1131 ns | 15.505 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |         **Hello World ** |  **4.866 ns** | **0.1264 ns** | **0.1182 ns** |  **4.809 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |         Hello World  |  3.416 ns | 0.0624 ns | 0.0553 ns |  3.412 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |         Hello World  | 14.331 ns | 0.1825 ns | 0.1618 ns | 14.245 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |         Hello World  | 21.023 ns | 0.2438 ns | 0.2161 ns | 20.983 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |         Hello World  | 12.827 ns | 0.1604 ns | 0.1500 ns | 12.838 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |         Hello World  | 16.871 ns | 0.1737 ns | 0.1625 ns | 16.860 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |          **Hello world** |  **5.131 ns** | **0.0953 ns** | **0.0891 ns** |  **5.147 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |          Hello world |  3.441 ns | 0.0761 ns | 0.0712 ns |  3.406 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |          Hello world | 14.378 ns | 0.2433 ns | 0.2156 ns | 14.295 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |          Hello world | 19.656 ns | 0.3878 ns | 0.3628 ns | 19.483 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |          Hello world | 12.851 ns | 0.2002 ns | 0.1873 ns | 12.807 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |          Hello world | 15.695 ns | 0.3411 ns | 0.3350 ns | 15.584 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |         **Hello world ** |  **4.711 ns** | **0.0735 ns** | **0.0688 ns** |  **4.727 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |         Hello world  |  3.415 ns | 0.0679 ns | 0.0602 ns |  3.396 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |         Hello world  | 14.310 ns | 0.2206 ns | 0.1955 ns | 14.241 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |         Hello world  | 21.062 ns | 0.2722 ns | 0.2546 ns | 21.011 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |         Hello world  | 12.776 ns | 0.2438 ns | 0.2161 ns | 12.697 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |         Hello world  | 17.096 ns | 0.3447 ns | 0.3225 ns | 16.979 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** | **The q(...) dog. [39]** |  **4.707 ns** | **0.0826 ns** | **0.0732 ns** |  **4.680 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] |  3.424 ns | 0.0616 ns | 0.0576 ns |  3.415 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 14.421 ns | 0.3152 ns | 0.2949 ns | 14.358 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 20.724 ns | 0.4436 ns | 0.4556 ns | 20.656 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 12.794 ns | 0.1475 ns | 0.1380 ns | 12.755 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 15.698 ns | 0.2684 ns | 0.2510 ns | 15.658 ns |         - |
|                Equals | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] |  4.735 ns | 0.0850 ns | 0.0795 ns |  4.733 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] |  3.410 ns | 0.0592 ns | 0.0525 ns |  3.394 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 14.309 ns | 0.2076 ns | 0.1734 ns | 14.295 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 19.598 ns | 0.1853 ns | 0.1733 ns | 19.633 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 12.838 ns | 0.1207 ns | 0.1129 ns | 12.868 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] | 15.579 ns | 0.2037 ns | 0.1806 ns | 15.538 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                    **y** |  **4.699 ns** | **0.1108 ns** | **0.0982 ns** |  **4.667 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |                 yx   |                    y |  3.908 ns | 0.0703 ns | 0.0624 ns |  3.890 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |                 yx   |                    y | 14.917 ns | 0.2239 ns | 0.1984 ns | 14.821 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |                 yx   |                    y | 18.703 ns | 0.2839 ns | 0.2655 ns | 18.611 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |                 yx   |                    y | 14.503 ns | 0.1049 ns | 0.0981 ns | 14.512 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |                 yx   |                    y | 14.651 ns | 0.1929 ns | 0.1710 ns | 14.625 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                     **** |  **4.844 ns** | **0.0884 ns** | **0.0827 ns** |  **4.846 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                      |  3.422 ns | 0.0689 ns | 0.0644 ns |  3.405 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                      |  9.807 ns | 0.1479 ns | 0.1383 ns |  9.743 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                      | 13.597 ns | 0.2615 ns | 0.2318 ns | 13.534 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                      |  8.386 ns | 0.1199 ns | 0.1122 ns |  8.393 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                      | 10.507 ns | 0.2418 ns | 0.4939 ns | 10.510 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** N  ** |  **5.412 ns** | **0.1458 ns** | **0.1896 ns** |  **5.457 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                  N   |  3.473 ns | 0.1011 ns | 0.0896 ns |  3.468 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                  N   |  9.814 ns | 0.1739 ns | 0.1541 ns |  9.752 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                  N   | 19.566 ns | 0.1371 ns | 0.1282 ns | 19.576 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                  N   |  8.400 ns | 0.1866 ns | 0.1746 ns |  8.335 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                  N   | 14.743 ns | 0.2605 ns | 0.2437 ns | 14.691 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** | ** The (...)dog.  [41]** |  **4.712 ns** | **0.0587 ns** | **0.0490 ns** |  **4.716 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  3.799 ns | 0.0352 ns | 0.0329 ns |  3.800 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  9.827 ns | 0.1431 ns | 0.1268 ns |  9.801 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] | 19.676 ns | 0.4273 ns | 0.7139 ns | 19.690 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  8.480 ns | 0.1758 ns | 0.2577 ns |  8.399 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] | 14.430 ns | 0.2393 ns | 0.1998 ns | 14.339 ns |         - |
|                Equals | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  4.733 ns | 0.0870 ns | 0.0813 ns |  4.730 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  3.434 ns | 0.0985 ns | 0.0968 ns |  3.396 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  9.910 ns | 0.1802 ns | 0.1686 ns |  9.862 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] | 18.264 ns | 0.2596 ns | 0.2428 ns | 18.228 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |  8.711 ns | 0.1981 ns | 0.4002 ns |  8.621 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] | 14.615 ns | 0.3168 ns | 0.3649 ns | 14.455 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** Y  ** |  **4.745 ns** | **0.0878 ns** | **0.0821 ns** |  **4.760 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                  Y   |  3.404 ns | 0.0580 ns | 0.0515 ns |  3.388 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                  Y   |  9.869 ns | 0.1407 ns | 0.1316 ns |  9.852 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                  Y   | 18.257 ns | 0.2312 ns | 0.2049 ns | 18.233 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                  Y   |  8.395 ns | 0.1719 ns | 0.1608 ns |  8.315 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                  Y   | 14.777 ns | 0.2421 ns | 0.2265 ns | 14.769 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                ** Yx  ** |  **4.737 ns** | **0.1012 ns** | **0.0947 ns** |  **4.715 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                 Yx   |  3.397 ns | 0.0628 ns | 0.0588 ns |  3.405 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                 Yx   | 10.178 ns | 0.0963 ns | 0.0900 ns | 10.203 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                 Yx   | 19.769 ns | 0.2100 ns | 0.1965 ns | 19.819 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                 Yx   |  8.436 ns | 0.1913 ns | 0.1789 ns |  8.470 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                 Yx   | 17.322 ns | 0.3718 ns | 0.3818 ns | 17.345 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** n  ** |  **5.822 ns** | **0.1659 ns** | **0.4866 ns** |  **5.838 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                  n   |  3.391 ns | 0.0904 ns | 0.0845 ns |  3.351 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                  n   |  9.812 ns | 0.1322 ns | 0.1237 ns |  9.811 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                  n   | 19.719 ns | 0.2388 ns | 0.2117 ns | 19.673 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                  n   |  8.592 ns | 0.1099 ns | 0.1028 ns |  8.580 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                  n   | 14.752 ns | 0.2200 ns | 0.2058 ns | 14.741 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** y  ** |  **4.925 ns** | **0.1307 ns** | **0.2323 ns** |  **4.907 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                  y   |  3.438 ns | 0.0910 ns | 0.0851 ns |  3.430 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                  y   |  9.817 ns | 0.1677 ns | 0.1569 ns |  9.750 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                  y   | 21.814 ns | 0.2184 ns | 0.2043 ns | 21.835 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                  y   |  8.370 ns | 0.1642 ns | 0.1536 ns |  8.367 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                  y   | 14.824 ns | 0.3165 ns | 0.2961 ns | 14.688 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                ** yx  ** |  **4.712 ns** | **0.0482 ns** | **0.0450 ns** |  **4.717 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                 yx   |  3.402 ns | 0.0502 ns | 0.0445 ns |  3.392 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                 yx   |  9.823 ns | 0.1778 ns | 0.1663 ns |  9.746 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                 yx   | 19.734 ns | 0.2726 ns | 0.2550 ns | 19.661 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                 yx   |  8.526 ns | 0.1821 ns | 0.1703 ns |  8.483 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                 yx   | 16.685 ns | 0.2498 ns | 0.2215 ns | 16.611 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |          **Hello World** | **11.102 ns** | **0.1393 ns** | **0.1303 ns** | **11.104 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |          Hello World | 16.891 ns | 0.2841 ns | 0.2657 ns | 16.895 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |          Hello World | 17.786 ns | 0.3798 ns | 0.6551 ns | 17.708 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |          Hello World | 23.379 ns | 0.5054 ns | 1.4662 ns | 22.728 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |          Hello World | 18.413 ns | 0.2744 ns | 0.2567 ns | 18.367 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |          Hello World | 22.367 ns | 0.3529 ns | 0.3301 ns | 22.321 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |         **Hello World ** |  **5.547 ns** | **0.0567 ns** | **0.0530 ns** |  **5.555 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |         Hello World  |  4.790 ns | 0.2724 ns | 0.8032 ns |  4.542 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |         Hello World  |  9.805 ns | 0.0885 ns | 0.0785 ns |  9.824 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |         Hello World  | 25.880 ns | 0.2488 ns | 0.2328 ns | 25.940 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |         Hello World  |  8.428 ns | 0.2020 ns | 0.1889 ns |  8.347 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |         Hello World  | 23.424 ns | 0.2954 ns | 0.2618 ns | 23.507 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |          **Hello world** | **11.167 ns** | **0.1981 ns** | **0.1853 ns** | **11.188 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |          Hello world | 15.005 ns | 0.3145 ns | 0.2941 ns | 15.043 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |          Hello world | 18.931 ns | 0.3977 ns | 0.4256 ns | 18.825 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |          Hello world | 25.049 ns | 0.4972 ns | 0.4152 ns | 25.052 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |          Hello world | 21.350 ns | 0.6184 ns | 1.8234 ns | 21.310 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |          Hello world | 22.044 ns | 0.3043 ns | 0.2846 ns | 22.010 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |         **Hello world ** |  **4.716 ns** | **0.0790 ns** | **0.0739 ns** |  **4.698 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |         Hello world  |  3.423 ns | 0.0669 ns | 0.0626 ns |  3.430 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |         Hello world  |  9.845 ns | 0.1786 ns | 0.1671 ns |  9.854 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |         Hello world  | 24.003 ns | 0.5111 ns | 0.9216 ns | 23.930 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |         Hello world  |  8.374 ns | 0.1612 ns | 0.1508 ns |  8.317 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |         Hello world  | 28.561 ns | 0.2364 ns | 0.2212 ns | 28.557 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** | **The q(...) dog. [39]** |  **4.713 ns** | **0.0584 ns** | **0.0517 ns** |  **4.707 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  3.429 ns | 0.1011 ns | 0.0897 ns |  3.408 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  9.871 ns | 0.1524 ns | 0.1425 ns |  9.825 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] | 15.368 ns | 0.3203 ns | 0.2996 ns | 15.308 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  9.828 ns | 0.4017 ns | 1.1397 ns |  9.691 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] | 14.343 ns | 0.3205 ns | 0.4493 ns | 14.384 ns |         - |
|                Equals | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  5.169 ns | 0.1550 ns | 0.4571 ns |  5.073 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  3.212 ns | 0.0513 ns | 0.0455 ns |  3.216 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  9.782 ns | 0.1153 ns | 0.0963 ns |  9.772 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] | 15.343 ns | 0.1814 ns | 0.1697 ns | 15.307 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |  8.424 ns | 0.1788 ns | 0.1672 ns |  8.358 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] | 12.034 ns | 0.2705 ns | 0.4130 ns | 11.962 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                    **y** |  **4.729 ns** | **0.0958 ns** | **0.0896 ns** |  **4.729 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello World |                    y |  3.397 ns | 0.0480 ns | 0.0425 ns |  3.393 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello World |                    y |  9.831 ns | 0.1641 ns | 0.1535 ns |  9.766 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello World |                    y | 14.357 ns | 0.0815 ns | 0.0637 ns | 14.363 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello World |                    y |  8.380 ns | 0.1436 ns | 0.1343 ns |  8.349 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello World |                    y | 10.562 ns | 0.2088 ns | 0.1851 ns | 10.561 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                     **** |  **4.701 ns** | **0.0728 ns** | **0.0608 ns** |  **4.699 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                      |  3.426 ns | 0.0762 ns | 0.0713 ns |  3.410 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                      |  9.819 ns | 0.1530 ns | 0.1431 ns |  9.795 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                      | 13.610 ns | 0.2470 ns | 0.2190 ns | 13.541 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                      |  8.891 ns | 0.1363 ns | 0.1275 ns |  8.905 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                      |  9.769 ns | 0.1801 ns | 0.1685 ns |  9.747 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** N  ** |  **5.072 ns** | **0.1340 ns** | **0.2644 ns** |  **5.086 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                  N   |  4.018 ns | 0.1033 ns | 0.1578 ns |  4.001 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                  N   | 10.362 ns | 0.2440 ns | 0.3652 ns | 10.350 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                  N   | 18.294 ns | 0.2289 ns | 0.2029 ns | 18.337 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                  N   |  8.353 ns | 0.0913 ns | 0.0763 ns |  8.344 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                  N   | 14.701 ns | 0.2235 ns | 0.1866 ns | 14.669 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** | ** The (...)dog.  [41]** |  **4.748 ns** | **0.0905 ns** | **0.0847 ns** |  **4.747 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  3.422 ns | 0.0552 ns | 0.0516 ns |  3.410 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  9.845 ns | 0.1943 ns | 0.1817 ns |  9.775 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] | 18.078 ns | 0.2706 ns | 0.2531 ns | 18.082 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  8.336 ns | 0.0946 ns | 0.0885 ns |  8.344 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] | 14.435 ns | 0.1905 ns | 0.1688 ns | 14.428 ns |         - |
|                Equals | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  4.846 ns | 0.0571 ns | 0.0534 ns |  4.845 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  3.487 ns | 0.1037 ns | 0.1674 ns |  3.461 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  9.916 ns | 0.2201 ns | 0.2059 ns |  9.916 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] | 17.970 ns | 0.1969 ns | 0.1745 ns | 17.919 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  8.330 ns | 0.0876 ns | 0.0777 ns |  8.357 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] | 14.432 ns | 0.1998 ns | 0.1869 ns | 14.419 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** Y  ** |  **4.727 ns** | **0.0795 ns** | **0.0744 ns** |  **4.742 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                  Y   |  4.453 ns | 0.0394 ns | 0.0329 ns |  4.449 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                  Y   |  9.769 ns | 0.1057 ns | 0.0989 ns |  9.731 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                  Y   | 19.082 ns | 0.2329 ns | 0.2178 ns | 19.122 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                  Y   |  8.502 ns | 0.1434 ns | 0.1341 ns |  8.471 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                  Y   | 14.742 ns | 0.2300 ns | 0.2152 ns | 14.706 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                ** Yx  ** |  **4.722 ns** | **0.0546 ns** | **0.0511 ns** |  **4.734 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                 Yx   |  4.724 ns | 0.0575 ns | 0.0510 ns |  4.709 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                 Yx   | 10.450 ns | 0.2104 ns | 0.1968 ns | 10.348 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                 Yx   | 19.694 ns | 0.2596 ns | 0.2301 ns | 19.623 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                 Yx   |  8.466 ns | 0.1500 ns | 0.1330 ns |  8.466 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                 Yx   | 17.243 ns | 0.2634 ns | 0.2464 ns | 17.133 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** n  ** |  **4.724 ns** | **0.0801 ns** | **0.0749 ns** |  **4.730 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                  n   |  3.435 ns | 0.0801 ns | 0.0749 ns |  3.402 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                  n   |  9.772 ns | 0.1044 ns | 0.0976 ns |  9.752 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                  n   | 18.394 ns | 0.3513 ns | 0.3286 ns | 18.264 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                  n   |  8.344 ns | 0.1117 ns | 0.0991 ns |  8.320 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                  n   | 14.546 ns | 0.1124 ns | 0.0878 ns | 14.536 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** y  ** |  **4.811 ns** | **0.1311 ns** | **0.1457 ns** |  **4.785 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                  y   |  4.253 ns | 0.1202 ns | 0.2073 ns |  4.232 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                  y   | 10.059 ns | 0.2395 ns | 0.5104 ns |  9.910 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                  y   | 18.308 ns | 0.2758 ns | 0.2445 ns | 18.256 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                  y   |  8.388 ns | 0.1368 ns | 0.1280 ns |  8.368 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                  y   | 14.723 ns | 0.2309 ns | 0.2160 ns | 14.685 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                ** yx  ** |  **4.720 ns** | **0.0563 ns** | **0.0499 ns** |  **4.726 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                 yx   |  3.407 ns | 0.0435 ns | 0.0386 ns |  3.402 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                 yx   | 10.057 ns | 0.1852 ns | 0.1732 ns |  9.982 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                 yx   | 19.595 ns | 0.1445 ns | 0.1206 ns | 19.601 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                 yx   |  8.519 ns | 0.1353 ns | 0.1266 ns |  8.531 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                 yx   | 15.946 ns | 0.3276 ns | 0.3064 ns | 15.880 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |          **Hello World** | **11.089 ns** | **0.1625 ns** | **0.1520 ns** | **11.053 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |          Hello World | 13.755 ns | 0.2561 ns | 0.2138 ns | 13.671 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |          Hello World | 16.746 ns | 0.3461 ns | 0.3238 ns | 16.618 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |          Hello World | 22.407 ns | 0.3004 ns | 0.2810 ns | 22.367 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |          Hello World | 18.561 ns | 0.3528 ns | 0.3300 ns | 18.649 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |          Hello World | 24.461 ns | 0.4301 ns | 0.4023 ns | 24.245 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |         **Hello World ** |  **4.737 ns** | **0.0922 ns** | **0.0817 ns** |  **4.725 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |         Hello World  |  4.760 ns | 0.0668 ns | 0.0625 ns |  4.763 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |         Hello World  |  9.816 ns | 0.1275 ns | 0.1193 ns |  9.824 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |         Hello World  | 23.291 ns | 0.4619 ns | 0.4321 ns | 23.230 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |         Hello World  |  8.363 ns | 0.1304 ns | 0.1156 ns |  8.348 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |         Hello World  | 23.537 ns | 0.4155 ns | 0.3887 ns | 23.400 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |          **Hello world** | **11.077 ns** | **0.1502 ns** | **0.1405 ns** | **11.049 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |          Hello world | 13.940 ns | 0.2691 ns | 0.2517 ns | 13.955 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |          Hello world | 16.410 ns | 0.2109 ns | 0.1973 ns | 16.396 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |          Hello world | 22.808 ns | 0.3078 ns | 0.2879 ns | 22.682 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |          Hello world | 18.562 ns | 0.2361 ns | 0.2093 ns | 18.505 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |          Hello world | 22.026 ns | 0.2257 ns | 0.2111 ns | 22.089 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |         **Hello world ** |  **4.721 ns** | **0.0825 ns** | **0.0772 ns** |  **4.724 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |         Hello world  |  3.411 ns | 0.0882 ns | 0.0825 ns |  3.407 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |         Hello world  |  9.821 ns | 0.1286 ns | 0.1140 ns |  9.791 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |         Hello world  | 23.659 ns | 0.3917 ns | 0.3664 ns | 23.623 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |         Hello world  |  9.409 ns | 0.1431 ns | 0.1338 ns |  9.379 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |         Hello world  | 23.601 ns | 0.3163 ns | 0.2959 ns | 23.657 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** | **The q(...) dog. [39]** |  **5.150 ns** | **0.1366 ns** | **0.2665 ns** |  **5.177 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  3.399 ns | 0.1150 ns | 0.3374 ns |  3.337 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  9.803 ns | 0.1864 ns | 0.1743 ns |  9.762 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] | 15.453 ns | 0.3333 ns | 0.3274 ns | 15.366 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  8.339 ns | 0.1113 ns | 0.1041 ns |  8.326 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] | 11.735 ns | 0.1102 ns | 0.0977 ns | 11.747 ns |         - |
|                Equals | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  4.700 ns | 0.0628 ns | 0.0557 ns |  4.706 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  3.441 ns | 0.0885 ns | 0.0828 ns |  3.431 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  9.986 ns | 0.2321 ns | 0.2763 ns |  9.977 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] | 15.384 ns | 0.2361 ns | 0.2093 ns | 15.344 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |  8.354 ns | 0.1076 ns | 0.1007 ns |  8.349 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] | 11.525 ns | 0.1043 ns | 0.0871 ns | 11.527 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                    **y** |  **4.724 ns** | **0.0934 ns** | **0.0874 ns** |  **4.729 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase |          Hello world |                    y |  3.409 ns | 0.0513 ns | 0.0455 ns |  3.412 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase |          Hello world |                    y |  9.831 ns | 0.1683 ns | 0.1574 ns |  9.780 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase |          Hello world |                    y | 14.566 ns | 0.1986 ns | 0.1761 ns | 14.521 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase |          Hello world |                    y |  9.475 ns | 0.2168 ns | 0.2028 ns |  9.369 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase |          Hello world |                    y | 11.581 ns | 0.2672 ns | 0.4680 ns | 11.596 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                     **** |  **4.916 ns** | **0.1337 ns** | **0.3793 ns** |  **4.758 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  3.428 ns | 0.0657 ns | 0.0615 ns |  3.421 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  9.852 ns | 0.2135 ns | 0.1997 ns |  9.736 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                      | 14.551 ns | 0.2651 ns | 0.2480 ns | 14.427 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  8.405 ns | 0.1568 ns | 0.1467 ns |  8.401 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                      | 10.426 ns | 0.1636 ns | 0.1530 ns | 10.413 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** N  ** |  **6.120 ns** | **0.2692 ns** | **0.7895 ns** |  **5.646 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   |  3.835 ns | 0.1106 ns | 0.2473 ns |  3.863 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   | 10.411 ns | 0.2623 ns | 0.7733 ns | 10.096 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   | 18.374 ns | 0.3697 ns | 0.3458 ns | 18.180 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   |  8.357 ns | 0.1111 ns | 0.0985 ns |  8.348 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   | 14.816 ns | 0.3300 ns | 0.3668 ns | 14.664 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** |  **4.736 ns** | **0.0793 ns** | **0.0742 ns** |  **4.759 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  4.029 ns | 0.0573 ns | 0.0536 ns |  4.016 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  9.807 ns | 0.1495 ns | 0.1398 ns |  9.771 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 38.795 ns | 0.6163 ns | 0.5765 ns | 38.629 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  8.315 ns | 0.1065 ns | 0.0944 ns |  8.300 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 38.376 ns | 0.5793 ns | 0.5419 ns | 38.251 ns |         - |
|                Equals | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  4.702 ns | 0.0697 ns | 0.0582 ns |  4.696 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  3.412 ns | 0.0639 ns | 0.0533 ns |  3.398 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  9.823 ns | 0.1762 ns | 0.1648 ns |  9.777 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 39.090 ns | 0.6499 ns | 0.6079 ns | 38.841 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  8.327 ns | 0.1218 ns | 0.1080 ns |  8.307 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 38.343 ns | 0.4945 ns | 0.4626 ns | 38.341 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** Y  ** |  **4.870 ns** | **0.1179 ns** | **0.1103 ns** |  **4.865 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   |  3.467 ns | 0.0646 ns | 0.0604 ns |  3.465 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   |  9.886 ns | 0.1583 ns | 0.1481 ns |  9.899 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   | 18.405 ns | 0.2928 ns | 0.2739 ns | 18.343 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   |  8.346 ns | 0.1197 ns | 0.1062 ns |  8.311 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   | 14.753 ns | 0.2514 ns | 0.2229 ns | 14.633 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** Yx  ** |  **4.746 ns** | **0.1002 ns** | **0.0937 ns** |  **4.755 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  4.244 ns | 0.0806 ns | 0.0754 ns |  4.234 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  9.820 ns | 0.1671 ns | 0.1563 ns |  9.762 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   | 19.630 ns | 0.2447 ns | 0.2169 ns | 19.610 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  8.420 ns | 0.1363 ns | 0.1275 ns |  8.435 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   | 15.860 ns | 0.3359 ns | 0.3142 ns | 15.743 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** n  ** |  **4.698 ns** | **0.0796 ns** | **0.0744 ns** |  **4.685 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  3.400 ns | 0.0661 ns | 0.0618 ns |  3.379 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  9.873 ns | 0.2291 ns | 0.2250 ns |  9.766 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   | 18.415 ns | 0.3001 ns | 0.2808 ns | 18.337 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  8.384 ns | 0.1486 ns | 0.1390 ns |  8.353 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   | 14.722 ns | 0.3021 ns | 0.2826 ns | 14.567 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** y  ** |  **4.728 ns** | **0.0647 ns** | **0.0605 ns** |  **4.727 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  3.476 ns | 0.0665 ns | 0.0555 ns |  3.463 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  9.816 ns | 0.1811 ns | 0.1694 ns |  9.751 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   | 18.358 ns | 0.3389 ns | 0.2830 ns | 18.382 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  8.388 ns | 0.1970 ns | 0.1843 ns |  8.297 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   | 14.782 ns | 0.2894 ns | 0.2707 ns | 14.666 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** yx  ** |  **4.700 ns** | **0.0668 ns** | **0.0625 ns** |  **4.690 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  3.397 ns | 0.0511 ns | 0.0427 ns |  3.386 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  9.795 ns | 0.1919 ns | 0.1701 ns |  9.710 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   | 19.644 ns | 0.2564 ns | 0.2398 ns | 19.675 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  8.423 ns | 0.1686 ns | 0.1577 ns |  8.423 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   | 15.877 ns | 0.2367 ns | 0.2214 ns | 15.920 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello World** |  **4.724 ns** | **0.0821 ns** | **0.0727 ns** |  **4.707 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  3.424 ns | 0.0504 ns | 0.0447 ns |  3.424 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  9.785 ns | 0.1394 ns | 0.1304 ns |  9.784 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World | 15.445 ns | 0.2860 ns | 0.2675 ns | 15.419 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  8.399 ns | 0.1639 ns | 0.1533 ns |  8.366 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World | 11.820 ns | 0.2375 ns | 0.2222 ns | 11.718 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello World ** |  **5.139 ns** | **0.1348 ns** | **0.1933 ns** |  **5.129 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  3.948 ns | 0.1122 ns | 0.2317 ns |  3.897 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  9.996 ns | 0.2290 ns | 0.2637 ns | 10.012 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  | 16.740 ns | 0.2611 ns | 0.2442 ns | 16.713 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  8.363 ns | 0.1036 ns | 0.0918 ns |  8.335 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  | 12.881 ns | 0.1325 ns | 0.1107 ns | 12.859 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello world** |  **4.715 ns** | **0.0759 ns** | **0.0710 ns** |  **4.754 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world |  3.423 ns | 0.0905 ns | 0.0889 ns |  3.388 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world |  9.794 ns | 0.1442 ns | 0.1349 ns |  9.757 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world | 15.316 ns | 0.2248 ns | 0.1993 ns | 15.234 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world |  8.334 ns | 0.1045 ns | 0.0927 ns |  8.337 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world | 11.600 ns | 0.1562 ns | 0.1462 ns | 11.574 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello world ** |  **5.132 ns** | **0.1306 ns** | **0.1398 ns** |  **5.165 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  |  3.843 ns | 0.1099 ns | 0.1429 ns |  3.826 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  | 11.052 ns | 0.2594 ns | 0.5960 ns | 10.863 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  | 16.717 ns | 0.2207 ns | 0.1956 ns | 16.715 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  |  8.379 ns | 0.1451 ns | 0.1358 ns |  8.340 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  | 12.989 ns | 0.2342 ns | 0.2190 ns | 12.948 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **26.348 ns** | **0.3890 ns** | **0.3639 ns** | **26.324 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 28.734 ns | 0.2691 ns | 0.2247 ns | 28.697 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 30.564 ns | 0.6192 ns | 0.6359 ns | 30.289 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 36.418 ns | 0.5024 ns | 0.4700 ns | 36.313 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 32.547 ns | 0.4093 ns | 0.3418 ns | 32.436 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 35.728 ns | 0.5120 ns | 0.4539 ns | 35.541 ns |         - |
|                Equals | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 26.298 ns | 0.3134 ns | 0.2932 ns | 26.274 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 28.758 ns | 0.4045 ns | 0.3378 ns | 28.671 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 30.224 ns | 0.3688 ns | 0.3269 ns | 30.189 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 36.214 ns | 0.4734 ns | 0.4428 ns | 36.041 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 32.905 ns | 0.6379 ns | 0.5967 ns | 32.649 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 35.753 ns | 0.3856 ns | 0.3418 ns | 35.644 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                    **y** |  **4.771 ns** | **0.0898 ns** | **0.0840 ns** |  **4.793 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  3.443 ns | 0.0809 ns | 0.0756 ns |  3.453 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  9.799 ns | 0.0864 ns | 0.0765 ns |  9.776 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                    y | 15.076 ns | 0.2168 ns | 0.2028 ns | 15.016 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  9.013 ns | 0.1924 ns | 0.1607 ns |  8.986 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                    y | 11.888 ns | 0.2642 ns | 0.3341 ns | 11.952 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                     **** |  **5.725 ns** | **0.1495 ns** | **0.1399 ns** |  **5.706 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  4.184 ns | 0.1718 ns | 0.5065 ns |  4.046 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  9.808 ns | 0.1943 ns | 0.1817 ns |  9.769 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                      | 13.811 ns | 0.2982 ns | 0.2928 ns | 13.714 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  8.399 ns | 0.1668 ns | 0.1560 ns |  8.350 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                      |  9.817 ns | 0.2118 ns | 0.1982 ns |  9.747 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** N  ** |  **4.720 ns** | **0.0601 ns** | **0.0562 ns** |  **4.701 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   |  3.412 ns | 0.0802 ns | 0.0670 ns |  3.391 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   |  9.827 ns | 0.1855 ns | 0.1735 ns |  9.805 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   | 19.053 ns | 0.2613 ns | 0.2445 ns | 18.975 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   |  8.368 ns | 0.1304 ns | 0.1220 ns |  8.387 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  N   | 14.671 ns | 0.1729 ns | 0.1533 ns | 14.611 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** |  **4.736 ns** | **0.0768 ns** | **0.0718 ns** |  **4.708 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  3.419 ns | 0.0632 ns | 0.0592 ns |  3.407 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  9.816 ns | 0.1634 ns | 0.1528 ns |  9.837 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 39.116 ns | 0.5954 ns | 0.5569 ns | 39.176 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  8.374 ns | 0.1378 ns | 0.1289 ns |  8.337 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 38.298 ns | 0.6081 ns | 0.5688 ns | 38.344 ns |         - |
|                Equals | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  4.719 ns | 0.0946 ns | 0.0885 ns |  4.708 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  3.414 ns | 0.0543 ns | 0.0481 ns |  3.409 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  9.907 ns | 0.1897 ns | 0.1775 ns |  9.873 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 38.867 ns | 0.4430 ns | 0.3927 ns | 38.855 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] |  8.386 ns | 0.1703 ns | 0.1593 ns |  8.381 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 39.025 ns | 0.4729 ns | 0.4423 ns | 39.007 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** Y  ** |  **4.901 ns** | **0.0589 ns** | **0.0551 ns** |  **4.890 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   |  3.412 ns | 0.0605 ns | 0.0566 ns |  3.411 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   | 10.747 ns | 0.1627 ns | 0.1522 ns | 10.709 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   | 18.390 ns | 0.3170 ns | 0.2965 ns | 18.239 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   |  8.338 ns | 0.0787 ns | 0.0657 ns |  8.306 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  Y   | 14.687 ns | 0.2548 ns | 0.2258 ns | 14.584 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** Yx  ** |  **4.695 ns** | **0.0684 ns** | **0.0607 ns** |  **4.716 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  3.463 ns | 0.1046 ns | 0.2506 ns |  3.399 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  9.819 ns | 0.0869 ns | 0.0726 ns |  9.818 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   | 19.684 ns | 0.1876 ns | 0.1663 ns | 19.675 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   |  8.380 ns | 0.1595 ns | 0.1492 ns |  8.377 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 Yx   | 16.716 ns | 0.2568 ns | 0.2402 ns | 16.634 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** n  ** |  **4.750 ns** | **0.0931 ns** | **0.0871 ns** |  **4.767 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  3.432 ns | 0.0905 ns | 0.0847 ns |  3.415 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  9.892 ns | 0.2029 ns | 0.1898 ns |  9.875 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   | 18.308 ns | 0.2354 ns | 0.2202 ns | 18.235 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   |  8.415 ns | 0.1103 ns | 0.1032 ns |  8.379 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  n   | 14.689 ns | 0.2819 ns | 0.2637 ns | 14.607 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** y  ** |  **4.713 ns** | **0.0825 ns** | **0.0772 ns** |  **4.723 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  3.388 ns | 0.0511 ns | 0.0427 ns |  3.374 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  9.850 ns | 0.1391 ns | 0.1302 ns |  9.830 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   | 18.384 ns | 0.3430 ns | 0.3208 ns | 18.233 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   |  8.368 ns | 0.1353 ns | 0.1266 ns |  8.391 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                  y   | 14.762 ns | 0.2997 ns | 0.2804 ns | 14.644 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** yx  ** |  **4.703 ns** | **0.0808 ns** | **0.0756 ns** |  **4.681 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  3.423 ns | 0.0842 ns | 0.0747 ns |  3.414 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  9.831 ns | 0.1135 ns | 0.1062 ns |  9.801 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   | 19.732 ns | 0.3328 ns | 0.3113 ns | 19.667 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   |  8.415 ns | 0.1955 ns | 0.1920 ns |  8.384 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                 yx   | 15.848 ns | 0.2360 ns | 0.2207 ns | 15.706 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello World** |  **4.739 ns** | **0.0920 ns** | **0.0861 ns** |  **4.718 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  3.419 ns | 0.0636 ns | 0.0564 ns |  3.414 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  9.840 ns | 0.2051 ns | 0.1918 ns |  9.747 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World | 15.355 ns | 0.1820 ns | 0.1703 ns | 15.355 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World |  8.445 ns | 0.1494 ns | 0.1397 ns |  8.417 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello World | 14.196 ns | 0.6588 ns | 1.9425 ns | 13.379 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello World ** |  **4.997 ns** | **0.1353 ns** | **0.1759 ns** |  **5.005 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  3.430 ns | 0.1025 ns | 0.1052 ns |  3.418 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  9.823 ns | 0.1340 ns | 0.1253 ns |  9.798 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  | 20.002 ns | 0.2517 ns | 0.2355 ns | 19.893 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  |  8.559 ns | 0.1566 ns | 0.1465 ns |  8.533 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello World  | 12.861 ns | 0.1161 ns | 0.1086 ns | 12.861 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello world** |  **4.733 ns** | **0.0726 ns** | **0.0643 ns** |  **4.728 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world |  3.418 ns | 0.0675 ns | 0.0632 ns |  3.413 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world | 10.575 ns | 0.2355 ns | 0.3453 ns | 10.549 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world | 17.660 ns | 0.3918 ns | 0.4511 ns | 17.709 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world |  8.687 ns | 0.2119 ns | 0.5432 ns |  8.570 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |          Hello world | 11.577 ns | 0.1067 ns | 0.0998 ns | 11.634 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello world ** |  **4.735 ns** | **0.0898 ns** | **0.0840 ns** |  **4.740 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  |  3.397 ns | 0.0717 ns | 0.0671 ns |  3.383 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  |  9.832 ns | 0.2039 ns | 0.1908 ns |  9.752 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  | 16.667 ns | 0.2654 ns | 0.2353 ns | 16.553 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  |  8.435 ns | 0.1586 ns | 0.1483 ns |  8.385 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |         Hello world  | 12.883 ns | 0.2370 ns | 0.2217 ns | 12.829 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **26.220 ns** | **0.2702 ns** | **0.2527 ns** | **26.228 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 29.044 ns | 0.5305 ns | 0.4962 ns | 29.214 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 30.376 ns | 0.4392 ns | 0.3893 ns | 30.232 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 36.279 ns | 0.4836 ns | 0.4524 ns | 36.190 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 32.606 ns | 0.4452 ns | 0.3717 ns | 32.484 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 36.085 ns | 0.7391 ns | 0.8511 ns | 35.691 ns |         - |
|                Equals | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 26.192 ns | 0.1984 ns | 0.1855 ns | 26.261 ns |         - |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 28.650 ns | 0.3564 ns | 0.2976 ns | 28.620 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 30.321 ns | 0.3731 ns | 0.3115 ns | 30.312 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 36.377 ns | 0.7298 ns | 0.7168 ns | 36.094 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 32.731 ns | 0.4934 ns | 0.4615 ns | 32.569 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 35.763 ns | 0.4144 ns | 0.3673 ns | 35.674 ns |         - |
|                **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                    **y** |  **4.733 ns** | **0.0631 ns** | **0.0590 ns** |  **4.752 ns** |         **-** |
|         EqualsWithLen | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  3.428 ns | 0.0575 ns | 0.0537 ns |  3.424 ns |         - |
|         TrimEqualityA | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  9.888 ns | 0.1922 ns | 0.1798 ns |  9.891 ns |         - |
|        TrimEqualityAB | OrdinalIgnoreCase | The q(...) dog. [39] |                    y | 15.274 ns | 0.1657 ns | 0.1383 ns | 15.241 ns |         - |
|  TrimEqualityWithLenA | OrdinalIgnoreCase | The q(...) dog. [39] |                    y |  9.246 ns | 0.2195 ns | 0.5343 ns |  9.249 ns |         - |
| TrimEqualityWithLenAB | OrdinalIgnoreCase | The q(...) dog. [39] |                    y | 11.048 ns | 0.3054 ns | 0.8958 ns | 10.746 ns |         - |
