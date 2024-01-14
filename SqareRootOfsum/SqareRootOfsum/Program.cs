using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();
//returns sqaure root of the sum of two numbers

int a;
int b;

double sum;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

sum = Math.Sqrt(a + b);

Console.WriteLine(sum);