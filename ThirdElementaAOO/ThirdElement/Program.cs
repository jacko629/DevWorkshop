
List<string> list = new List<string>();

while(true)
{
    string input = Console.ReadLine();
    if(input.Equals(""))
    {
        break;
    }

    list.Add(input);
}

Console.WriteLine(list[2]);