void CalculatorApp()
{
    //Declare the integers
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    //this collects the numbers the user wants to calculate
    Console.WriteLine("Enter the first number:");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number:");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // a loop will be used to make the correct decision
    // this will perform the relevant operation
    Console.WriteLine("Choose one of the options from the following list.");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Dvision");
    Console.WriteLine("4 - Multiplication");

    //this will read the option selected by the user
    choice = Convert.ToInt32(Console.ReadLine());

    //an if statement is used to help decide what will be sent to the user and perform the calculation
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid option between 1- 4");
    }
}

CalculatorApp();
//testing sync