
int times = 0;
while (true)
{
    Console.Write("Give number ");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number < 0)
    {
        times = times + 1;
    }
    else if (number == 0)
    {
        break;
    }

}
Console.WriteLine($"Number of negative numbers:{times}");