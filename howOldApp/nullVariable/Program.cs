

//null - lack of value;
Console.WriteLine("Hello, welcome to my app. I can tell the future.");
Console.WriteLine("------------------------------------------------");


Console.Write("What is your name: ");
string name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Do not be afraid {name}.");

int daysTo80 = (365 * 80);
Console.WriteLine();

Console.Write("How old are you:  ");


if (int.TryParse(Console.ReadLine(), out  int age))
{
       
}
else
{
    Console.WriteLine();
    Console.WriteLine("This is not a valid number.");
    Console.WriteLine();
    Console.WriteLine("I cannot process this request, press enter to leave.");
    Console.ReadLine();
    
    //age = 0;
    //daysTo80 = 0;
}





int time = 365;

int daysAlive = (time * age);
Console.WriteLine();
Console.WriteLine($"You are {daysAlive} days old. ");
Console.WriteLine();
Console.WriteLine($"You have {daysTo80 - daysAlive} days till you are dead.");
Console.ReadLine();

