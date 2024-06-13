using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities.BaseClasses
{
    public class LogBase
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public LogType Type { get; set; }
        public bool IsImportant { get; set; }
    }
}
