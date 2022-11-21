// List Patterns
// - C# 11 introduces ordinal list patterns to match an empty list, a list with a specific count
//   items, or lists that start or end with a specific sequence of items using the .. pattern to 
//   represent all other items. The .. pattern may be captured for array types but not for list 
//   types since list types do not support range operators. Any pattern may be used to match items
//   within a list pattern. I'm using a very simple capture pattern here for demo purposes.
//var f = ComputeFibonacci(8);
//Console.WriteLine(string.Join(", ", f));

//List<int> ComputeFibonacci(int count)
//{
//    var fib = new List<int>();

//    for (int i = 0; i < count; i++)
//    {
//        var next = fib switch
//        {
//            [] => 0,                          // Empty List
//            [_] => 1,                         // List With 1 Item
//            [.., var n1, var n] => n1 + n,    // List With At Least 2 Items, Capturing The Last 2 Values
//        };
//        fib.Add(next);
//    }

//    return fib;
//}