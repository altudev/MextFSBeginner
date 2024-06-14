using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;

namespace MextFSBeginner.Entities
{
    public class ConsoleLogger: LoggerBase
    {
        public override double TaxRate { get; set; } = 0.18d;
        public ConsoleColor TextColour { get; set; }

        public ConsoleLogger(string name, ConsoleColor textColour)
        {
            Name = name;

           TextColour=textColour;

           Console.ForegroundColor = TextColour;
        }

        public override void Log(string message, LogType logType)
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
