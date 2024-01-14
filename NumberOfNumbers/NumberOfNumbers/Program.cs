
int times = 0;

while (true)
{
    Console.WriteLine("Give a number:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0)
    {
        times = times + 1;
    }
    else
    {
        break;
    }
}
Console.WriteLine("Number of numbers: "+ times);