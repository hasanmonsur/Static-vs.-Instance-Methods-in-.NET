using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace StaticInstantBenchmarks
{
    public class Benchmarks
    {
        private readonly MathOps _instance = new();

        [Benchmark]
        public int InstanceAdd() => _instance.Add(5, 10);

        [Benchmark]
        public int StaticAdd() => MathOps.StaticAdd(5, 10);
    }

    public class MathOps
    {
        public int Add(int a, int b) => a + b;
        public static int StaticAdd(int a, int b) => a + b;
    }
}
