// See https://aka.ms/new-console-template for more information
var p = 14;
Console.WriteLine($"Hello, World! {p}!");

var names = new List<string> { "Zoo", "Peter", "Ana", "Felipe", "Candy" };
names.Insert(1, "Jimmy");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToLower()}!");
}
Console.WriteLine($"Index of Ana is: {names.IndexOf("Ana")}");
names.Sort((a, b) => b.CompareTo(a)); // sort the names list and will update the names list
Console.WriteLine("After sort:");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToLower()}!");
}
Console.WriteLine($"Index of Ana is: {names.IndexOf("Ana")}");

Console.WriteLine($"Index of ZZZ is: {names.IndexOf("ZZZ")}");