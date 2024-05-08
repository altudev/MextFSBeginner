//// Show a welcome message and a menu to the user

//using MextFSBeginner.ConsoleClient.Enums;

//Console.WriteLine("PowerpuffGirls Hesap Makinesine Hos Geldiniz!!!");

//// Select the operation

//string operationText = ReadOperationTypeFromTheUser();

//CalculatorOperationType operationType;

//while (!Enum.TryParse(operationText, out operationType))
//{
//    operationText = ReadOperationTypeFromTheUser();
//}

//if (operationType == CalculatorOperationType.None)
//{
//    Console.WriteLine("Kararsiz insanlar icin hesaplama yapamiyoruz. Lutfen aklinizi basiniza toplayin.");
//    Environment.Exit(0);
//}


//// Read the numbers from the user
//// Read the number 1 from the user
//string number1Text = ReadNumberFromTheUser(true);

//int number1 = 0;

//while (!int.TryParse(number1Text, out number1))
//{
//    number1Text = ReadNumberFromTheUser(true);
//}

//// Read the number 2 from the user
//string number2Text = ReadNumberFromTheUser(false);

//int number2 = 0;

//while (!int.TryParse(number2Text, out number2))
//{
//    number2Text = ReadNumberFromTheUser(false);
//}


//double result = 0;
//string translatedOperationType = "";


//// Check the operation type
//// Sum / Toplama
//if (operationType == CalculatorOperationType.Add)
//{
//    result = number1 + number2;
//    translatedOperationType = "Toplama";
//}
//// Subtract / Cikarma
//else if (operationType == CalculatorOperationType.Subtract)
//{
//    result = number1 - number2;
//    translatedOperationType = "Cikarma";
//}
//// Multiply / Carpma
//else if (operationType == CalculatorOperationType.Multiply)
//{
//    result = number1 * number2;
//    translatedOperationType = "Carpma";
//}
//// Divide / Bolme
//else if (operationType == CalculatorOperationType.Divide)
//{
//    if (number2 == 0)
//    {
//        Console.WriteLine("Bir sayi sifira bolunemez. Lutfen gecerli bir sayi giriniz.");
//        Environment.Exit(0);
//    }
//    result = number1 / number2;
//    translatedOperationType = "Bolme";
//}


//Console.WriteLine($"Islem:{translatedOperationType} - Islem sonucu:{result}");

//Console.ReadKey();

//string ReadOperationTypeFromTheUser()
//{
//    Console.WriteLine("1-) Toplama");
//    Console.WriteLine("2-) Cikarma");
//    Console.WriteLine("3-) Carpma");
//    Console.WriteLine("4-) Bolme");
//    Console.WriteLine("5-) Hicbiri");

//    // Read the operation from the user
//    string operationText = Console.ReadLine();

//    return operationText;
//}

//string ReadNumberFromTheUser(bool isFirstNumber)
//{
//    if (isFirstNumber)
//    {
//        Console.WriteLine("Lutfen ilk sayiyi giriniz:");
//    }
//    else
//    {
//        Console.WriteLine("Lutfen ikinci sayiyi giriniz:");
//    }

//    string numberText = Console.ReadLine();

//    return numberText;
//}

