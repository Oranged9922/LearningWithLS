using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using Benchmarking;
namespace Benchmarking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}