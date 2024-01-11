// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many days would you like to convert to seconds? ");
int number = Convert.ToInt32(Console.ReadLine());
long secDay = (number * 86400);
Console.WriteLine("There are "+ secDay + $"seonds in {number} days, make it count.");