using System.Runtime.ExceptionServices;

Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();

//Write a program that reads two integers from the user. If the first number is greater than the second, the program prints "(first) is greater than (second)." If the first number is less than the second, the program prints "(first) is smaller than (second)." Otherwise, the program prints "(first) is equal to (second)." The (first) and (second) should always be replaced with the actual numbers that were provided by the user.

int a;
int b;

 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());

if(a < b)
{
    Console.WriteLine($"{a} is smaller than {b}.");
}
else if(a > b)
{
    Console.WriteLine($"{a} is greater than {b}.");
}
else
{
    Console.WriteLine($"{a} is equal to {b}");
}