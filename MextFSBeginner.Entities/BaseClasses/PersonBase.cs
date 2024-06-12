namespace MextFSBeginner.Entities.BaseClasses
{
    public class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string FullInfo => $"{FullName} - {IdentityNumber}";
    }
}
