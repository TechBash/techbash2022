// Static Abstract Interface Methods
// - C# 11 in combination with .Net 7 introduces a new abstraction. Types can now specify a
//   static method signature which must be implemented by implementing types. This has great
//   potential for factories and likely many new design patterns not yet established.
//using System.Numerics;

//var x = GenericParseHelper<MyGuid>("7e884d4e-d44c-4f15-9739-4cdecf7a6208");
//Console.WriteLine(x.Value);

//T GenericParseHelper<T>(string s) where T : IParsable<T>
//{
//    return T.Parse(s);
//}

//interface IParsable<TSelf> where TSelf : IParsable<TSelf>
//{
//    static abstract TSelf Parse(string s);
//}

//class MyGuid : IParsable<MyGuid>
//{
//    public Guid Value { get; init; }

//    public static MyGuid Parse(string s)
//        => new MyGuid { Value = Guid.Parse(s) };
//}

// Generic Math
// - The leading use case of static abstract interface methods is thew new INumber<T> interface and 
//   related "child" interfaces which allow for generic math. Remember, in C# operators are just
//   static methods and now they can be defined in an interface to make generic math possible.
//using System.Numerics;

//var result = GenericMin(2, 1);
//Console.WriteLine(result);

//T GenericMin<T>(T a, T b) where T : INumber<T> 
//{
//    if (a < b)
//    {
//        return a;
//    }

//    return b;
//}


// Checked Operators
// - C# 11 allows you to overload checked operators to round out functionality for generic math.

// Numeric IntPtr
// - Generic math also makes it possible to easily add new numeric types. In C# 11 intptr and uintptr types
//   are linked to System.IntPtr and System.UIntPtr in a less hacky way, paving the way for new numeric types
//   such as potentially int128.