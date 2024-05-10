//bool exit = false;

//while (!exit)
//{
//    Console.WriteLine("Calculator Menu:");
//    Console.WriteLine("1. Sum");
//    Console.WriteLine("2. Subtract");
//    Console.WriteLine("3. Multiply");
//    Console.WriteLine("4. Divide");
//    Console.WriteLine("5. Exit");
//    Console.Write("Enter your choice (1-5): ");
//    string choice = Console.ReadLine();

//    if (choice == "5")
//    {
//        exit = true;
//        Console.WriteLine("Exiting the calculator. Goodbye!");
//    }
//    else if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
//    {
//        int num1, num2;

//        Console.Write("Enter the first number: ");
//        if (!int.TryParse(Console.ReadLine(), out num1))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            continue;
//        }

//        Console.Write("Enter the second number: ");
//        if (!int.TryParse(Console.ReadLine(), out num2))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            continue;
//        }

//        int result;

//        switch (choice)
//        {
//            case "1":
//                result = num1 + num2;
//                Console.WriteLine($"Sum: {num1} + {num2} = {result}");
//                break;
//            case "2":
//                result = num1 - num2;
//                Console.WriteLine($"Subtraction: {num1} - {num2} = {result}");
//                break;
//            case "3":
//                result = num1 * num2;
//                Console.WriteLine($"Multiplication: {num1} * {num2} = {result}");
//                break;
//            case "4":
//                if (num2 == 0)
//                {
//                    Console.WriteLine("Error: Division by zero is not allowed.");
//                }
//                else
//                {
//                    result = num1 / num2;
//                    Console.WriteLine($"Division: {num1} / {num2} = {result}");
//                }
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
//    }

//    Console.WriteLine();
//}