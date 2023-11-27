using System;

public delegate T ArithmeticOperation<T>(T num1, T num2);

class Calculator
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            Console.WriteLine("Enter two numbers:");
            double num1 = GetNumberFromUser("Enter the first number: ");
            double num2 = GetNumberFromUser("Enter the second number: ");

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            int choice = GetChoiceFromUser();

            if (choice == 5)
            {
                break;
            }

            ArithmeticOperation<double> operation = null;

            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                case 4:
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;
            }

            double result = calculator.PerformOperation(operation, num1, num2);
            Console.WriteLine($"Result: {result}");
        }
    }

    private static double GetNumberFromUser(string message)
    {
        double number;
        do
        {
            Console.Write(message);
        } while (!double.TryParse(Console.ReadLine(), out number));

        return number;
    }

    private static int GetChoiceFromUser()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        return choice;
    }

    private static double Add(double a, double b)
    {
        return a + b;
    }

    private static double Subtract(double a, double b)
    {
        return a - b;
    }

    private static double Multiply(double a, double b)
    {
        return a * b;
    }

    private static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
            return 0;
        }

        return a / b;
    }

    private T PerformOperation<T>(ArithmeticOperation<T> operation, T num1, T num2)
    {
        return operation(num1, num2);
    }
}

