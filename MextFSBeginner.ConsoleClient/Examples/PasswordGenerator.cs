namespace MextFSBeginner.ConsoleClient.Examples
{
    public class PasswordGenerator
    {
        public string Name = "";

        public int PasswordLength = 0;

        public void SetPasswordLength()
        {
            // Read the entered value
            string passwordLengthText = Console.ReadLine();

            // Convert the entered value to integer
            PasswordLength = Convert.ToInt32(passwordLengthText);
        }

        public void SetName(string name)
        {
            Name = name;
        }

        //void PrintWelcomeMessages()
        //{
        //    // Message to the User => Welcome to the Password Generator
        //    Console.WriteLine("Powerpuff Girls Sifre Ureticisine Hos Geldiniz!");

        //    // Ask user to enter the length of the password
        //    Console.WriteLine("Lutfen sifrenizde istediginiz karakter uzunlugunu yazar misiniz? <3");
        //}
    }
}
