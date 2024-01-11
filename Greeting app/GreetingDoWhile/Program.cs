
Console.WriteLine("Welcome to my app");
Console.WriteLine("I hope you enjoy this app ");
Console.WriteLine("----------------------------");
Console.WriteLine();

string firstName;
do
{
    Console.Write("Whats your first name? ");
    firstName = Console.ReadLine();
}
while (!firstName.All(char.IsLetterOrDigit));



Console.WriteLine();

string lastName;
do
{
    Console.Write("Whats your last name ");
    lastName = Console.ReadLine();
}

while (!lastName.All(Char.IsLetterOrDigit));


//print out hello message calling user by first ands last name;

Console.WriteLine();
Console.WriteLine("Hello, " + firstName + " " + lastName + " I hope you enjoyed my application today. ");



