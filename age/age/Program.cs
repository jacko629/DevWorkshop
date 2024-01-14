int age;
int future;
int yearsAgo;


Console.WriteLine("How old are you");

age = Convert.ToInt32(Console.ReadLine());
future = (age + 25);
yearsAgo = (age - 25);

if (age > 0)
{
    Console.WriteLine("25 years from now you will be " + future + " years old.");
   
   
}
 if(age > 25)
{
    Console.WriteLine($"25 years ago, you would have been {yearsAgo} years old.");
}
else
{
    Console.WriteLine("You did not exist 25 years ago");
}





