namespace MextFSBeginner.Domain.Services;

public class HesapMakinesi
{
    public int Topla(int sayi1, int sayi2, bool konsoldaGoster)
    {
        var sonuc = sayi1 + sayi2;

        if (konsoldaGoster)
            KonsolaYazdir(sonuc);
        
        return sonuc;
    }

    public int Cikar(int sayi1, int sayi2, bool konsoldaGoster)
    {
        var sonuc = sayi1 - sayi2;

        if (konsoldaGoster)
            KonsolaYazdir(sonuc);
        
        return sonuc;
    }

    public int Carp(int sayi1, int sayi2, bool konsoldaGoster)
    {
        var sonuc= sayi1 * sayi2;

        if (konsoldaGoster)
            KonsolaYazdir(sonuc);

        return sonuc;
    }

    public int Bol(int sayi1, int sayi2, bool konsoldaGoster)
    {
        var sonuc = sayi1 / sayi2;

        if (konsoldaGoster)
            KonsolaYazdir(sonuc);

        return sonuc;
    }
    
    private void KonsolaYazdir(int sonuc)
    {
        Console.WriteLine($"Piyango size cikti: {sonuc} <3 Supersin!");
    }
}