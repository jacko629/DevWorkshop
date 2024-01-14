int sum = 0;
int number = 0;
while (true)
{
    Console.WriteLine("Input number");
     number = Convert.ToInt32(Console.ReadLine());


    if(number == 0)
    {
        break;
    }
    else
    {
        sum = sum + number;
    }
}

Console.WriteLine(sum);