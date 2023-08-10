// Use
// using [namespace];
using TestClassLibrary;

// Method call
// [class].[method]([argument]);
Console.WriteLine("Indtast noget:");
// Instansiation
// [class] [variabel] = new [constructor]([argument]);
Name nameClass = new Name(Console.ReadLine());

// [type] [variabel] = [object].[method]();
int len = nameClass.CountInput();
Console.WriteLine($"Længde på indtastning: {len}");
    