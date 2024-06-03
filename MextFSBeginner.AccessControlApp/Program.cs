// See https://aka.ms/new-console-template for more information

using MextFSBeginner.Domain.Entities;

Console.WriteLine("Hello, World!");

AccessControlLog accessControlLog = new AccessControlLog(25,"Alper","Tunga");

Console.WriteLine($"{accessControlLog.FirstName} {accessControlLog.LastName}");

Console.WriteLine(accessControlLog.FullName);
