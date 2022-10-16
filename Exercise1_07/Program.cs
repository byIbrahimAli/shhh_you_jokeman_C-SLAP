// See https://aka.ms/new-console-template for more information
var aGolden = new GoldenRetriever() { Name = "Aspen" };
var anotherGolden = new GoldenRetriever() { Name = "Aspen" };

var aBorder = new BorderCollie() { Name = "Aspen" };
var anotherBorder = new BorderCollie() { Name = "Aspen" };

var aBernese = new Bernese() { Name = "Aspen" };
var anotherBernese = new Bernese() { Name = "Aspen" };

var goldenComparison = aGolden.Equals(anotherGolden) ? "These Golden Retrievers have the same name" : "These Goldens have different names";

var borderComparison = aBorder.Equals(anotherBorder) ? "These Border Collies have the same name" : "These Border Collies have different names";

var berneseComparison = aBernese.Equals(anotherBernese) ? "These Bernese dogs have the same name" : "These Bernese dogs have different names";

Console.WriteLine(goldenComparison);
Console.WriteLine(borderComparison);
Console.WriteLine(berneseComparison);

struct GoldenRetriever
{
    public string Name { get; set; }
}

class BorderCollie
{
    public string Name { get; set; }
}

class Bernese
{
    public string Name { get; set; }
    public override bool Equals(object obj)
    {
        if (obj is Bernese borderCollie && obj != null)
        {
            return this.Name == borderCollie.Name;
        }
        return false;
    }
}

/**
What the fuck just happened here?

1. Two types of variables in C#: Reference Types & Value Types
2. Value Types are built in types for C# -> structs; bool; byte; char; decimal; double; enum; float; int; long; sbyte; short; uint; ulong; and ushort
3. Reference Types are -> string; array; class

Okay...
See images for how these are represented in memory.
* Value Types: Value of variable stored in memory location 0x100 RAM.
* Reference Types: New Reference Type variable assigned. What's stored in memory? Memory address for where the value is stored. It's a pointer, and not the value itself. 

Finally...
1. GoldenRetriever() is a struct, which is a value type.
2. BorderCollie() is a class, reference type.
3. Bernese(), reference type, but Equals() overridden. 

For 1, equals is asking, those things in memory, they equal? Stored in memory will be "Aspen" for both, so yes.

For 2, equals is asking, those things in memory, they equal? Memory holds the references to the value, not the value. As they're two different objects, it's a false. -- Exception is if both references pointed to the same object.

For 3. Without the overridden equals, 3 works like 2. But the overridden Equals() it's no longer comparing the reference to the value, it's now comparing the values. 

*/