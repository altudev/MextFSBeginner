
// KDV hesaplayan Uygulama Projesi

Console.WriteLine("Shady Muhasebe Hizmetlerine Hos Geldiniz. Shady her zaman yaninizda! :)");

// Bir tane deger alanmasi gerekiyor

double price = ReadPrice();

// Bir tane KDV degeri alinmasi gerekiyor

double taxRate = ReadTaxRate();

// KDV'li fiyatin hesaplanmasi gerekiyor

double taxIncludedPrice = CalculateTax(price, taxRate);

Console.WriteLine($"------------------------------------");
Console.WriteLine($"--S----H----A-----D---Y----");
Console.WriteLine($"------------------------------------");

Console.WriteLine($"KDV'li Fiyat: {taxIncludedPrice}");

Console.ReadKey();

// CalculateTax()

double CalculateTax(double price, double taxRate)
{
    double result = price + (price * taxRate / 100);

    return result;
}

double SumThreeNumbers(double number1, double number2, double number3)
{
    double result = number1 + number2 + number3;

    return result;
}

double ReadPrice()
{
    Console.Write("Lutfen bir deger giriniz: ");

    double price = Convert.ToDouble(Console.ReadLine());

    return price;
}

double ReadTaxRate()
{
    Console.WriteLine($"------------------------------------");

    Console.WriteLine($"------------------------------------");

    Console.Write("Lutfen bir KDV degeri giriniz.");

    double taxRate = Convert.ToInt32(Console.ReadLine());

    return taxRate;
}


