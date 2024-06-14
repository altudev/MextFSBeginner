namespace MextFSBeginner.Entities.BaseClasses
{
    public abstract class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        public virtual string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public abstract string FullInfo { get; }
    }
}
