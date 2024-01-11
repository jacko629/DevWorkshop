using System.Numerics;

Console.WriteLine("input a number");
int sucess; 
bool isNumber = Int32.TryParse(Console.ReadLine(), out sucess);

if(isNumber)
{
    Console.WriteLine("This is a number and i can add two to it");
    Console.WriteLine(sucess + 2);
}

else
{
    Console.WriteLine("This is not a number so im going to append a 2 to it");
   
}