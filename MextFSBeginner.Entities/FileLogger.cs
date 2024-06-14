using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities
{
    public class FileLogger: LoggerBase
    {
        public override double TaxRate { get; set; } = 0.20d;
        public string Path { get; set; }
        public override string Name { get; set; } = "FileLogger";

        public FileLogger(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public override void Log(string message, LogType logType)
        {
            if (logType == LogType.Error)
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Hata! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                File.AppendAllText(Path, finalMessage);
            }
            else if (logType == LogType.Warning)
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Uyari! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                File.AppendAllText(Path, finalMessage);
            }
            else
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Bilgi! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                File.AppendAllText(Path, finalMessage);
            }
        }

        public override void LogToConsole(string message, LogType logType)
        {
            Console.WriteLine("Bu log FileLogger tarafindan console'a yazilmistir.");

            base.LogToConsole(message, logType);
        }
    }
}
