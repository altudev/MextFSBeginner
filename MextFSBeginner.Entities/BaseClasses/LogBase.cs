using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities.BaseClasses
{
    public abstract class LogBase
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public LogType Type { get; set; }
        public bool IsImportant { get; set; }

        public string GetLogType()
        {
            // Switch icin farkli bir kullanim ornegi.
            return Type switch
            {
                LogType.Info => "Information",
                LogType.Warning => "Warning",
                LogType.Error => "Error",
                _ => "Unknown"
            };
        }
    }
}
