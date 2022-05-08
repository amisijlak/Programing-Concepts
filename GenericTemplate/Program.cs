// See https://aka.ms/new-console-template for more information
using GenericTemplate;

//You can specify the different data types for different objects, as shown below. 
GenericClass<string> strStore = new GenericClass<string>();
strStore.Data = "Hello World!";
//strStore.Data = 123; // compile-time error

GenericClass<int> intStore = new GenericClass<int>();
intStore.Data = 100;
//intStore.Data = "Hello World!"; // compile-time error

GenericTemplate.KeyValuePair<int, string> kvp1 = new GenericTemplate.KeyValuePair<int, string>();
kvp1.Key = 100;
kvp1.Value = "Hundred";

GenericTemplate.KeyValuePair<string, string> kvp2 = new GenericTemplate.KeyValuePair<string, string>();
kvp2.Key = "IT";
kvp2.Value = "Information Technology";


//Generic Methods
//---------------
GenericMethods<string> cities = new GenericMethods<string>();
cities.AddOrUpdate(0, "Mumbai");
cities.AddOrUpdate(1, "Chicago");
cities.AddOrUpdate(2, "London");

GenericMethods<int> empIds = new GenericMethods<int>();
empIds.AddOrUpdate(0, 50);
empIds.AddOrUpdate(1, 65);
empIds.AddOrUpdate(2, 89);

Console.WriteLine(empIds.GetData(2));


NonGenericClass printer = new NonGenericClass();
printer.Print<int>(100);
printer.Print(200); // type infer from the specified value
printer.Print<string>("Hello");
printer.Print("World!"); // type infer from the specified value

