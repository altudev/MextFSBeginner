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
}