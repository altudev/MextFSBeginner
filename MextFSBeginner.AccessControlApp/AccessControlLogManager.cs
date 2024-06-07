using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;

namespace MextFSBeginner.AccessControlApp;

public class AccessControlLogManager
{
    public List<AccessControlLog> AccessLogs { get; set; }

    public AccessControlLogManager()
    {
        AccessLogs = new List<AccessControlLog>();
    }

    public List<AccessControlLog> LoadAccessLogsFromFile(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);

        string[] lines = fileContent.Split("\n", StringSplitOptions.RemoveEmptyEntries);

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
    
            AccessLogs.Add(accessControlLog);
        }
        
        return AccessLogs;
    }
}