Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
int numberTwo;
int numberOne;

//checking if numberOne is greater than zero
do
{
    
    Console.WriteLine("Give the first number");
    numberOne = Convert.ToInt32(Console.ReadLine());

    if (numberOne <= 0)
    {
        Console.WriteLine("must be greater than zero");
        Console.WriteLine();
    }
}
while (numberOne <= 0);

//checking if numberTwo is greater than zero
do
{
    
    Console.WriteLine("Give the second number");
    numberTwo = Convert.ToInt32(Console.ReadLine());

    if (numberTwo <= 0)
    {
        Console.WriteLine("Number must be greater than 0");
        Console.WriteLine();
    }
}
while (numberTwo <= 0);

       
   
    
        
        if(numberOne < numberTwo)
        {
    Console.WriteLine();
    Console.WriteLine("The greater number is " + numberTwo);
  
}


        else if (numberOne > numberTwo)
        {
    Console.WriteLine();
    Console.WriteLine("The greater number is " + numberOne);
   

}

        else
        {
    Console.WriteLine();
    Console.WriteLine("The numbers are the same");
        }
        
    
    


