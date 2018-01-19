using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace CSharp.Benchmarks
{
    [ClrJob, CoreJob]
    [BenchmarkCategory("Unary Operators")]
    public class UnaryOperators
    {
        private int _value;

        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark(Description = "i++")]
        public int UnaryIncrement() => _value++;


        [Benchmark(Description = "i--")]
        public int UnaryDecrement() => _value--;
    }
}
