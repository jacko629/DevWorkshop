Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();


Console.WriteLine("Give a number:");
int number = Convert.ToInt32(Console.ReadLine());

number = number % 2;

if(number == 0)
{
    Console.WriteLine("This is an even number.");
}

else
{
    Console.WriteLine("This is a odd number");
}