int numOfNumbers = 0;
int sumOfNumbers = 0;

while (true)
{
    Console.WriteLine("Give a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    if (number > 0 || number < 0)
    {
        numOfNumbers = numOfNumbers + 1;
        sumOfNumbers = sumOfNumbers + number;

    }
}

Console.WriteLine($"Number of numbers:{numOfNumbers}");
Console.WriteLine($"Sum of the numbers:{sumOfNumbers}");