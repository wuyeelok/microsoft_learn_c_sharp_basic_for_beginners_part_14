// See https://aka.ms/new-console-template for more information
var p = 14;
Console.WriteLine($"Hello, World! {14}!");

var names = new List<string> { "Zoo", "Peter", "Ana", "Felipe" };
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToLower()}!");
}

names.Sort(); // sort the names list and will update the names list
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToLower()}!");
}