//doubles can have decimal point - 1.23 , 43 

Console.Write("How mnay miles to work do you commute everyday: ");
string milesToWorkStr = Console.ReadLine();
Console.WriteLine();

//double milesToWorkD = Convert.ToDouble(milesToWorkStr);

//double distance = milesToWorkD / 3.4;


Console.WriteLine($"You commute {Convert.ToDouble(milesToWorkStr) / 3.13} miles to work everyday");


double averageAge = 2.0 / 3;
Console.WriteLine("Average age: "+averageAge);

decimal number = 2.34;