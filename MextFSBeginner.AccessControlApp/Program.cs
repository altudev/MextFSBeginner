using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;

string filePath = "/Users/altudev/Desktop/AccessControlLogs.txt";

string fileContent = File.ReadAllText(filePath);

string[] lines = fileContent.Split("\n", StringSplitOptions.RemoveEmptyEntries);

var accessControlLogs = new List<AccessControlLog>();

foreach (var line in lines)
{
    string[] properties = line.Split("---", StringSplitOptions.RemoveEmptyEntries);
    
    var accessControlLog = new AccessControlLog()
    {
        Id = Guid.NewGuid(),
        UserId = Convert.ToInt32(properties[0]),
        DeviceSerialNumber = properties[1],
        AccessType = Enum.Parse<AccessType>(properties[2]),
        Date = Convert.ToDateTime(properties[3])
    };
    
    accessControlLogs.Add(accessControlLog);
}

foreach (var accessControlLog in accessControlLogs)
{
    Console.WriteLine($"Log Sistem ID'si: {accessControlLog.Id}, Kullanici ID'si: {accessControlLog.UserId}, Cihaz Seri Numarasi: {accessControlLog.DeviceSerialNumber}, Erisim Tipi: {accessControlLog.AccessType}, Tarih: {accessControlLog.Date}");
}

Console.ReadKey();

var userValues = "Alper Tunga 28 Ogretmen";

//

