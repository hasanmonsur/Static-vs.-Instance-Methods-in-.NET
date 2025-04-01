using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace StaticInstantBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}