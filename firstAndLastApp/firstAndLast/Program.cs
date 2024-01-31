
List<string> names = new List<string>();

Console.WriteLine("Enter q to exit\n");


for (int i = 1; i <= 10; i++)
{
    Console.Write($"{i}. ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("");
        Console.WriteLine("Are you sure you want to quit, hit 'n' for no and 'y' for yes. ");
        string quit = Console.ReadLine();
        if (quit == "y")
        {
            break;
        }
        else if(quit == "n")
        {
            continue;
        }
        

        
    }
    names.Add(input);
    
}
Console.WriteLine(names[0]);
Console.WriteLine(names[names.Count - 1]);