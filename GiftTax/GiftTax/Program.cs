using System.Diagnostics.CodeAnalysis;
using System.Globalization;


Console.WriteLine("Welcome to my application");
Console.WriteLine("-------------------------");
Console.WriteLine();

Console.Write("Value of gift: ");
int value = Convert.ToInt32(Console.ReadLine());
//int taxFloor = 0;
//int taxLimit = 0;
//double taxRate = 0;



if (value >= 5000 && value < 25000)
{
    int taxFloor = 5000;
    int taxLimit = 100;
    double taxRate = 0.08;
    double giftTax = (taxLimit + (value - taxFloor) * taxRate);
    Console.WriteLine("tax:" + giftTax.ToString("F1"),CultureInfo.InvariantCulture);

}

else if (value >= 25000 && value < 55000 )
{
    int taxFloor = 25000;
    int taxLimit = 1700;
    double taxRate = 0.10;
    double giftTax = (taxLimit + (value - taxFloor) * taxRate);
    Console.WriteLine("tax:" + giftTax.ToString("F2"), CultureInfo.InvariantCulture);
}

else if (value >= 55000 && value < 200000)
{

    int taxFloor = 55000;
    int taxLimit = 4700;
    double taxRate = 0.12;
    double giftTax = (taxLimit + (value - taxFloor) * taxRate);
    Console.WriteLine("tax:" + giftTax.ToString("F1"), CultureInfo.InvariantCulture);
}

else if (value >= 200000 && value < 100000)
{
    int taxFloor = 200000;
    int taxLimit = 22000;
    double taxRate = 0.15;
    double giftTax = (taxLimit + (value - taxFloor) * taxRate);
    Console.WriteLine("tax:" + giftTax.ToString("F1"),CultureInfo.InvariantCulture);
}

else if (value >= 100000)
{
    int taxFloor = 100000;
    int taxLimit = 142100;
    double taxRate = 0.17;
    double giftTax = (taxLimit + (value - taxFloor) * taxRate);
    Console.WriteLine("tax:" + giftTax.ToString("F1"),CultureInfo.InvariantCulture);

}
else
{
    Console.WriteLine("No tax!");
}