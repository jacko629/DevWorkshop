
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

double sumOfNumbers = 0;
int numcount = 0;

while (true)
{
    Console.Write("Input: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0)
    {
        break;
    }
    if (number > 0)
    {
        sumOfNumbers = sumOfNumbers + number;
        numcount = numcount + 1;
    }
    
   
    

}
{
    if (numcount == 0)
        Console.WriteLine("Cannot calculate average");
    return;
}



double average = (sumOfNumbers / numcount);
Console.WriteLine($"The average is {average:0.0}");