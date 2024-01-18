
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Give numbers:");
int numbers = 0;
int sum = 0;
int count = 0;
double average = 0;
int even = 0;
int odd = 0;
while (true)
{
    numbers = Convert.ToInt32(Console.ReadLine());
    

    if (numbers == -1 )
    {
        break;
    }

    if(numbers % 2 == 0)
    {
        even++;
    }
            
    else {
        odd++;
    }




        count++;
        sum = sum + numbers;
    average = (double)sum / count;
        

   

}

Console.WriteLine("Thanks bye");
Console.WriteLine("The sum: "+ sum);
Console.WriteLine("Numbers :" +count);
Console.WriteLine("Average " + average);
Console.WriteLine("Even: "+ even);
Console.WriteLine("Odd "+ odd);
