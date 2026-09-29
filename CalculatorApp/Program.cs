using System.Linq.Expressions;

void CalculatorApp()
{
  
    try
    {
        //this collects the numbers the user wants to calculate
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // a loop will be used to make the correct decision
        // this will perform the relevant operation
        Console.WriteLine("Enter the operation (+, -, *, /):");

        //this will collect the operation the user wants to perform
        var operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
        }
        Console.WriteLine($"Result: {result}");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}. Please enter a valid operation.");
    }

}
CalculatorApp();