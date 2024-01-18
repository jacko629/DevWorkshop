//Implement a program which calculates the factorial of a number given by the user

Console.Write("Give a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= number; i++)
{
    factorial = factorial * i;
}

Console.Write("Factorial: " + factorial );