// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give a string");
string message1 = Console.ReadLine();

Console.WriteLine("Give a interger");
int message2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give a double");
double message3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Give a Boolean");
Boolean message4 = Boolean.TryParse(Console.ReadLine(), out message4);

Console.WriteLine($"You gave the string {message1}");
Console.WriteLine($"You gave the interger {message2}");
Console.WriteLine($"You gave the double {message3}");
Console.WriteLine($"You gave the boolean {message4}");
