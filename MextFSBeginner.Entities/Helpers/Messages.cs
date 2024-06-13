namespace MextFSBeginner.Entities.Helpers
{
    public static class Messages
    {
        public static string WelcomeMessage => "Hos geldiniz!";
        public static string GoodbyeMessage => "Kendinize iyi bakin!";

        public static string GetWelcomeMessage(string languageCode)
        {
            switch (languageCode)
            {
                case "tr-TR":
                    return "Hos geldiniz!";
                case "en-US":
                    return "Welcome!";
                case "de-DE":
                    return "Willkommen!";

                default:
                    return "Welcome!";
            }
        }
    }
}
