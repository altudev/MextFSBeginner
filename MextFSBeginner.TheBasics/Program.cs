// See https://aka.ms/new-console-template for more information

using MextFSBeginner.Domain.Entities;

List<Student> attendees = new List<Student>()
{
    new Student()
    {
        Id = 1,
        FirstName = "Alper",
        LastName = "Tunga",
        Email = "alper.tunga@yazilim.academy"
    },
    new Student()
    {
        Id = 2,
        FirstName = "Mehmet",
        LastName = "Yılmaz",
        Email = "mehmet.yilmaz@hotmail.com"
    },
    new Student()
    {
        Id = 3,
        FirstName = "Ayşe",
        LastName = "Kaya",
        Email = "ayse.kaya@gmail.com"
    }
};

for (int i = attendees.Count - 1; i >= 0; i--)
{
    string fullName = $"{attendees[i].FirstName} {attendees[i].LastName}";

    if (i % 2 == 0)
    {
        Console.WriteLine("----------------");
    }
    
    Console.WriteLine(fullName);
}

foreach (Student attendee in attendees)
{
    Console.WriteLine(attendee.Email);
}


Console.ReadKey();