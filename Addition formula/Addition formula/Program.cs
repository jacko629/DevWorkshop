// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to my application.");
//Console.WriteLine("This app was designed by Chaslon Brown");
Console.WriteLine("--------------------------------------");
Console.WriteLine("");
Console.WriteLine("");


int a = 0;
int b = 0;
int c = 0;

Console.Write("Give the first number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Give the second number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

c = (a + b);
Console.WriteLine($"{a} + {b} = {c}");