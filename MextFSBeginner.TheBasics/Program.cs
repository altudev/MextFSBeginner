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

Console.WriteLine("Lutfen bir renk numarasi seciniz.");

var colourChoice = Enum.Parse<Colour>(Console.ReadLine());

switch (colourChoice)
{
    case Colour.Kirmizi:
        Console.BackgroundColor = ConsoleColor.Red;
        break;
    
    case Colour.Mavi:
        Console.BackgroundColor = ConsoleColor.Blue;
        break;
    
    case Colour.Sari:
        Console.BackgroundColor = ConsoleColor.Yellow;
        break;
    
    case Colour.Turuncu:
        Console.BackgroundColor = ConsoleColor.Magenta;
        break;
    
    case Colour.Yesil:
        Console.BackgroundColor = ConsoleColor.Green;
        break;
    
    case Colour.Siyah:
        Console.BackgroundColor = ConsoleColor.Black;
        break;
    
    case Colour.Beyaz:
        Console.BackgroundColor = ConsoleColor.White;
        break;
}

Console.Clear();

if (colourChoice == Colour.Beyaz)
{
    Console.ForegroundColor = ConsoleColor.Black;
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("Renk seciminiz basarili.");

// if (colourChoice == Colour.Kirmizi)
// {
//     
// }else if (colourChoice == Colour.Mavi)
// {
//     
// }
// else if (colourChoice == Colour.Sari)
// {
//     
// }== 
// else if (colourChoice Colour.Turuncu)
// {
//     
// }
// else if (colourChoice == Colour.Yesil)
// {
//     
// }
// else if (colourChoice == Colour.Siyah)
// {
//     
// }
// else if (colourChoice == Colour.Beyaz)
// {
//     
// }
// else
// {
//     Console.WriteLine("Gecersiz renk numarasi girdiniz.");
// }

Console.ReadKey();