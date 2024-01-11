using System.Globalization;

Console.Write("Password: ");
string password = Console.ReadLine();
Console.WriteLine();

if (password.Equals("Caput Draconis"))
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Off with you!");
}