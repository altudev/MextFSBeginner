using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Services;

Console.WriteLine("Lutfen accesscontrollog'lari okuyabilecegimiz bir dosya yolu giriniz");

string filePath = Console.ReadLine();

var accessControlLogManager = new AccessControlLogManager();

var accessControlLogs = new List<AccessControlLog>();

var errorLogManager = new ErrorLogManager();

try
{
    accessControlLogs = accessControlLogManager.LoadFromFile(filePath);
}
catch (Exception ex)
{
    Console.WriteLine("Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.");

     errorLogManager.Log(ex.Message);

    // Bir tane ErrorLogManager olusturup, Log metodu ile hatalari loglayabiliriz.

    // ErrorLogManager.Log(ex.Message);

    // filePath = "C:\\Users\\alper\\Desktop\\Hatalar.txt";

    // --------------------------------------------------
    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
    // --------------------------------------------------
    // --------------------------------------------------
    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
    // --------------------------------------------------
    // --------------------------------------------------
    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
    // --------------------------------------------------


    //File.AppendAllText(filePath,"asdasdadsasd");

    Console.ReadKey();
}



// C:\Users\alper\Desktop\AccessControlLogs.txt
//try
//{
//   accessControlLogs = accessControlLogManager.LoadFromFile(filePath);
//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine("Dosya bulunamadi. Varsayilan dosya yolu kullaniliyor.");

//    File.WriteAllText("C:\\Users\\alper\\Desktop\\BlazorArticle\\hatalar.txt",ex.Message);

//    accessControlLogs = accessControlLogManager.LoadFromFile();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.");

//    Console.ReadKey();
//}

string writeFilePath = "C:\\Users\\alper\\Desktop\\BlazorArticle\\AccessControlLogs2.txt";

accessControlLogManager.WriteToFile(writeFilePath, accessControlLogs,"---");