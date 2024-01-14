
using System.Runtime.InteropServices.Marshalling;


double sumOfNumbers = 0;
int numCount = 0;

while (true)
{
    Console.WriteLine("Give a number");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number == 0)
    {
        break;
    }
    else
    {
        sumOfNumbers = sumOfNumbers + number;
        numCount = numCount + 1;
    }
}
double averageOfNumbers = (sumOfNumbers / numCount);
Console.WriteLine($"Average of the numbers:{averageOfNumbers}");

