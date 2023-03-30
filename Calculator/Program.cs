
using Calculator.Interfaces;

class CalculatorApp
{
    static void Main()
    {
        // Get user input for the two numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Get user input for the operator
        Console.Write("Enter the operator (+, -, *, /): ");
        string? opInput = Console.ReadLine();

        // Check if the opInput string is null or empty
        if (string.IsNullOrEmpty(opInput))
        {
            throw new ArgumentException("Operator input cannot be null or empty");
        }

        // Get the operator char from the opInput string
        char op = opInput[0];

        // Declare the equation variable and initialize it based on the user's choice of operator
        IEquation equation;
        if (op == '+')
        {
            equation = new Addition();
        }
        // else if (op == '-')
        // {
        //     equation = new Subtraction();
        // }
        // else if (op == '*')
        // {
        //     equation = new Multiplication();
        // }
        // else if (op == '/')
        // {
        //     equation = new Division();
        // }
        // else
        // {
        //     throw new ArgumentException("Invalid operator");
        // }

        // Calculate the result using the chosen equation object and print it to the console
        // double result = equation.Perform(num1, num2);
        Console.WriteLine($"Result: {result}");
    }
}