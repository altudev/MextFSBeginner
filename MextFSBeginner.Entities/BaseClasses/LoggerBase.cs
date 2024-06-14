using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities.BaseClasses
{
    public abstract class LoggerBase
    {
        public virtual double TaxRate { get; set; }
        public virtual string Name { get; set; }
        public abstract void Log(string message, LogType logType);

        public virtual void LogToConsole(string message, LogType logType)
        {
            if (logType == LogType.Error)
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Hata! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                Console.WriteLine(finalMessage);
            }
            else if (logType == LogType.Warning)
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Uyari! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                Console.WriteLine(finalMessage);
            }
            else
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Bilgi! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                Console.WriteLine(finalMessage);
            }
        }
    }
}
