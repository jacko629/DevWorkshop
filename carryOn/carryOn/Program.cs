Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();
//Write a program by using the loop example that asks "Shall we carry on?" until the user inputs the string "no".

while (true)
{
    Console.WriteLine("Shall we carry on");
    string? answer = Console.ReadLine();
    if(answer == "no")
    {
        break;
    }

    Console.WriteLine("Thanks come again!"); 
}
Console.WriteLine();
