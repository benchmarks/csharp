# csharp
``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192), VM=VMware
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 4 logical cores and 4 physical cores
Frequency=3914064 Hz, Resolution=255.4889 ns, Timer=TSC
  [Host] : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0


```
| Method |  Job | Runtime |      Mean |     Error |    StdDev |
|------- |----- |-------- |----------:|----------:|----------:|
|    i++ |  Clr |     Clr | 0.4583 ns | 0.0136 ns | 0.0127 ns |
|    i-- |  Clr |     Clr | 0.0193 ns | 0.0018 ns | 0.0017 ns |
|    i++ | Core |    Core |        NA |        NA |        NA |
|    i-- | Core |    Core |        NA |        NA |        NA |


