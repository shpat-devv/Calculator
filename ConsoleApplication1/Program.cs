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

                var operation = Helper.ReadNumInput();

                if (!options.ContainsKey(operation))
                {
                    Console.WriteLine("\nInvalid option. Please choose a valid option from the menu.\n");
                    continue;
                }

                if (operation == Constants.Exit)
                {
                    break;
                }

                if (operation == Constants.History)
                {
                    var hasHistory = false;
                    foreach (var op in calc.GetHistory())
                    {
                        Console.WriteLine($"\n{op}");
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

                if (operation == Constants.Div && secondNum == 0)
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.\n");
                    continue;
                }

                var res = calc.HandleCalculation(firstNum, secondNum, operation);
                
                Console.WriteLine($"\nResult: {res}, \nContinue? (y/n)");
                calc.AddHistory(firstNum, secondNum, operation, res);
                
                var continueInput = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(continueInput) && continueInput.StartsWith("n", StringComparison.OrdinalIgnoreCase))
                {
                    calc.GetHistoryToFile();
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