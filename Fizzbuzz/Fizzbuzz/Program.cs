


Console.Write("Input a number bewtween 1 and 100: ");
int number = Convert.ToInt32(Console.ReadLine());

//if divisable by 3 and 5
if (number % 3 == 0 && number % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (number % 5 == 0 )
{
    Console.WriteLine("Fizz");
}
else if(number % 3 == 0 )
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(number);
}