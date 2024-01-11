// See https://aka.ms/new-console-template for more information


//Console.WriteLine("What is your age ? ");



//bool isNumber = int.TryParse(age, out int result);

//Console.WriteLine(isNumber);
bool isNumber;
do
{
    Console.Write("what is your age: ");
    string age = Console.ReadLine();
    isNumber = int.TryParse(age, out int result);


}
while (isNumber is false); 
   