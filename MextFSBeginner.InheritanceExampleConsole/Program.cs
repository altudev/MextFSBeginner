
using MextFSBeginner.Entities;
using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

var teacher = new Teacher()
{
    FirstName = "Alper",
    LastName = "Tunga",
    IdentityNumber = "123456789052342345",
};

var student = new Student()
{
    FirstName = "Sena",
    LastName = "Tasci",
    No = 100,
    IdentityNumber = "52367342567890"
};

var parent = new Parent()
{
    FirstName = "Seyda Nur",
    LastName = "Tasci",
    IdentityNumber = "1234567890",
};

var securtyEmployee = new Employee()
{
    FirstName = "Mehmet",
    LastName = "Tasci",
    Type = EmployeeType.Security,
    IdentityNumber = "4658373534243"
};

var cleanerEmployee = new Employee()
{
    FirstName = "Francheska",
    LastName = "Tunga",
    Type = EmployeeType.Cleaner
};

List<object> people = new List<object>();

people.Add(teacher);

people.Add(2.29d);

people.Add(student);

people.Add(125);

people.Add(parent);

people.Add(999.99M);

people.Add(securtyEmployee);

people.Add(cleanerEmployee);

people.Add("rtsdfsdfklnsdfsdfsfd");


Console.WriteLine("Balo Katilimcilari Listesi:");

foreach (var person in people)
{
    if (person is PersonBase)
    {
        var personBase = person as PersonBase;

        Console.WriteLine(personBase.FullInfo);
    }
    else
    {
        Console.WriteLine("Gelen deger gecerli degil. Baloya katilim saglanmayacaktir.");
    }
}

Console.ReadLine();

