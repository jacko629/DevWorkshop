Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();

Console.Write("Where to? ");
int numberEnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Where from? ");
int numberstart = Convert.ToInt32(Console.ReadLine());


if(numberEnd > numberstart)
{
    for (int i = numberstart; i <= numberEnd; i++)
    {
        Console.WriteLine(i);
    }

}
else
{

}
