
while (true)
{
	Console.WriteLine("Give a number");
	int number = Convert.ToInt32(Console.ReadLine());

	if (number < 0)
	{
		Console.WriteLine("Unsuitable number");
		continue;
	}
	else if (number == 0)
	{
		break;
	}
	else 
	{
		Console.WriteLine(Math.Pow(number, 2)); 
	}
}





