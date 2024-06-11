using MextFSBeginner.Domain.Enums;

namespace MextFSBeginner.Domain.Services
{
    public class LogManager
    {
        public void Log(string message, LogType logType)
        {
            // true => Error
            // false => Info

            var hataLoglariFilePath = "C:\\Users\\alper\\Desktop\\HataLoglari.txt";

            var bilgiLoglariFilePath = "C:\\Users\\alper\\Desktop\\BilgiLoglari.txt";


            if (logType == LogType.Error)
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Hata! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                File.AppendAllText(hataLoglariFilePath, finalMessage);
            }
            else
            {
                var seperator = "--------------------------------------------------";

                var todayDate = DateTime.Now;

                var generalMessage = $"Bilgi! - {todayDate}";

                var finalMessage = $"{seperator}\n{generalMessage}\n{message}\n{seperator}\n";

                File.AppendAllText(bilgiLoglariFilePath, finalMessage);
            }
        }
    }
}
