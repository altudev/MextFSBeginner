// Create FilePath Variable

using MextFSBeginner.ConsoleClient.Entities;
using MextFSBeginner.ConsoleClient.Enums;

string filePath = "C:\\Users\\alper\\Desktop\\AccessControlLogs.txt";

// Read the file from the path (as text)

string logFileText = File.ReadAllText(filePath);

// Split the text into an array of strings by the new line character \n

string[] logLines = logFileText.Split("\n",StringSplitOptions.RemoveEmptyEntries);

// Create a loop on the logLines array

List<AccessControlLog> accessControlLogs = new List<AccessControlLog>();

foreach (string logLine in logLines)
{
   string[] logValues = logLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

    var accessControlLog = new AccessControlLog
    {
        UserId = Convert.ToInt32(logValues[0]),
        DeviceSerialNumber = logValues[1],
        AccessType = Enum.Parse<AccessType>(logValues[2]),
        Date = Convert.ToDateTime(logValues[3]),
        Id = Guid.NewGuid(),
        IsApproved = true,
        ApprovedDate = DateTime.Now
    };

    accessControlLogs.Add(accessControlLog);

    Console.WriteLine($"Okunan Log Bilgisi:{accessControlLog.Id}\nUserID:{accessControlLog.UserId}\nDeviceSerialNumber:{accessControlLog.DeviceSerialNumber}\nAccessType:{accessControlLog.AccessType}\n" +
                      $"Date:{accessControlLog.Date}\nIsApproved:{accessControlLog.IsApproved}\nApprovedDate:{accessControlLog.ApprovedDate}");
}

Console.WriteLine($"Listeye Eklenen Log Sayisi:{accessControlLogs.Count}");