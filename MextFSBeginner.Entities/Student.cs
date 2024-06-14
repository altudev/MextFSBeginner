using System.Security.AccessControl;
using MextFSBeginner.Entities.BaseClasses;

namespace MextFSBeginner.Entities
{
    public class Student : PersonBase
    {
        public int No { get; set; } // 671

        public override string FullInfo => $"Ogrenci => {FullName} - {IdentityNumber}";

        public override string FullName => $"{No} - {FirstName} {LastName}";
    }
}
