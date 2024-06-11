namespace MextFSBeginner.Domain.Services
{
    public class ErrorLogManager2
    {
        public void Log(string exceptionMessage)
        {
            var filePath = "C:\\Users\\alper\\Desktop\\Hatalar.txt";

            var seperator = "-------------------------------------------";

            var generalMessage = "Uygulamada beklenmedik bir hata olustu. Lutfen tekrar deneyiniz.";

            var finalMessage = $"{seperator}\n{generalMessage}\n{exceptionMessage}\n{seperator}\n";

            File.AppendAllText(filePath, finalMessage);
        }
    }
}
