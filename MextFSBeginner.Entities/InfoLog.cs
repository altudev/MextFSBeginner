using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities
{
    public class InfoLog:LogBase
    {
        public InfoLog()
        {
            Type = LogType.Info;

            IsImportant = false;
        }
    }
}
