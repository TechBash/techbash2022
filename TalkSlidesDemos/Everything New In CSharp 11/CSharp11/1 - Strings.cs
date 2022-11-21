// New Lines In String Interpolation
// - C# 11 allows line breaks in the "holes" of interpolated strings. This is a small
//   feature which may have never made it to the attention of the language designers,
//   but is perfect for an open-source community contribution.
//var x = $"the ultimate answer is {
//    40 + 2
//    }";
//Console.WriteLine(x);


// UTF8 String Literals
// - C# 11 introduces the u8 suffix to express a string which is compiled as a
//   ReadOnlySpan<byte>, an efficient data type which requires no allocations.
//   This is largely for web-focused projects, such as the core of ASP.Net.
//   Notice that with a u8 suffix, the variable y in this example is no longer a
//   string and cannot be used with Console.WriteLine.
//var y = "hello"u8;
//Console.WriteLine(y);


// Pattern Match Span<char>
// - C# 11 introduces a new pattern which allows Span<char> and ReadOnlySpan<char>
//   to be compared to a proper string. This saves developers time from needing to
//   convert the types for comparisons and makes switch statements work as you'd expect.
//   Note that a UTF8 String Literal is a ReadOnlySpan<byte>, not of char, which does
//   not work with this pattern.
//var z = "hello".AsSpan();
//switch (z)
//{
//    case "hello":
//        Console.WriteLine("hi!");
//        break;
//}


// Raw String Literals
// - C# 11 introduces new syntax for absolute literal strings with support for 
//   interpolation. This is intended for copying/pasting HTML and JSON data in
//   code, likely for tests. You can add more " to the start and close if the
//   enclosed string has larger runs of " characters. Whitespace is trimmed based
//   on the indentation of the closing """.
//var request = """
//    {
//        "id":42,
//        "imp":
//            [
//                {
//                    "id":23
//                }
//            ]
//    }
//    """;
//Console.WriteLine(request);
//
// - This also works as a single line.
//var request = """{"id":42,"imp":[{"id":23}]}""";