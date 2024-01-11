Console.Write("How old are you: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (age >= 0 && age <=120)
{
    Console.WriteLine("OK.");
}

else
{
    Console.WriteLine("Impossible!");
}    