List<int> numbers = new List<int>();
while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());
    {
        if(number == 0)
        {
            break;
        }

        numbers.Add(number);
    }
}

Console.WriteLine(numbers[1] + numbers[4]);