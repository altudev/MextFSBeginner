
using MextFSBeginner.Entities;
using MextFSBeginner.Entities.Enums;
using MextFSBeginner.Entities.Helpers;

var teacher = new Teacher()
{
    FirstName = "Alper",
    LastName = "Tunga",
    IdentityNumber = "123456789052342345",
};

var parent = new Parent()
{
    FirstName = "Seyda Nur",
    LastName = "Tasci",
    IdentityNumber = "1234567890",
};

var newParent = Parent.CreateParent(teacher);

var student = new Student()
{
    FirstName = "Sena",
    LastName = "Tasci",
    No = 100,
    IdentityNumber = "52367342567890"
};



teacher = parent;

var securityEmployee = new Employee()
{
    FirstName = "Mehmet",
    LastName = "Tasci",
    Type = EmployeeType.Security,
    IdentityNumber = "4658373534243"
};

securityEmployee.IdentityNumber = "!23145123";

var cleanerEmployee = new Employee()
{
    FirstName = "Francheska",
    LastName = "Tunga",
    Type = EmployeeType.Cleaner
};

List<object> people = new List<object>();


people.Add(2.29d); // double

people.Add(21.39d); // double

people.Add(teacher); // Teacher

people.Add(teacher); // Teacher

people.Add(student); // Student

people.Add(student); // Student


people.Add(teacher); // Teacher

people.Add(teacher); // Teacher

people.Add(2.29d); // double

people.Add(student); // Student

people.Add(9399.559M); // decimal

people.Add(125); // int32


people.Add(parent); // parent

people.Add(teacher); // Teacher

people.Add(305); // int32

people.Add(999.9999M); // decimal

people.Add(securityEmployee); // Employee

people.Add(7255125); // int32

people.Add(cleanerEmployee); // Employee

people.Add("rtsdfsdfklnsdfsdfsfd"); // string


Console.WriteLine("Balo Katilimcilari Listesi:");

var teacherCount = 0;
var studentCount = 0;

double price =500;

double taxAmount = TaxCalculator.CalculateTax(price);

double taxedPrice = price + taxAmount;

Console.WriteLine(Messages.WelcomeMessage);

Console.WriteLine($"Vergisiz Fiyat={price}, Vergi Miktari={taxAmount}, Son Fiyat={taxedPrice}");

Console.WriteLine(Messages.GoodbyeMessage);



foreach (var person in people)
{
    if (person is Teacher)
        teacherCount++;

    if (person is Student)
        studentCount++;

    if (person is Employee)
    {
        var employee = person as Employee;
    }

    if(person is double)
    {
        var doubleValue = (double)person;
    }

}

Console.WriteLine(teacherCount);

// Teacher => 4 tane bulundu.
// double => 3 tane bulundu.
// int => 7 tane bulundu.
// Empoyee => 2 tane bulundu.
// string => 1 tane bulundu.


Console.ReadLine();

