Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();
//Write a program that reads an integer from the user. If the number is less than 0, the program prints the given integer multiplied by -1. In all other cases, the program prints the number itself. A few examples of how the program's expected to function are shown below:

int number;
Console.Write("input a number: ");
number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine(number * -1);
}
else
    Console.WriteLine(number);