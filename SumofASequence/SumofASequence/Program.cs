
using System.Diagnostics.CodeAnalysis;



Console.Write("First number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Last number: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());

//int i = 0;
//int sum = 0;
//while (i < lastNumber)
//{
//    i++;
//    sum = sum + i;

//}
//Console.WriteLine(sum);

int sum = 0;
for (int i = firstNumber; i <= lastNumber; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);
