// See https://aka.ms/new-console-template for more information


int firstnum = 0;
int secondnum = 0;
int sum = 0;


//get first number 
Console.Write("Give the first number: ");
firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Give the second number: ");
secondnum = Convert.ToInt32(Console.ReadLine());
sum = (firstnum + secondnum);
Console.WriteLine("The sum of the numbers is " + sum +".");
