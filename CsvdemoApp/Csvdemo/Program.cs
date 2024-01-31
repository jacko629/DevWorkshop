using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Csvdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = ReadCsvFile(@"C:\Users\cbrow\Documents\people.csv");

            Console.WriteLine("Enter a name or phone number to search:");
            var searchTerm = Console.ReadLine();

            var result = persons
                .Where(p => p.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                            || p.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                            || p.Phone.Contains(searchTerm))
                .ToList();

            if (result.Any())
            {
                foreach (var person in result)
                {
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Phone: {person.Phone}");
                }
            }
            else
            {
                Console.WriteLine("No results found.");
                
            }
        }

        static List<PersonModel> ReadCsvFile(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
          
            return csv.GetRecords<PersonModel>().ToList();
        }
    }
}
