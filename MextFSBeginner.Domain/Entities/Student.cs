using MextFSBeginner.Domain.Enums;

namespace MextFSBeginner.Domain.Entities;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Gender  Gender { get; set; }
    public LessonType Lesson { get; set; }
    public int Score1 { get; set; }
    public int Score2 { get; set; }
    public int Score3 { get; set; }

    public string FavouriteLessonTurkish { get; set; }

    public Student(int score1, int score2, int score3)
    {
        Score1 = score1;
        
        Score2 = score2;
        
        Score3 = score3;
    }

    public double ScoresAverage
    {
        get
        {
            return (Score1 + Score2 + Score3) / 3;
        }
        
    }
    
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    
    public void WriteFullNameAndScores()
    {
        Console.WriteLine($"Ogrenci Adi: {FullName}, Notlar Ortalamasi: {ScoresAverage}");
    }
    
    public List<LessonType> Lessons { get; set; }
    public int Score { get; set; }
}