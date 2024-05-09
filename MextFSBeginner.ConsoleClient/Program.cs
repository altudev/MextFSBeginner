
using MextFSBeginner.ConsoleClient;

Console.WriteLine("Ilk Hesap Makinesi icin bir isim giriniz:");

var toplamaMakinesi = new Calculator(Console.ReadLine());

toplamaMakinesi.HosGeldinizMesajiGoster();

toplamaMakinesi.Sayi1iAta();

toplamaMakinesi.Sayi2yiAta();

toplamaMakinesi.ToplamaIslemi();

var cikarmaMakinesi = new Calculator("Cikarma");

cikarmaMakinesi.HosGeldinizMesajiGoster();

cikarmaMakinesi.Sayi1iAta();

cikarmaMakinesi.Sayi2yiAta();

cikarmaMakinesi.CikarmaIslemi();

Console.WriteLine($"Toplama Makinesinin Result Degeri:{toplamaMakinesi.Result} / Cikarma Makinesinin Result Degeri:{cikarmaMakinesi.Result}");

var carpmaMakinesi = new Calculator("Carpma");

carpmaMakinesi.HosGeldinizMesajiGoster();