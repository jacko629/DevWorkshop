int ones = 0;


while (true)
{


    Console.WriteLine("Input a number (0 exits): ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    if (number == 1)
    {
        ones = ones + 1;

    }
    

}
Console.WriteLine("Total umber of ones: "+ ones);