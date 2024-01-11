// See https://aka.ms/new-console-template for more information


bool isNumber;
string ageText;
int age = 0;
int maxattempts = 5;
int attempts = 0;
do
{
    Console.WriteLine("What is your age ?");
    ageText = Console.ReadLine();
    isNumber = int.TryParse(ageText, out age);


    if (age == 100)
    {
        Console.WriteLine(" 100! DAMN NIGGA YOU OLD");
        break;
    }

    if (age > 100)
    {
        Console.WriteLine($"{isNumber}, Aint no way you that old my guy");
    }

    if (isNumber is true)
    {
        break;
    }




    attempts++;
    if (attempts >= 5)
    {
        Console.WriteLine($"You've exceeded {attempts} attempts. You have had enough for today.");
        return;


    }

}
while (!isNumber || age > 99);

Console.WriteLine();
Console.WriteLine($"You are {age}");