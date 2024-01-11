// See https://aka.ms/new-console-template for more information
//double number = Math.Pow(2, 8);

//Console.WriteLine(number);
int[] numArray = new int[8];

for (int i = 0; i < 8; i++)
{
    numArray[i] = (int)Math.Pow(2, i);
    
}

Array.Reverse(numArray);

for (int i = 0; i < numArray.Length; i++)
{
    Console.Write(numArray[i]);
    Console.Write(" ");
}
