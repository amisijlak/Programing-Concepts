// See https://aka.ms/new-console-template for more information
using StaticKeywordConcept;

Console.WriteLine("Hello, World!");

Console.WriteLine(NotStaticEmployeeClass.SetNumberOfEmployees.NumberOfEmployee);

//For testing the static method in employee4 class
//------------------------------------------------
Console.Write("Enter the employee's name: ");
string name = Console.ReadLine();
Console.Write("Enter the employee's ID: ");
string id = Console.ReadLine();

// Create and configure the employee object.
Employee4 e = new Employee4(name, id);
Console.Write("Enter the current number of employees: ");
string n = Console.ReadLine();
Employee4.employeeCounter = Int32.Parse(n);
Employee4.AddEmployee();

// Display the new information.
Console.WriteLine($"Name: {e.name}");
Console.WriteLine($"ID:   {e.id}");
Console.WriteLine($"New Number of Employees: {Employee4.employeeCounter}");

//ouput for testing static field initialization
//------------------------------------------------
Console.WriteLine(StaticInitialization.x);
Console.WriteLine(StaticInitialization.y);

StaticInitialization.x = 99;
Console.WriteLine(StaticInitialization.x);