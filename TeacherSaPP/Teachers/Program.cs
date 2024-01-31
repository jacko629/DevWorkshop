List<string> teachers = new List<string>();

teachers.Add("Simon");
teachers.Add("Samuuel");
teachers.Add("Ann");
teachers.Add("Anna");

//int index = 0

//if(index < teachers.Count())
//{
//    Console.WriteLine(teachers[index]);
//    index = index + 1;
//}
//if (index < teachers.Count())
//{
//    Console.WriteLine(teachers[index]);
//    index = index + 1;
//}
//if (index < teachers.Count())
//{
//    Console.WriteLine(teachers[index]);
//    index = index + 1;
//}
//if (index < teachers.Count())
//{
//    Console.WriteLine(teachers[index]);
//    index = index + 1;
//}
//if (index < teachers.Count())
//{
//    Console.WriteLine(teachers[index]);
//    index = index + 1;
//}

//while(index < teachers.Count)
//{
//    Console.WriteLine(teachers[index]);
//    index++;
//}

for(int i = 0; i < teachers.Count; i++)
{
    Console.WriteLine(teachers[i]);
}
Console.WriteLine();

List<int> numbers = new List<int>();

numbers.Add(0);
numbers.Add(33434982);
numbers.Add(885533);
numbers.Add(347474742);
numbers.Add(5);
numbers.Add(8);
numbers.Add(36);
numbers.Add(22);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.WriteLine();
for (int i = numbers.Count - 1 ; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}