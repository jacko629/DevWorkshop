
//-Welcome user to app
Console.WriteLine("Welcome! to my Greeting Appplication ");
Console.WriteLine("This application was built by Chaslon Brown");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();






//-Ask for first name
Console.Write("Whats your name? ");
int inputStart = Console.CursorLeft; // captures cursor postion right at the point user enters name.
string name = Console.ReadLine();


Console.SetCursorPosition(inputStart, Console.CursorTop - 1); //moves cursor position up 1 line


//overwrites lines with ' ' 
Console.WriteLine(new string(' ', name.Length));
 

Console.WriteLine();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine();
Console.WriteLine("Thsnkl you for using my application");

Console.ReadLine();
