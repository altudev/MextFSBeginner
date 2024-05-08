using MextFSBeginner.ConsoleClient.Enums;

Console.WriteLine("Konsol uygulamamizin rengini degistirmek icin bir renk kodu seciniz.");

foreach(var color in Enum.GetValues(typeof(Colour)))
{
    Console.WriteLine($"{(int)color} - {color}");
}

string coluorText = Console.ReadLine();

Colour selectedColour = Enum.Parse<Colour>(coluorText);

if (selectedColour == Colour.White)
{
    Console.ForegroundColor = ConsoleColor.White;
}
else if (selectedColour == Colour.Pink)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
}
else if (selectedColour == Colour.Blue)
{
    Console.ForegroundColor = ConsoleColor.Blue;
}
else if (selectedColour == Colour.Red)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (selectedColour == Colour.Green)
{
    Console.ForegroundColor = ConsoleColor.Green;
}
else if (selectedColour == Colour.Yellow)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}

Console.WriteLine("Supersin, bak renkler degisti. Ne guzel oldu. :)");

Console.ReadKey();

