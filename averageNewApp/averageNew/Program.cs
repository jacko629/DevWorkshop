using averageNew;



Console.WriteLine("Input a number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number");
int number4 = Convert.ToInt32(Console.ReadLine());




int sum = Calculate.Sum(number1, number2,number3,number4);
double avererge = Calculate.Average(number1,number2,number3,number4);

Console.WriteLine("Sum is:" + sum);
Console.WriteLine("Average is: " + avererge);