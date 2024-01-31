

List<string> names = new List<string>();

int j = 0;

//while (j<10)
//{
//    string input = Console.ReadLine();
//    j++;
//    if(input == "")
//    {
//        break;
//    }

//    names.Add(input);
//}

//Console.WriteLine(names[names.Count -1 ]);

for (int i = 0; i < 10; i++)
{
    string name =Console.ReadLine();
    if(name == "")
    {
        break;
    }
    names.Add(name);
}

Console.WriteLine(names[names.Count-1]);