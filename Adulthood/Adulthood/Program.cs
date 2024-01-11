// See https://aka.ms/new-console-template for more information

int age;
do
{
    Console.WriteLine("How old ae you?");
    age = Convert.ToInt32(Console.ReadLine());

    if(age < 0)
    {
        Console.WriteLine("Your age cannot be less than zero");
    }

}
while (age <= 0);



if (age >= 18 )
{
    Console.WriteLine("You are an adult");
}

else
{
    Console.WriteLine("You are not an adult");
}
