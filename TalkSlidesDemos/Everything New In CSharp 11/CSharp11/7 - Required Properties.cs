// Required Properties
// - C# 11 introduces a `required` keyword for properties which must be provided when
//   using property based initialization. Constructors on such classes must specify they
//   initialize all required members via a manually applied attribute. This is due to
//   limitations with the compiler's code inspection.
//using System.Diagnostics.CodeAnalysis;

//var p = new Person { FirstName = "Scott", LastName = "Kay" };
//Console.WriteLine(p);

//public class Person
//{
//    public required string FirstName { get; set; }
//    public string? MiddleName { get; set; }
//    public required string LastName { get; set; }

//    public Person()
//    {
//    }

//    [SetsRequiredMembers]
//    public Person(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }

//    [SetsRequiredMembers]
//    public Person(string firstName, string? middleName, string lastName)
//    {
//        FirstName = firstName;
//        MiddleName = middleName;
//        LastName = lastName;
//    }

//    public override string ToString()
//        => string.Join(" ", new List<string> { FirstName, MiddleName, LastName }.Where(x => x != null));
//}