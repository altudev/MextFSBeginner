using MextFSBeginner.AbstractClassExamples.Enums;

namespace MextFSBeginner.AbstractClassExamples.BaseClasses
{
    public abstract class AnimalBase
    {
        public virtual string Name { get; set; } // override Name => "Kedi", "Kopek", "Inek", "Kus", "Balik"
        public virtual string Sound { get; set; }
        public virtual int LegCount { get; set; } = 4;
        public virtual bool IsPet { get; set; }
        public virtual AnimalGender Gender { get; set; }

        public string GetFancyName()
        {
            // Ternary Operator
            return Gender == AnimalGender.Male ? $"Mr. {Name}" : $"Mrs. {Name}";
        }

        public abstract void MakeSound(); // Cat => Meow, Dog => Bark, Cow => Moo, Bird => Tweet, Fish => Blub

    }
}
