using MextFSBeginner.Entities.BaseClasses;

namespace MextFSBeginner.Entities
{
    public class Parent : PersonBase
    {
        public static Parent CreateParent(Teacher teacher)
        {
            return new Parent()
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                IdentityNumber = teacher.IdentityNumber
            };
        }
    }
}
