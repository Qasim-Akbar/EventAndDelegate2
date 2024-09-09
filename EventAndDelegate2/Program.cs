
using EventAndDelegate2;

MathOperations mathOperations = new MathOperations();
ResultDisplay resultDisplay = new ResultDisplay();

mathOperations.AdditionPerformed += resultDisplay.AdditionHandler;
mathOperations.SubtractionPerformed += resultDisplay.SubtractionHandler;
mathOperations.MultiplicationPerformed += resultDisplay.MultiplicationHandler;
mathOperations.DivisionPerformed += resultDisplay.DivisionHandler;

while (true)

{

    Console.WriteLine("\nEnter the first number:");

    if (!double.TryParse(Console.ReadLine(), out double num1))

    {

        Console.WriteLine("Invalid input. Please enter a valid number.");

        continue;

    }

    Console.WriteLine("Enter the second number:");

    if (!double.TryParse(Console.ReadLine(), out double num2))

    {

        Console.WriteLine("Invalid input. Please enter a valid number.");

        continue;

    }

    Console.WriteLine("Select the operation (+, -, *, /) or 'exit' to end:");

    string operation = Console.ReadLine().ToLower();

    if (operation.Equals("exit"))

        break;

    switch (operation)

    {

        case "+":

            mathOperations.Add(num1, num2);

            break;

        case "-":

            mathOperations.Subtract(num1, num2);

            break;

        case "*":

            mathOperations.Multiply(num1, num2);

            break;

        case "/":

            mathOperations.Divide(num1, num2);

            break;

        default:

            Console.WriteLine("Invalid operation. Please enter +, -, *, /, or exit.");

            break;

    }

}

mathOperations.AdditionPerformed -= resultDisplay.AdditionHandler;
mathOperations.SubtractionPerformed -= resultDisplay.SubtractionHandler;
mathOperations.MultiplicationPerformed -= resultDisplay.MultiplicationHandler;
mathOperations.DivisionPerformed -= resultDisplay.DivisionHandler;