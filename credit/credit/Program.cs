internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Number: ");

        string cardNumber = Console.ReadLine();

        char[] numArray = cardNumber.ToCharArray();

        // Reversing the array 
        Array.Reverse(numArray);

        int sum = 0;

        for (int i = 0; i < numArray.Length; i++)
        {
            int value = numArray[i] - '0'; // Convert char to int

            // Multiply every other digit by 2, starting from the first digit
            if (i % 2 == 0)
            {
                value *= 2;
                if (value > 9)
                {
                    value -= 9;
                }
            }
        }
    }
}