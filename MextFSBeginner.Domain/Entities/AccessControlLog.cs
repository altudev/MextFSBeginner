using MextFSBeginner.Domain.Enums;

namespace MextFSBeginner.Domain.Entities;

public class AccessControlLog
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public string DeviceSerialNumber { get; set; }
    public AccessType AccessType { get; set; }
    public DateTime Date { get; set; }
}