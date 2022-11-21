// Generic Attributes
// - C# 11 finally allows generic attributes! This is a relatively small feature, but cleans
//   up code significantly since the type no longer needs to be manually specified. Generic
//   constraints now work for generic attributes.
//public class OldGenericAttribute : Attribute
//{
//    public OldGenericAttribute(Type t) => ParamType = t;
//    public Type ParamType { get; }
//}

//public class NewGenericAttribute<T> : Attribute { }

//public class Foo
//{
//    [OldGeneric(typeof(string))]
//    [NewGeneric<string>]
//    public void Method() => Console.WriteLine("do something");
//}


// nameof() In Attributes
// - C# 11 also puts the arguments of a method in scope for nameof resolution.
//public class Bar {
//    [System.ComponentModel.Description(nameof(arg1))]
//    public void Method(string arg1) => Console.WriteLine(arg1);
//}