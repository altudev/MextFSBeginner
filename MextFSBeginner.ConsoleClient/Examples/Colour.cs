namespace MextFSBeginner.ConsoleClient.Examples
{
    public class Colour
    {
        public string Name { get; set; } // Kirmizi
        public string HexCode { get; set; } // #FF0000

        public Colour(string name, string hexCode) // Pascal case => AlperHocam || Camel Case => alperHocam
        {
            Name = name;

            HexCode = hexCode;
        }

        public Colour()
        {

        }

        public void PrintMyValues()
        {
            Console.WriteLine($"Renk Adi:{Name}, Renk Kodu:{HexCode} <3");
        }

        public void PrintMyValues(string message)
        {

            //Colour orangeColour = new Colour("Turuncu", "#FFA500");

            //orangeColour.PrintMyValues();

            //Colour pinkColour = new Colour("Pembe", "#FFC0CB");

            //pinkColour.PrintMyValues();

            //Console.ReadLine();

            //Colour usersColour = new Colour();

            //Console.Write("Lutfen rengin adini yaziniz: ");
            //usersColour.Name = Console.ReadLine();

            //Console.Write("Lutfen rengin kodunu yaziniz: ");
            //usersColour.HexCode = Console.ReadLine();

            //usersColour.PrintMyValues();

            //Console.ReadLine();
        }
    }
}
