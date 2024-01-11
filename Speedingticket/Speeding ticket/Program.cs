Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();
Console.Write("Input Speed: ");
int speed = Convert.ToInt32(Console.ReadLine());

if (speed > 120)
{
    Console.WriteLine();
    Console.WriteLine("Speeding ticket!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Your free to go.");
               
    
}

