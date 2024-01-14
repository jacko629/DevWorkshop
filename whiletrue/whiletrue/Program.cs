while (true)
{
    Console.WriteLine("Insert a positive integer");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number == 0)
    {
        break;
    }

    if (number <0)
    {
        Console.WriteLine("Thank you try again");
        continue;
    }
    Console.WriteLine("Your input was " + number);
}
