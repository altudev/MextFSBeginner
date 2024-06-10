using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;
using MextFSBeginner.Domain.Services;

//var hesapMakinesi = new HesapMakinesi();

//var toplam = hesapMakinesi.Topla(20, 50,true);


var accessControlLogManager = new AccessControlLogManager();

var accessControlLogs = accessControlLogManager.LoadFromFile();

foreach (var accessControlLog in accessControlLogs)
{
    Console.WriteLine($"Log Sistem ID'si: {accessControlLog.Id}, Kullanici ID'si: {accessControlLog.UserId}, Cihaz Seri Numarasi: {accessControlLog.DeviceSerialNumber}, Erisim Tipi: {accessControlLog.AccessType}, Tarih: {accessControlLog.Date}");
}

Console.ReadKey();

var userValues = "Alper Tunga 28 Ogretmen";



