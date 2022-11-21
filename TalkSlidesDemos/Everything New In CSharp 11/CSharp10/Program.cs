using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<StaticDelegateBenchmark>();

[MemoryDiagnoser]
public class StaticDelegateBenchmark
{
    private List<int> data = new() { 1, 2, 3, 4, 5 };

    [Benchmark]
    public int LambdaWrapper()
    {
        return data.Where(x => OddOnly(x)).Sum();
    }

    [Benchmark]
    public int StaticMethodGroup()
    {
        return data.Where(OddOnly).Sum();
    }

    static private bool OddOnly(int x) => x % 2 == 1;
}