using SQLiteExamples.Common;
using SQLiteExamples.Enums;

namespace SQLiteExamples.Entities;

public class Product:EntityBase
{
    public string Name { get; set; }

    public Colour Colour { get; set; }

    public Size Size { get; set; }
    
    public decimal Price { get; set; }
}