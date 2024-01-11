// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Give the first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give the second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine();
Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine();
Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine();
Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)(firstNumber / (double)secondNumber)}");


