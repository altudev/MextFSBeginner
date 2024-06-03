namespace MextFSBeginner.Domain.Entities;

public class AccessControlLog
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public AccessControlLog(int userId, string firstName, string lastName)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
    }

    public AccessControlLog()
    {
        
    }
    
    public void Log()
    {
        Console.WriteLine($"User Id: {UserId}, First Name: {FirstName}, Last Name: {LastName}");
    }
}