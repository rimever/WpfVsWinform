``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.648 (1803/April2018Update/Redstone4)
Intel Core i7-7920HQ CPU 3.10GHz (Kaby Lake), 1 CPU, 2 logical and 2 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3362.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3362.0


```
|                        Method |       Mean |    Error |    StdDev |     Median | Allocated |
|------------------------------ |-----------:|---------:|----------:|-----------:|----------:|
|         LaunchWpfSimpleWindow | 2,372.5 ms | 49.05 ms | 141.51 ms | 2,354.2 ms |    880 KB |
|     LaunchWinFormSimpleWindow |   879.7 ms | 34.25 ms |  99.89 ms |   870.7 ms |    136 KB |
|     LaunchWpfCoreSimpleWindow | 3,013.0 ms | 58.58 ms | 101.06 ms | 3,028.7 ms |    760 KB |
| LaunchWinFormCoreSimpleWindow | 1,942.1 ms | 41.54 ms | 122.47 ms | 2,012.2 ms |    136 KB |
