
string fullName = GetFullName();

Console.WriteLine($"Merhaba {fullName}, lutfen islem icin ilk sayiyi giriniz:");

decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Lutfen islem icin ikinci sayiyi giriniz:");

decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

decimal toplam = Toplama(sayi1, sayi2,25,26,27,30,111,222,333,444);

Console.WriteLine($"Toplam: {toplam}");

Console.ReadKey();

// Bir fiyat gelecek, kdv oranı 0.20 olacak ve kdv dahil fiyatı hesaplayacak

decimal fiyat = 100;
decimal kdvOrani = 0.20m;

decimal kdvliFiyat = CalculateTax(fiyat, kdvOrani);

decimal CalculateTax(decimal fiyat, decimal kdvOrani)
{
    decimal kdvMiktari = fiyat * kdvOrani;
    
    decimal kdvliFiyat = fiyat + kdvMiktari;

    return kdvliFiyat;
}

decimal Toplama(params decimal[] sayilar)
{
    decimal toplam = 0;
    
    foreach (var sayi in sayilar)
    {
        toplam += sayi;
    }
    
    return toplam;
}

string GetFullName()
{
    Console.WriteLine("Lutfen adinizi giriniz:");
    string firstName = Console.ReadLine();

    Console.WriteLine("Lutfen soyadinizi giriniz:");
    string lastName = Console.ReadLine();

    string fullName = $"{firstName} {lastName}";
    
    Console.WriteLine(fullName);

    return fullName;
}
