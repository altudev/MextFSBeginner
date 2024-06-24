using SQLiteExamples.Common;

namespace SQLiteExamples.Entities;

public class Category:EntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }
}