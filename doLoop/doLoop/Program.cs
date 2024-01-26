

bool isValid;
do
{
    Console.Write("What is your age ");
   string ageText = Console.ReadLine();
      isValid = int.TryParse(ageText, out int age);

    if(isValid == false)
    {
        Console.Write("This is an invalid age ");
        
    }
}
while (isValid == false);