// Unsigned Right Shift Operator
// - C# 11 introduced the unsigned right shift operator to shift a signed int without regard to its
//   signed status. This is possible in older versions of C# with ugly casting.

//int x = -8;
//Console.WriteLine($"-8      : {x,11} :: {Convert.ToString(x, toBase: 2).PadLeft(32, '0'),32}");

//int y = x >> 2; // Arithmetic Shift (Keeps Sign)
//Console.WriteLine($"-8  >> 2: {y,11} :: {Convert.ToString(y, toBase: 2).PadLeft(32, '0'),32}");

//int z = x >>> 2; // Logical Shift
//Console.WriteLine($"-8 >>> 2: {z,11} :: {Convert.ToString(z, toBase: 2).PadLeft(32, '0'),32}");

// Possible In C# 10
//int a = (int)((uint)x >> 2); // Logical Shift
//Console.WriteLine($"-8 >>> 2: {a,11} :: {Convert.ToString(a, toBase: 2).PadLeft(32, '0'),32}");
