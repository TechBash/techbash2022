// Relaxed Shift Operator
// - C# 11 allows the left and right shift operators to be overloaded using any type on the right
//   side of the operator. Previously, the right side must've been an integer. This was done for
//   flexibility with generic math, but can be abused with humorous results. This is a cheeky example
//   of implementing C++ streams in C# 11. Please don't use this (or something like it) in production.
//var endl = Environment.NewLine;

//var cout = new ConsoleOut();
//_ = cout << "Hello World" << endl;

//class ConsoleOut
//{
//    public static ConsoleOut operator <<(ConsoleOut cout, string s)
//    {
//        Console.Write(s);
//        return cout;
//    }
//}