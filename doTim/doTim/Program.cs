using System;

string? name;



do
{
    Console.Write("What is your name ");
    name = Console.ReadLine();
    
    if(name.ToLower() == "exit")
     {   
    Console.WriteLine("Exiting application.......");
        break;
    }
    else if(name.ToLower() == "tim")
    {
        Console.WriteLine("Hello professor");
    }
    else
    {
        Console.WriteLine($"Hello {name} ");
    }

}
while (true);