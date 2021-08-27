``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
| Method |        Comparison |                    A |                    B |       Mean |     Error |    StdDev | Allocated |
|------- |------------------ |--------------------- |--------------------- |-----------:|----------:|----------:|----------:|
| **Equals** |           **Ordinal** |                     **** |                     **** |   **4.889 ns** | **0.0662 ns** | **0.0619 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |                 ** N  ** |   **6.829 ns** | **0.0685 ns** | **0.0640 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** | ** The (...)dog.  [41]** |   **6.838 ns** | **0.0664 ns** | **0.0589 ns** |         **-** |
| Equals |           Ordinal |                      |  The (...)dog.  [41] |   6.840 ns | 0.0918 ns | 0.0859 ns |         - |
| **Equals** |           **Ordinal** |                     **** |                 ** Y  ** |   **6.874 ns** | **0.1190 ns** | **0.1114 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |                ** Yx  ** |   **6.924 ns** | **0.1676 ns** | **0.1568 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |                 ** n  ** |   **6.873 ns** | **0.1322 ns** | **0.1236 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |                 ** y  ** |   **6.841 ns** | **0.0942 ns** | **0.0881 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |                ** yx  ** |   **6.825 ns** | **0.1210 ns** | **0.1073 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |          **Hello World** |   **5.193 ns** | **0.0435 ns** | **0.0407 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |         **Hello World ** |   **5.489 ns** | **0.1427 ns** | **0.3010 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |          **Hello world** |   **5.674 ns** | **0.1069 ns** | **0.1000 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** |         **Hello world ** |   **5.683 ns** | **0.1117 ns** | **0.1045 ns** |         **-** |
| **Equals** |           **Ordinal** |                     **** | **The q(...) dog. [39]** |   **5.427 ns** | **0.0952 ns** | **0.0844 ns** |         **-** |
| Equals |           Ordinal |                      | The q(...) dog. [39] |   5.140 ns | 0.0479 ns | 0.0424 ns |         - |
| **Equals** |           **Ordinal** |                     **** |                    **y** |   **6.250 ns** | **0.1067 ns** | **0.0946 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                     **** |   **7.220 ns** | **0.1776 ns** | **0.1974 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                 ** N  ** |  **12.084 ns** | **0.1842 ns** | **0.1723 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** | ** The (...)dog.  [41]** |  **12.570 ns** | **0.2485 ns** | **0.2325 ns** |         **-** |
| Equals |           Ordinal |                  n   |  The (...)dog.  [41] |  13.000 ns | 0.2232 ns | 0.1979 ns |         - |
| **Equals** |           **Ordinal** |                 ** n  ** |                 ** Y  ** |  **13.410 ns** | **0.2688 ns** | **0.2383 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                ** Yx  ** |  **12.705 ns** | **0.2358 ns** | **0.2206 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                 ** n  ** |  **19.228 ns** | **0.3516 ns** | **0.3289 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                 ** y  ** |  **12.471 ns** | **0.1207 ns** | **0.1070 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |                ** yx  ** |  **12.385 ns** | **0.1061 ns** | **0.0992 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |          **Hello World** |   **9.384 ns** | **0.1076 ns** | **0.1006 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |         **Hello World ** |   **9.390 ns** | **0.2164 ns** | **0.2024 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |          **Hello world** |   **9.421 ns** | **0.1537 ns** | **0.1437 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** |         **Hello world ** |   **9.270 ns** | **0.1336 ns** | **0.1250 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** n  ** | **The q(...) dog. [39]** |   **9.433 ns** | **0.1987 ns** | **0.2440 ns** |         **-** |
| Equals |           Ordinal |                  n   | The q(...) dog. [39] |   9.119 ns | 0.2166 ns | 0.1920 ns |         - |
| **Equals** |           **Ordinal** |                 ** n  ** |                    **y** |   **9.114 ns** | **0.1468 ns** | **0.1302 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                     **** |   **7.200 ns** | **0.1698 ns** | **0.1816 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                 ** N  ** |  **11.852 ns** | **0.2048 ns** | **0.1916 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** | ** The (...)dog.  [41]** |  **12.013 ns** | **0.1837 ns** | **0.1629 ns** |         **-** |
| Equals |           Ordinal |                  y   |  The (...)dog.  [41] |  12.541 ns | 0.1673 ns | 0.1565 ns |         - |
| **Equals** |           **Ordinal** |                 ** y  ** |                 ** Y  ** |  **13.689 ns** | **0.3049 ns** | **0.4275 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                ** Yx  ** |  **13.360 ns** | **0.2979 ns** | **0.3873 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                 ** n  ** |  **13.556 ns** | **0.3059 ns** | **0.3005 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                 ** y  ** |  **20.085 ns** | **0.4416 ns** | **0.7131 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |                ** yx  ** |  **18.806 ns** | **0.4088 ns** | **0.4707 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |          **Hello World** |  **10.049 ns** | **0.2376 ns** | **0.4690 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |         **Hello World ** |  **10.126 ns** | **0.2382 ns** | **0.3637 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |          **Hello world** |   **9.748 ns** | **0.2295 ns** | **0.3640 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** |         **Hello world ** |   **9.498 ns** | **0.2277 ns** | **0.2436 ns** |         **-** |
| **Equals** |           **Ordinal** |                 ** y  ** | **The q(...) dog. [39]** |   **9.627 ns** | **0.2294 ns** | **0.3958 ns** |         **-** |
| Equals |           Ordinal |                  y   | The q(...) dog. [39] |   9.404 ns | 0.1489 ns | 0.1320 ns |         - |
| **Equals** |           **Ordinal** |                 ** y  ** |                    **y** |  **15.921 ns** | **0.2535 ns** | **0.2247 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                     **** |   **7.328 ns** | **0.1761 ns** | **0.1647 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                 ** N  ** |  **11.958 ns** | **0.2083 ns** | **0.1846 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** | ** The (...)dog.  [41]** |  **11.989 ns** | **0.2114 ns** | **0.1765 ns** |         **-** |
| Equals |           Ordinal |                 yx   |  The (...)dog.  [41] |  11.830 ns | 0.1388 ns | 0.1230 ns |         - |
| **Equals** |           **Ordinal** |                ** yx  ** |                 ** Y  ** |  **11.854 ns** | **0.1495 ns** | **0.1248 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                ** Yx  ** |  **11.671 ns** | **0.0819 ns** | **0.0766 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                 ** n  ** |  **11.820 ns** | **0.1105 ns** | **0.0980 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                 ** y  ** |  **16.794 ns** | **0.3659 ns** | **0.4757 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |                ** yx  ** |  **23.962 ns** | **0.4683 ns** | **0.4380 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |          **Hello World** |   **9.297 ns** | **0.2161 ns** | **0.2402 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |         **Hello World ** |   **9.160 ns** | **0.1532 ns** | **0.1358 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |          **Hello world** |   **9.149 ns** | **0.1935 ns** | **0.1716 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** |         **Hello world ** |   **9.240 ns** | **0.2192 ns** | **0.1944 ns** |         **-** |
| **Equals** |           **Ordinal** |                ** yx  ** | **The q(...) dog. [39]** |   **9.485 ns** | **0.2203 ns** | **0.2449 ns** |         **-** |
| Equals |           Ordinal |                 yx   | The q(...) dog. [39] |  11.211 ns | 0.6839 ns | 2.0166 ns |         - |
| **Equals** |           **Ordinal** |                ** yx  ** |                    **y** |  **11.272 ns** | **0.0994 ns** | **0.0881 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                     **** |   **5.475 ns** | **0.1440 ns** | **0.1601 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                 ** N  ** |   **9.362 ns** | **0.2226 ns** | **0.4127 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** | ** The (...)dog.  [41]** |   **9.497 ns** | **0.2156 ns** | **0.2214 ns** |         **-** |
| Equals |           Ordinal |          Hello World |  The (...)dog.  [41] |   8.769 ns | 0.2056 ns | 0.2673 ns |         - |
| **Equals** |           **Ordinal** |          **Hello World** |                 ** Y  ** |   **8.757 ns** | **0.1190 ns** | **0.1055 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                ** Yx  ** |   **8.664 ns** | **0.1834 ns** | **0.1715 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                 ** n  ** |   **8.948 ns** | **0.1453 ns** | **0.1359 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                 ** y  ** |   **9.068 ns** | **0.2003 ns** | **0.1874 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |                ** yx  ** |   **8.466 ns** | **0.0679 ns** | **0.0567 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |          **Hello World** |  **54.701 ns** | **0.6008 ns** | **0.5326 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |         **Hello World ** |  **59.580 ns** | **1.2201 ns** | **1.0816 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |          **Hello world** |  **36.252 ns** | **0.7644 ns** | **0.8803 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** |         **Hello world ** |  **37.404 ns** | **0.6653 ns** | **0.6223 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello World** | **The q(...) dog. [39]** |   **8.642 ns** | **0.2064 ns** | **0.1930 ns** |         **-** |
| Equals |           Ordinal |          Hello World | The q(...) dog. [39] |   8.135 ns | 0.1793 ns | 0.1677 ns |         - |
| **Equals** |           **Ordinal** |          **Hello World** |                    **y** |   **8.211 ns** | **0.1765 ns** | **0.1651 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                     **** |   **6.082 ns** | **0.1574 ns** | **0.1616 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                 ** N  ** |   **9.823 ns** | **0.1948 ns** | **0.1727 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** | ** The (...)dog.  [41]** |   **9.841 ns** | **0.2329 ns** | **0.2860 ns** |         **-** |
| Equals |           Ordinal |          Hello world |  The (...)dog.  [41] |   9.720 ns | 0.1802 ns | 0.1686 ns |         - |
| **Equals** |           **Ordinal** |          **Hello world** |                 ** Y  ** |   **9.674 ns** | **0.2217 ns** | **0.1731 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                ** Yx  ** |   **9.478 ns** | **0.2024 ns** | **0.1893 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                 ** n  ** |   **9.471 ns** | **0.1727 ns** | **0.1442 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                 ** y  ** |   **9.308 ns** | **0.2104 ns** | **0.1968 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |                ** yx  ** |   **9.339 ns** | **0.1989 ns** | **0.1861 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |          **Hello World** |  **34.995 ns** | **0.7260 ns** | **0.6791 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |         **Hello World ** |  **34.741 ns** | **0.7205 ns** | **0.7076 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |          **Hello world** |  **56.467 ns** | **1.1549 ns** | **1.1343 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** |         **Hello world ** |  **57.542 ns** | **0.8029 ns** | **0.7510 ns** |         **-** |
| **Equals** |           **Ordinal** |          **Hello world** | **The q(...) dog. [39]** |   **7.345 ns** | **0.1255 ns** | **0.1174 ns** |         **-** |
| Equals |           Ordinal |          Hello world | The q(...) dog. [39] |   7.260 ns | 0.1341 ns | 0.1120 ns |         - |
| **Equals** |           **Ordinal** |          **Hello world** |                    **y** |   **7.320 ns** | **0.1650 ns** | **0.1543 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                     **** |   **5.387 ns** | **0.0818 ns** | **0.0765 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** N  ** |   **8.819 ns** | **0.0949 ns** | **0.0887 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** | **177.478 ns** | **3.3528 ns** | **3.1362 ns** |         **-** |
| Equals |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] |  52.403 ns | 0.6564 ns | 0.6140 ns |         - |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** Y  ** |   **9.293 ns** | **0.1457 ns** | **0.1363 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** Yx  ** |   **8.728 ns** | **0.1247 ns** | **0.1167 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** n  ** |   **8.905 ns** | **0.1616 ns** | **0.1350 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** y  ** |   **8.836 ns** | **0.1508 ns** | **0.1411 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** yx  ** |   **8.626 ns** | **0.2002 ns** | **0.1966 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello World** |   **6.975 ns** | **0.0969 ns** | **0.0907 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello World ** |   **7.214 ns** | **0.1575 ns** | **0.1473 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello world** |   **7.386 ns** | **0.1339 ns** | **0.1253 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello world ** |   **7.608 ns** | **0.1125 ns** | **0.1052 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **193.603 ns** | **3.0798 ns** | **2.8809 ns** |         **-** |
| Equals |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] |  58.632 ns | 1.0155 ns | 0.9499 ns |         - |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                    **y** |   **8.561 ns** | **0.2141 ns** | **0.1898 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                     **** |   **6.190 ns** | **0.1432 ns** | **0.2098 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** N  ** |   **9.949 ns** | **0.2379 ns** | **0.3976 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** |  **59.186 ns** | **0.5223 ns** | **0.4362 ns** |         **-** |
| Equals |           Ordinal | The q(...) dog. [39] |  The (...)dog.  [41] | 197.314 ns | 3.9361 ns | 6.8938 ns |         - |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** Y  ** |   **9.710 ns** | **0.2296 ns** | **0.3507 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** Yx  ** |   **9.554 ns** | **0.2216 ns** | **0.2552 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** n  ** |   **9.506 ns** | **0.2224 ns** | **0.2380 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                 ** y  ** |   **9.390 ns** | **0.1701 ns** | **0.1508 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                ** yx  ** |   **9.466 ns** | **0.2155 ns** | **0.2016 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello World** |   **7.371 ns** | **0.1780 ns** | **0.2186 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello World ** |   **7.498 ns** | **0.1792 ns** | **0.1917 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |          **Hello world** |   **7.551 ns** | **0.1653 ns** | **0.1968 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |         **Hello world ** |   **7.493 ns** | **0.1798 ns** | **0.2274 ns** |         **-** |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** | **The q(...) dog. [39]** |  **51.342 ns** | **1.0408 ns** | **0.9735 ns** |         **-** |
| Equals |           Ordinal | The q(...) dog. [39] | The q(...) dog. [39] | 179.085 ns | 3.6154 ns | 5.6287 ns |         - |
| **Equals** |           **Ordinal** | **The q(...) dog. [39]** |                    **y** |   **7.266 ns** | **0.1416 ns** | **0.1324 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                     **** |   **5.010 ns** | **0.1102 ns** | **0.0977 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** N  ** |   **7.186 ns** | **0.1609 ns** | **0.1505 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** | ** The (...)dog.  [41]** |   **7.243 ns** | **0.1202 ns** | **0.1124 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                      |  The (...)dog.  [41] |   7.072 ns | 0.1505 ns | 0.1334 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** Y  ** |   **7.518 ns** | **0.1047 ns** | **0.0928 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                ** Yx  ** |   **7.168 ns** | **0.1512 ns** | **0.1414 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** n  ** |   **7.355 ns** | **0.1821 ns** | **0.1703 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                 ** y  ** |   **7.657 ns** | **0.1828 ns** | **0.2563 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                ** yx  ** |   **8.515 ns** | **0.1919 ns** | **0.1498 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |          **Hello World** |   **6.286 ns** | **0.1651 ns** | **0.2088 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |         **Hello World ** |   **6.179 ns** | **0.1563 ns** | **0.1800 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |          **Hello world** |   **6.148 ns** | **0.1370 ns** | **0.1346 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** |         **Hello world ** |   **5.923 ns** | **0.1483 ns** | **0.1457 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                     **** | **The q(...) dog. [39]** |   **5.988 ns** | **0.1403 ns** | **0.1560 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                      | The q(...) dog. [39] |   6.066 ns | 0.1597 ns | 0.1640 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                     **** |                    **y** |   **5.928 ns** | **0.1545 ns** | **0.1587 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                     **** |   **7.900 ns** | **0.1413 ns** | **0.1180 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** N  ** |  **19.741 ns** | **0.4257 ns** | **0.6874 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** | ** The (...)dog.  [41]** |  **12.744 ns** | **0.1561 ns** | **0.1460 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                  n   |  The (...)dog.  [41] |  12.708 ns | 0.1527 ns | 0.1429 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** Y  ** |  **12.431 ns** | **0.1993 ns** | **0.1864 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                ** Yx  ** |  **12.448 ns** | **0.2821 ns** | **0.3358 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** n  ** |  **19.089 ns** | **0.4175 ns** | **0.5853 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                 ** y  ** |  **12.305 ns** | **0.2643 ns** | **0.3528 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                ** yx  ** |  **11.932 ns** | **0.2222 ns** | **0.1855 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |          **Hello World** |   **9.415 ns** | **0.2242 ns** | **0.3621 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |         **Hello World ** |   **9.177 ns** | **0.2186 ns** | **0.2518 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |          **Hello world** |   **9.155 ns** | **0.2065 ns** | **0.1932 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |         **Hello world ** |   **9.182 ns** | **0.1653 ns** | **0.1465 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** | **The q(...) dog. [39]** |   **9.237 ns** | **0.2122 ns** | **0.2270 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                  n   | The q(...) dog. [39] |   9.634 ns | 0.2176 ns | 0.4543 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                 ** n  ** |                    **y** |   **9.072 ns** | **0.1873 ns** | **0.1752 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                     **** |   **7.192 ns** | **0.1620 ns** | **0.1515 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** N  ** |  **12.354 ns** | **0.1924 ns** | **0.1705 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** | ** The (...)dog.  [41]** |  **12.846 ns** | **0.1323 ns** | **0.1105 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                  y   |  The (...)dog.  [41] |  12.732 ns | 0.2852 ns | 0.3051 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** Y  ** |  **19.255 ns** | **0.2958 ns** | **0.2767 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                ** Yx  ** |  **18.258 ns** | **0.2538 ns** | **0.2374 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** n  ** |  **12.450 ns** | **0.1782 ns** | **0.1667 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                 ** y  ** |  **19.148 ns** | **0.4085 ns** | **0.4371 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                ** yx  ** |  **17.749 ns** | **0.2230 ns** | **0.1977 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |          **Hello World** |   **9.376 ns** | **0.0950 ns** | **0.0889 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |         **Hello World ** |   **9.470 ns** | **0.1921 ns** | **0.1797 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |          **Hello world** |   **9.471 ns** | **0.2260 ns** | **0.2690 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |         **Hello world ** |   **9.260 ns** | **0.1543 ns** | **0.1443 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** | **The q(...) dog. [39]** |   **9.370 ns** | **0.2021 ns** | **0.1891 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                  y   | The q(...) dog. [39] |   9.043 ns | 0.2229 ns | 0.2567 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                 ** y  ** |                    **y** |  **15.329 ns** | **0.3406 ns** | **0.4055 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                     **** |   **7.233 ns** | **0.1758 ns** | **0.1644 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** N  ** |  **11.821 ns** | **0.1627 ns** | **0.1522 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** | ** The (...)dog.  [41]** |  **12.457 ns** | **0.2828 ns** | **0.4486 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                 yx   |  The (...)dog.  [41] |  11.966 ns | 0.0974 ns | 0.0911 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** Y  ** |  **16.850 ns** | **0.3289 ns** | **0.3076 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                ** Yx  ** |  **24.189 ns** | **0.2664 ns** | **0.2492 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** n  ** |  **11.907 ns** | **0.1688 ns** | **0.1579 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                 ** y  ** |  **16.552 ns** | **0.1511 ns** | **0.1261 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                ** yx  ** |  **23.676 ns** | **0.2723 ns** | **0.2414 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |          **Hello World** |   **9.352 ns** | **0.1933 ns** | **0.1808 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |         **Hello World ** |   **9.061 ns** | **0.1673 ns** | **0.1565 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |          **Hello world** |   **8.950 ns** | **0.1719 ns** | **0.1608 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |         **Hello world ** |   **9.155 ns** | **0.1135 ns** | **0.1062 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** | **The q(...) dog. [39]** |   **9.521 ns** | **0.1632 ns** | **0.1526 ns** |         **-** |
| Equals | OrdinalIgnoreCase |                 yx   | The q(...) dog. [39] |   9.800 ns | 0.1611 ns | 0.1428 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |                ** yx  ** |                    **y** |  **12.037 ns** | **0.1788 ns** | **0.1585 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                     **** |   **5.537 ns** | **0.1357 ns** | **0.1270 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** N  ** |   **8.952 ns** | **0.0850 ns** | **0.0795 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** | ** The (...)dog.  [41]** |   **8.978 ns** | **0.0981 ns** | **0.0918 ns** |         **-** |
| Equals | OrdinalIgnoreCase |          Hello World |  The (...)dog.  [41] |   8.904 ns | 0.0981 ns | 0.0918 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** Y  ** |   **8.860 ns** | **0.1446 ns** | **0.1353 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                ** Yx  ** |   **8.891 ns** | **0.1911 ns** | **0.1787 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** n  ** |   **8.850 ns** | **0.2083 ns** | **0.2229 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                 ** y  ** |   **8.674 ns** | **0.1630 ns** | **0.1361 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                ** yx  ** |   **9.089 ns** | **0.2139 ns** | **0.2999 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |          **Hello World** |  **55.944 ns** | **1.1457 ns** | **1.1766 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |         **Hello World ** |  **56.487 ns** | **1.0374 ns** | **0.9196 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |          **Hello world** |  **55.183 ns** | **1.1265 ns** | **1.4648 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |         **Hello world ** |  **55.688 ns** | **1.1407 ns** | **1.0112 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** | **The q(...) dog. [39]** |   **7.306 ns** | **0.1790 ns** | **0.3318 ns** |         **-** |
| Equals | OrdinalIgnoreCase |          Hello World | The q(...) dog. [39] |   7.070 ns | 0.1705 ns | 0.1511 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |          **Hello World** |                    **y** |   **7.026 ns** | **0.1282 ns** | **0.1001 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                     **** |   **5.264 ns** | **0.0660 ns** | **0.0617 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** N  ** |   **8.708 ns** | **0.1403 ns** | **0.1095 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** | ** The (...)dog.  [41]** |   **9.048 ns** | **0.1848 ns** | **0.1543 ns** |         **-** |
| Equals | OrdinalIgnoreCase |          Hello world |  The (...)dog.  [41] |  12.796 ns | 0.9713 ns | 2.8639 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** Y  ** |   **9.381 ns** | **0.2034 ns** | **0.1699 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                ** Yx  ** |   **9.445 ns** | **0.1315 ns** | **0.1166 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** n  ** |  **10.265 ns** | **0.2393 ns** | **0.3795 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                 ** y  ** |   **9.228 ns** | **0.1877 ns** | **0.1756 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                ** yx  ** |   **9.214 ns** | **0.2197 ns** | **0.3289 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |          **Hello World** |  **56.348 ns** | **1.1216 ns** | **1.4185 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |         **Hello World ** |  **56.178 ns** | **0.7619 ns** | **0.6754 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |          **Hello world** |  **55.109 ns** | **0.9355 ns** | **0.7812 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |         **Hello world ** |  **55.222 ns** | **0.6599 ns** | **0.5850 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** | **The q(...) dog. [39]** |   **7.238 ns** | **0.1740 ns** | **0.2004 ns** |         **-** |
| Equals | OrdinalIgnoreCase |          Hello world | The q(...) dog. [39] |   7.170 ns | 0.1612 ns | 0.1429 ns |         - |
| **Equals** | **OrdinalIgnoreCase** |          **Hello world** |                    **y** |   **7.083 ns** | **0.1756 ns** | **0.1879 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                     **** |   **5.291 ns** | **0.1213 ns** | **0.1013 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** N  ** |   **8.637 ns** | **0.1265 ns** | **0.1122 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** | **175.914 ns** | **2.2916 ns** | **2.0314 ns** |         **-** |
| Equals | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 180.731 ns | 3.4313 ns | 3.5237 ns |         - |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** Y  ** |   **9.095 ns** | **0.1771 ns** | **0.1382 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** Yx  ** |   **9.569 ns** | **0.2194 ns** | **0.2253 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** n  ** |  **10.194 ns** | **0.2347 ns** | **0.2305 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** y  ** |   **9.928 ns** | **0.2263 ns** | **0.3172 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** yx  ** |   **9.938 ns** | **0.1115 ns** | **0.0988 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello World** |   **7.945 ns** | **0.1845 ns** | **0.1725 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello World ** |   **8.019 ns** | **0.1893 ns** | **0.3110 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello world** |   **7.716 ns** | **0.1519 ns** | **0.1421 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello world ** |   **7.742 ns** | **0.1276 ns** | **0.1193 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **190.182 ns** | **2.4555 ns** | **2.1767 ns** |         **-** |
| Equals | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 188.179 ns | 2.5258 ns | 2.3626 ns |         - |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                    **y** |   **7.749 ns** | **0.1811 ns** | **0.1860 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                     **** |   **5.692 ns** | **0.1261 ns** | **0.1118 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** N  ** |   **9.227 ns** | **0.1645 ns** | **0.1539 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | ** The (...)dog.  [41]** | **184.507 ns** | **2.5260 ns** | **2.3628 ns** |         **-** |
| Equals | OrdinalIgnoreCase | The q(...) dog. [39] |  The (...)dog.  [41] | 184.904 ns | 2.8721 ns | 2.3984 ns |         - |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** Y  ** |   **9.141 ns** | **0.1883 ns** | **0.1761 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** Yx  ** |   **9.086 ns** | **0.1767 ns** | **0.1653 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** n  ** |   **9.059 ns** | **0.2080 ns** | **0.1737 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                 ** y  ** |   **8.811 ns** | **0.1972 ns** | **0.1845 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                ** yx  ** |   **8.880 ns** | **0.1972 ns** | **0.1844 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello World** |   **7.266 ns** | **0.1219 ns** | **0.1081 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello World ** |   **7.127 ns** | **0.0846 ns** | **0.0791 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |          **Hello world** |   **7.170 ns** | **0.1383 ns** | **0.1294 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |         **Hello world ** |   **7.425 ns** | **0.1038 ns** | **0.0920 ns** |         **-** |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** | **The q(...) dog. [39]** | **177.484 ns** | **2.8853 ns** | **2.6989 ns** |         **-** |
| Equals | OrdinalIgnoreCase | The q(...) dog. [39] | The q(...) dog. [39] | 177.847 ns | 2.8613 ns | 2.6765 ns |         - |
| **Equals** | **OrdinalIgnoreCase** | **The q(...) dog. [39]** |                    **y** |   **7.206 ns** | **0.1457 ns** | **0.1292 ns** |         **-** |
