//using MextFSBeginner.Domain.Entities;
//using MextFSBeginner.Domain.Services;

//var errorLogManager = new ErrorLogManager();

//Console.WriteLine("Lutfen accesscontrollog'lari okuyabilecegimiz bir dosya yolu giriniz");

//string filePath = Console.ReadLine();

//errorLogManager.LogInfo($"Kullanicidan asagidaki dosya yolu alindi.\n{filePath}");

//var errorLogManager2 = new ErrorLogManager2();

//var accessControlLogManager = new AccessControlLogManager();

//var accessControlLogs = new List<AccessControlLog>();



//try
//{
//    accessControlLogs = accessControlLogManager.LoadFromFile(filePath);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.");

//     errorLogManager.Log(ex.ToString());

//     //errorLogManager2.Log(ex.Message);

//    // Bir tane ErrorLogManager olusturup, Log metodu ile hatalari loglayabiliriz.

//    // ErrorLogManager.Log(ex.Message);

//    // filePath = "C:\\Users\\alper\\Desktop\\Hatalar.txt";

//    // --------------------------------------------------
//    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
//    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
//    // --------------------------------------------------
//    // --------------------------------------------------
//    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
//    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
//    // --------------------------------------------------
//    // --------------------------------------------------
//    // Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
//    // Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
//    // --------------------------------------------------


//    //File.AppendAllText(filePath,"asdasdadsasd");
//}



//// C:\Users\alper\Desktop\AccessControlLogs.txt
////try
////{
////   accessControlLogs = accessControlLogManager.LoadFromFile(filePath);
////}
////catch (FileNotFoundException ex)
////{
////    Console.WriteLine("Dosya bulunamadi. Varsayilan dosya yolu kullaniliyor.");

////    File.WriteAllText("C:\\Users\\alper\\Desktop\\BlazorArticle\\hatalar.txt",ex.Message);

////    accessControlLogs = accessControlLogManager.LoadFromFile();
////}
////catch (Exception ex)
////{
////    Console.WriteLine("Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.");

////    Console.ReadKey();
////}

//string writeFilePath = "C:\\Users\\alper\\Desktop\\BlazorArticle\\AccessControlLogs2.txt";

//accessControlLogManager.WriteToFile(writeFilePath, accessControlLogs,"---");

// LogTypes Error, Info
// ErrorLogManager.Log(ex.Message, LogType.Error);
// ErrorLogManager.Log(ex.Message, LogType.Info);

// filePath = "C:\\Users\\alper\\Desktop\\HataLoglari.txt";
// filePath = "C:\\Users\\alper\\Desktop\\BilgiLoglari.txt";

// --------------------------------------------------
// Hata! - 11/06/2024 11:56:30
// Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
// --------------------------------------------------
// --------------------------------------------------
// Bilgi! - 11/06/2024 11:56:30
// Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
// --------------------------------------------------
// --------------------------------------------------
// Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.
// Could not find file 'D:\NETRepos\MextFSBeginner\MextFSBeginner.AccessControlApp2\bin\Debug\net8.0\asdsaasdafa123142123'.
// --------------------------------------------------

using MextFSBeginner.Domain.Enums;
using MextFSBeginner.Domain.Services;

var logManager = new LogManager();

logManager.Log("Uygulama baslatildi.", LogType.Info);

logManager.Log("Bir hata olustu.", LogType.Error);