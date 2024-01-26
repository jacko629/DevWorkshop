//ask user their age 
//if name is Bob or Sue, address them as Professor.
//If the person is 21 years or older recommend they wait x years to start the class

using System.Reflection.Metadata;
using Professor;

Console.Write("What is your first name? ");
string? name = Console.ReadLine();

name = name.Replace(" ", "");

//custom made method to ask user for thier age and to verify that age is an interger. if not an interger then it will prompt until an interger is received. 
int age = Verify.GetAge();

int ageGap = age - 21;





if (ageGap == -1)
{
    Console.WriteLine();
    Console.WriteLine($"Hello {name}! I would love to have you in this class. You must be at least 21 years old.\nIm afraid you must wait at least {Math.Abs(ageGap)} year before you can start.");

}
else if (ageGap < -1)
{
    Console.WriteLine();
    Console.WriteLine($"Hello {name}! I would love to have you in this class. You must be at least 21 years old.\nIm afraid you must wait at least {Math.Abs(ageGap)} years before you can start.");

}



else if (name.ToLower() == "chase" && ageGap >= 0 || name.ToLower() == "sue" && ageGap >= 0)
{
    Console.WriteLine();
    Console.WriteLine($"Hello Professor {name}!");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Welcome {name}! Im glad you are able to be apart of this class!");
}



