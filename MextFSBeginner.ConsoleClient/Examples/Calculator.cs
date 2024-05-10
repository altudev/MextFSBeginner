namespace MextFSBeginner.ConsoleClient.Examples
{
    public class Calculator
    {
        private int Number1 { get; set; }
        private int Number2 { get; set; }
        public int Result { get; set; }
        public string Name { get; set; }

        public Calculator(string name)
        {
            Name = name;
        }

        public int ToplamaIslemi()
        {
            Result = Number1 + Number2;

            SonucuYazdir("Toplama");

            return Result;
        }

        public int CikarmaIslemi()
        {
            Result = Number1 - Number2;

            SonucuYazdir("Cikarma");

            return Result;
        }

        private void SonucuYazdir(string islemTipi)
        {
            Console.WriteLine($"{islemTipi} Islemi Result: {Result} <3");
        }

        public void Sayi1iAta()
        {
            Console.WriteLine("Sayi 1'i giriniz:");

            Number1 = Convert.ToInt32(Console.ReadLine());
        }

        public void Sayi2yiAta()
        {
            Console.WriteLine("Sayi 2'yi giriniz:");

            Number2 = Convert.ToInt32(Console.ReadLine());
        }

        public void HosGeldinizMesajiGoster()
        {
            Console.WriteLine($"{Name} Makinesine Hos Geldiniz.");
        }
    }
}
