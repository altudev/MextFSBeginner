namespace MextFSBeginner.ConsoleClient
{
    public class HesapMakinesi
    {
        private int Sayi1 { get; set; }
        private int Sayi2 { get; set; }
        public int Toplam { get; set; }
        public string Isim { get; set; }

        public HesapMakinesi(string isim)
        {
            Isim = isim;
        }

        public int ToplamaIslemi()
        {
            Toplam = Sayi1 + Sayi2;

            SonucuYazdir("Toplama");

            return Toplam;
        }

        public int CikarmaIslemi()
        {
            Toplam = Sayi1 - Sayi2;

            SonucuYazdir("Cikarma");

            return Toplam;
        }

        private void SonucuYazdir(string islemTipi)
        {
            Console.WriteLine($"{islemTipi} Islemi Toplam: {Toplam} <3");
        }

        public void Sayi1iAta()
        {
            Console.WriteLine("Sayi 1'i giriniz:");

            Sayi1 = Convert.ToInt32(Console.ReadLine());
        }

        public void Sayi2yiAta()
        {
            Console.WriteLine("Sayi 2'yi giriniz:");

            Sayi2 = Convert.ToInt32(Console.ReadLine());
        }

        public void HosGeldinizMesajiGoster()
        {
            Console.WriteLine($"{Isim} Makinesine Hos Geldiniz.");
        }
    }
}
