using BenchmarkDotNet.Attributes;

namespace Benchmarking
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        public _12_LinqLearner.Tasks LinqLearner { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            LinqLearner = new();
        }

        [Benchmark]
        public void LinqLearnerLINQ()
        {
            LinqLearner.GetProjectsByNumberOfEmployeesLINQ();
        }

        [Benchmark]
        public void LinqLearnerNOTLINQ()
        {
            LinqLearner.GetProjectsByNumberOfEmployeesNOTLINQ();
        }
    }
}