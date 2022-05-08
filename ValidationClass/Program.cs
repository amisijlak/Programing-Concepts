// See https://aka.ms/new-console-template for more information
using ValidationClass;

Console.WriteLine("Hello, World!");


/// <summary>
/// Now, we can include the ExtensionMethods namespace wherever you want to use this extension method
/// </summary>
int i = 10;
bool result = i.IsGreaterThan(100);

Console.WriteLine(result);
