using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities
{
    public class Employee : PersonBase, IPerson
    {
        public EmployeeType Type { get; set; }
        public string Email { get; set; }
    }
}
