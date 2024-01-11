
//ask user for name
Console.Write("Whats your name? ");
string name = Console.ReadLine();


//if name is Chase, say welcome Mr. Brown nice to see you back

if(name.Equals("Chase", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine();
    Console.WriteLine("Welcome back Mr. Brown, enjoy your stay!");
}

else
{
    Console.WriteLine();
    Console.WriteLine($"Licence and registration {name}!"); 
}

Console.ReadLine();

//if not chase, just greet by name