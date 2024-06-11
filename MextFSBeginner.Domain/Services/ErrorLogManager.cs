namespace MextFSBeginner.Domain.Services
{
    public class ErrorLogManager
    {
        public void Log(string exceptionMessage)
        {
           var filePath = "C:\\Users\\alper\\Desktop\\Hatalar.txt";

           var seperator = "--------------------------------------------------";

           var generalMessage = "Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.";

           var todayDate = DateTime.Now;

           var message = $"{seperator}\n{generalMessage}\n{exceptionMessage}\n{todayDate}\n{seperator}\n";

           File.AppendAllText(filePath,message);
        }

        public void LogInfo(string infoMessage)
        {
            var filePath = "C:\\Users\\alper\\Desktop\\Hatalar.txt";

            var seperator = "--------------------------------------------------";

            var todayDate = DateTime.Now;

            var message = $"{seperator}\nBILGI\n{infoMessage}\n{todayDate}\n{seperator}\n";

            File.AppendAllText(filePath, message);
        }
    }
}
