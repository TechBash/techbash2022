// Delegate Caching For Static Methods
// - C# 11 includes a relatively small performance improvement for static method
//   groups. In older language versions, the compiler would cache the lambda wrapper
//   but not the static wrapper. This is fixed in C# 11. Run this benchmark code and
//   compare against the CSharp10 project code to see the different in speed and 
//   memory allocation.
//   This is most significant since IDEs will recommend switch to a method group if 
//   you use a lambda wrapper, inadvertently recommending a slightly slower execution.
//static bool OddsOnly(int x) => x % 2 == 1;

//var data = new List<int> { 1, 2, 3, 4, 5 };

//var sum = data.Where(OddsOnly).Sum();  // This is a static method group invocation.
//Console.WriteLine(sum);


// Prove It!
//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkRunner.Run<StaticDelegateBenchmark>();

//[MemoryDiagnoser]
//public class StaticDelegateBenchmark
//{
//    private List<int> data = new() { 1, 2, 3, 4, 5 };

//    [Benchmark]
//    public int LambdaWrapper()
//    {
//        return data.Where(x => OddOnly(x)).Sum();
//    }

//    [Benchmark]
//    public int StaticMethodGroup()
//    {
//        return data.Where(OddOnly).Sum();
//    }

//    static private bool OddOnly(int x) => x % 2 == 1;
//}