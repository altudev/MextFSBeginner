using MextFSBeginner.Entities.BaseClasses;

namespace MextFSBeginner.Entities
{
    public class Teacher : PersonBase
    {
        public Teacher()
        {
            LastName = FullInfo;
        }

        public static implicit operator Teacher(Parent parent)
        {
           return new Teacher()
           {
               FirstName = parent.FirstName,
               LastName = parent.LastName,
               IdentityNumber = parent.IdentityNumber
           };
        }
    }
}
