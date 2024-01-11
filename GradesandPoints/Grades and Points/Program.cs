using System.ComponentModel.Design;
using System.Net.Security;

Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();


Console.WriteLine("Give points [0-100];");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade < 0)
{
    Console.WriteLine("Impossible");
}
else if (grade < 50)
{
    Console.WriteLine("failed");
}

else if (grade < 60)
{
    Console.WriteLine("1");
}

else if (grade < 70)
{
    Console.WriteLine("2");
}

else if (grade < 80)
{
    Console.WriteLine("3");
}
else if (grade < 90)
{
    Console.WriteLine("4");
}
else if (grade <= 100) 
{
    Console.WriteLine("5");
}

else if(grade > 100)
{
    Console.WriteLine("Incredible!");
}