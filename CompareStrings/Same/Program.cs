//Write a program that prompts the user for two strings. If the strings are the same, then the program prints"Same". Otherwise, it prints "Different".

Console.WriteLine("Enter the first string: ");
string firstNumber = Console.ReadLine();

Console.WriteLine("Enter the second string");
string secondNumber = Console.ReadLine();

if (!firstNumber.Equals(secondNumber))
{
    Console.WriteLine("Differnt");
}
else
{
    Console.WriteLine("These are the same!");
}