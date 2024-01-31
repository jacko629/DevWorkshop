


List<string> list = new List<string>();

while (true)
{
    Console.Write("Input: ");
    string input = Console.ReadLine();
    if(input == "")
    {
        break;
    }
    list.Add(input);
}

Console.WriteLine($"In total {list.Count}");

