// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("what is your age: ");
string? agetext = Console.ReadLine();

int age = int.Parse(agetext);

Console.WriteLine($"in three years you will be {age + 3} years old" );

Console.WriteLine(" Input your birthdate in form mm/dd/yyyy");

string? dateText = Console.ReadLine();

DateTime date = DateTime.Parse(dateText);

Console.WriteLine(date);

