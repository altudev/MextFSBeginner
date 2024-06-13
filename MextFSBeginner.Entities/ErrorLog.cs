using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities
{
    public class ErrorLog:LogBase
    {
        public string LongDescription { get; set; }

        public ErrorLog()
        {
            Type = LogType.Error;

            IsImportant = true;
        }
    }
}
