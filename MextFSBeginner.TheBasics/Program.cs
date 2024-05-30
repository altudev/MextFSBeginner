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
        Score = 49,
        Lessons = new List<LessonType>()
        {
            LessonType.Math,
            LessonType.Science,
            LessonType.History
        }
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
        Lessons = new List<LessonType>()
        {
            LessonType.History,
            LessonType.Literature
        }
    },
    new Student()
    {
        Id = 3,
        FirstName = "Ayşe",
        LastName = "Kaya",
        Email = "ayse.kaya@gmail.com",
        Gender = Gender.Female,
        Lesson = LessonType.Math,
        Score = 74,
        Lessons = new List<LessonType>()
        {
            LessonType.Literature,
            LessonType.Geography,
            LessonType.Science,
            LessonType.Math
        }
    },
    new Student()
    {
        Id = 4,
        FirstName = "Brad",
        LastName = "Pitt",
        Email = "brad.pitt@outlook.com",
        Gender = Gender.Male,
        Lesson = LessonType.Geography,
        Score = 32,
        Lessons = new List<LessonType>()
        {
            LessonType.Geography,
            LessonType.Math
        }
    }
};

// Ogrenci: Alper Tunga - Favori Dersi: Math
// Aldigi dersler sunlardir: Math, Science, History

foreach (var student in attendees)
{
    Console.WriteLine($"Ogrenci: {student.FirstName} {student.LastName} - Favori Dersi: {student.Lesson}");

    string allLessons = "";
    
    foreach (var lesson in student.Lessons)
    {
        allLessons += $" {lesson},";    
    }
    
    Console.WriteLine($"Aldigi dersler sunlardir: {allLessons}");
}

Console.ReadKey();