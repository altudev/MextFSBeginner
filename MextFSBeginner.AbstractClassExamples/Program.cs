using MextFSBeginner.AbstractClassExamples.Animals;
using MextFSBeginner.AbstractClassExamples.BaseClasses;

var dog = new Dog();

dog.MakeSound();

Console.WriteLine("\n----------------------------------------------\n");

var cat = new Cat();

cat.MakeSound();

Console.WriteLine("\n----------------------------------------------\n");

var bird = new Bird();

bird.MakeSound();

Console.WriteLine("\n----------------------------------------------\n");

var rabbit = new Rabbit();

rabbit.MakeSound();

Console.ReadLine();
