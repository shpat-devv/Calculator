using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            var options = Constants.Options;

            while (true)
            {
                Console.WriteLine("Hello User, choose your option: \n");
                Helper.PrintOptions();

                var userInput = Helper.ReadNumInput();

                if (!options.ContainsKey(userInput))
                {
                    Console.WriteLine("\nInvalid option. Please choose a valid option from the menu.\n");
                    continue;
                }

                if (userInput == Constants.Exit)
                {
                    break;
                }

                if (userInput == Constants.History)
                {
                    var hasHistory = false;
                    foreach (var operation in calc.GetHistory())
                    {
                        Console.WriteLine($"\n{operation}");
                        hasHistory = true;
                    }

                    if (!hasHistory)
                    {
                        Console.WriteLine("\nNo calculations in history.");
                    }

                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("\nChoose first number: ");
                var firstNum = Helper.ReadNumInput();

                Console.WriteLine("Choose second number: ");
                var secondNum = Helper.ReadNumInput();

                if (userInput == Constants.Div && secondNum == 0)
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.\n");
                    continue;
                }

                int res;
                switch (userInput)
                {
                    case Constants.Add:
                        res = calc.Add(firstNum, secondNum);
                        break;
                    case Constants.Sub:
                        res = calc.Sub(firstNum, secondNum);
                        break;
                    case Constants.Mul:
                        res = calc.Mul(firstNum, secondNum);
                        break;
                    case Constants.Div:
                        res = calc.Div(firstNum, secondNum);
                        break;
                    default:
                        Console.WriteLine("\nUnknown operation.\n");
                        continue;
                }

                calc.AddHistory(firstNum, secondNum, userInput, res);

                Console.WriteLine($"\nResult: {res}, \nContinue? (y/n)");

                var continueInput = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(continueInput) && continueInput.StartsWith("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    Console.Clear();
                }
                catch
                {
                    // Ignore error if console cannot be cleared (e.g. redirected output)
                }
            }
        }
    }
}