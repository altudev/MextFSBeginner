// See https://aka.ms/new-console-template for more information

using MextFSBeginner.Domain.Entities;
using MextFSBeginner.Domain.Enums;

List<Student> attendees = new List<Student>()
{
    new Student()
    {
        Id = 1,
        FirstName = "Alper",
        LastName = "Tunga",
        Email = "alper.tunga@yazilim.academy",
        Gender = Gender.Male,
        Lesson = LessonType.Math,
        Score = 49
    },
    new Student()
    {
        Id = 2,
        FirstName = "Queen",
        LastName = "Elizabeth",
        Email = "queen.elizabet@hotmail.com",
        Gender = Gender.Female,
        Lesson = LessonType.History,
        Score = 100,
    },
    new Student()
    {
        Id = 3,
        FirstName = "Ayşe",
        LastName = "Kaya",
        Email = "ayse.kaya@gmail.com",
        Gender = Gender.Female,
        Lesson = LessonType.Literature,
        Score = 74
    },
    new Student()
    {
        Id = 4,
        FirstName = "Brad",
        LastName = "Pitt",
        Email = "brad.pitt@outlook.com",
        Gender = Gender.Male,
        Lesson = LessonType.Geography,
        Score = 32
    }
};

// for (int i = attendees.Count - 1; i >= 0; i--)
// {
//     string fullName = $"{attendees[i].FirstName} {attendees[i].LastName}";
//
//     if (i % 2 == 0)
//     {
//         Console.WriteLine("----------------");
//     }
//     
//     Console.WriteLine(fullName);
// }
//
// foreach (Student attendee in attendees)
// {
//     Console.WriteLine(attendee.Email);
// }

// foreach (Student student in attendees)
// {
//     string genderTurkish = "";
//     
//     if (student.Gender == Gender.Female)
//     {
//         genderTurkish = "Kadin";
//     }
//     else
//     {
//         genderTurkish = "Erkek";
//     }
//     
//     Console.WriteLine($"{student.FirstName} {student.LastName} - {genderTurkish}");
// }

int score = 0;

bool continueChecking = true;

string userName = "";
bool isUserNameSet = false;

while (isUserNameSet == false)
{
   Console.WriteLine("Kullanici adi giriniz:");
   userName = Console.ReadLine();

   if (!string.IsNullOrEmpty(userName))
   {
       isUserNameSet = true;
       break;
   }
}


Console.ReadKey();