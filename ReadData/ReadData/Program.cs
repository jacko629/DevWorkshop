using System;
using System.IO;
using 

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\cbrow\Documents\archive\keywords.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // Here you can process each line as needed
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file");
            Console.WriteLine(ex.Message);
        }
    }
}
