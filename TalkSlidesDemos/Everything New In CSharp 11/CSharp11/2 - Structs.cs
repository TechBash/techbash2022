// Ref Structs With Ref Structs Members
// - C# 11 allows ref structs to embed ref structs. This is largely to the benefit
//   of the implementation of types like ReadOnlySpan.
//ref struct Foo
//{
//    public ref int Bar;
//}


// Auto Default Structs
// - C# 11 allows structs to declare a parameterless constructor which does not
//   initialize every field. In previous language versions, this would be a
//   compile error. Turns out there was no solid justification for this restriction.
//   
//var x = new Foo();
//x.Bar = 42;
//Console.WriteLine(x.Bar);

//struct Foo
//{
//    public int Bar { get; set; }

//    public Foo()
//    {
//    }
//}