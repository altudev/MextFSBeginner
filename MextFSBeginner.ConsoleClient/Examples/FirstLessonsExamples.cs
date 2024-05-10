

//// If the password length is correct, generate a password

//PrintWelcomeMessages();

//// Read the entered value
//string passwordLengthText = Console.ReadLine();

//// Convert the entered value to integer
//int passwordLength = Convert.ToInt32(passwordLengthText);

//// Check whether the entered value between 6 and 25

//bool isPasswordLengthAcceptable = false;

//while (isPasswordLengthAcceptable == false)
//{
//    if (passwordLength < 6 || passwordLength > 25)
//    {
//        Console.WriteLine("The password length you've entered is not acceptable.");

//        // Ask user to enter the length of the password
//        Console.WriteLine("Lutfen sifrenizde istediginiz karakter uzunlugunu yazar misiniz?");


//        // Read the entered value
//        passwordLengthText = Console.ReadLine();

//        // Convert the entered value to integer
//        passwordLength = Convert.ToInt32(passwordLengthText);

//        if (passwordLength < 6 || passwordLength > 25)
//        {
//            continue;
//        }

//    }

//    isPasswordLengthAcceptable = true;
//}



//// Generate a password

//Random random = new Random();

//string password = "";

//for (int i = 0; i < passwordLength; i++)
//{
//    int randomNumber = random.Next(0, 10);

//    password += randomNumber;
//}

//Console.WriteLine($"Sifreniz:{password}");

//SayHello("Alper");


//void SayHello(string name)
//{
//    Console.WriteLine($"Merhaba {name}!");
//    Console.WriteLine($"Merhaba {name}!");
//    Console.WriteLine($"Merhaba {name}!");
//}

//int result = Sum(12, 13);

//Console.WriteLine(result);

//int Sum(int number1, int number2)
//{
//    int total = number1 + number2;

//    //Console.WriteLine(total);

//    return total;
//}

//void PrintWelcomeMessages()
//{
//    // Message to the User => Welcome to the Password Generator
//    Console.WriteLine("Powerpuff Girls Sifre Ureticisine Hos Geldiniz!");

//    // Ask user to enter the length of the password
//    Console.WriteLine("Lutfen sifrenizde istediginiz karakter uzunlugunu yazar misiniz?");
//}

