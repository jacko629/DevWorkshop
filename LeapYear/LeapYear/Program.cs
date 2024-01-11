

Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();

Console.Write("Give a year: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 100 == 0)
{
    if(year % 400 == 0)
    {
        Console.WriteLine("This is a leap year");
    }
    else
    {
        Console.WriteLine("This is not a leap year");
    }
}
else if(year % 4 == 0)
{
    Console.WriteLine("This is a leap year");
}
else
{
    Console.WriteLine("This is not leap year");
}
