Console.WriteLine("Whats your name?");

string? name = Console.ReadLine();

if (name.ToLower() == "tim") 
{
    Console.WriteLine("Welcome professor");
}
else
{
    Console.WriteLine("Welcome to class student");
}