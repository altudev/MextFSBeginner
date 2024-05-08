// Show a welcome message and a menu to the user

Console.WriteLine("PowerpuffGirls Hesap Makinesine Hos Geldiniz!!!");

// Select the operation

string operationText = ReadOperationTypeFromTheUser();

int operationType = 0;

while (!int.TryParse(operationText, out operationType))
{
    operationText = ReadOperationTypeFromTheUser();
}

// Read the numbers from the user
// Read the number 1 from the user
string number1Text = ReadNumberFromTheUser(true);

int number1 = 0;

while (!int.TryParse(number1Text, out number1))
{
    number1Text = ReadNumberFromTheUser(true);
}

// Read the number 2 from the user
string number2Text = ReadNumberFromTheUser(false);

int number2 = 0;

while (!int.TryParse(number2Text, out number2))
{
    number2Text = ReadNumberFromTheUser(false);
}



//// Check the operation type
//// Sum / Toplama
//if (operationType == 1)
//{
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());
//}
//// Subtract / Cikarma
//else if (operationType == 2)
//{
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());
//}
//// Multiply / Carpma
//else if (operationType == 3)
//{
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());
//}
//// Divide / Bolme
//else if (operationType == 4)
//{
//    int number1 = Convert.ToInt32(Console.ReadLine());
//    int number2 = Convert.ToInt32(Console.ReadLine());
//}


Console.WriteLine($"Operasyon basariyla alindi. {operationType}");

Console.ReadKey();

string ReadOperationTypeFromTheUser()
{
    Console.WriteLine("1-) Toplama");
    Console.WriteLine("2-) Cikarma");
    Console.WriteLine("3-) Carpma");
    Console.WriteLine("4-) Bolme");
    Console.WriteLine("5-) Hicbiri");

    // Read the operation from the user
    string operationText = Console.ReadLine();

    return operationText;
}

string ReadNumberFromTheUser(bool isFirstNumber)
{
    if (isFirstNumber)
    {
        Console.WriteLine("Lutfen ilk sayiyi giriniz:");
    }
    else
    {
        Console.WriteLine("Lutfen ikinci sayiyi giriniz:");
    }

    string numberText = Console.ReadLine();

    return numberText;
}

