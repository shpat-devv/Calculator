using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class CalculationEntry
    {
        private int FirstNumber { get; }
        private int SecondNumber { get; }
        private int Operation { get; }
        private int Result { get; }

        public CalculationEntry(int firstNumber, int secondNumber, int operation, int result)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operation = operation;
            Result = result;
        }

        public override string ToString()
        {
            var symbol = Constants.Options.TryGetValue(Operation, out var op) ? op : "?";
            return $"{FirstNumber} {symbol} {SecondNumber} = {Result}";
        }
    }

    public class Calculator
    {
        private readonly List<CalculationEntry> _history = new List<CalculationEntry>();

        public void AddHistory(int firstNum, int secondNum, int operation, int result)
        {
            _history.Add(new CalculationEntry(firstNum, secondNum, operation, result));
        }
        
        public IEnumerable<string> GetHistory()
        {
            foreach (var entry in _history)
            {
                yield return entry.ToString();
            }
        }
        
        public void SaveHistoryToFile()
        {
            FileHandling handler = new FileHandling();
            string[] content = _history.Select(entry => entry.ToString()).ToArray(); //Convert history to array of strings
            
            handler.WriteHistory(content);
        }

        public void LoadHistoryFromFile()
        {
            FileHandling handler = new FileHandling();

            string content = handler.ReadHistory();
            
            if (String.IsNullOrEmpty(content))
                return;
            
            try
            {
                string[] history = handler.ReadHistory().Split(','); //Load file and separate calculations in history

                foreach (var entry in history)
                {
                    string[] parts = entry.Split(' '); //Spaces separate parts of a calculation

                    if (parts.Length != 5) 
                        continue;

                    int firstNum = int.Parse(parts[0]);
                    int secondNum = int.Parse(parts[2]);
                    var operation = Constants.Options.FirstOrDefault(x => x.Value == parts[1]).Key; //Get matching INT Key of operator
                    int result = int.Parse(parts[4]);

                    AddHistory(firstNum, secondNum, operation, result);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Formatting Issue with file: " + ex.Message);
                handler.ClearHistory();
            }
        }

        public int HandleCalculation(int firstNum, int secondNum, int operation)
        { 
            switch (operation)
            {
                case Constants.Add:
                    return Add(firstNum, secondNum);
                case Constants.Sub:
                    return Sub(firstNum, secondNum);
                case Constants.Mul:
                    return Mul(firstNum, secondNum);
                case Constants.Div:
                    return Div(firstNum, secondNum);
                default:
                    Console.WriteLine("\nUnknown operation.\n");
                    break;
            }

            return 0;
        }

        private static int Add(int a, int b) => a + b;

        private static int Sub(int a, int b) => a - b;

        private static int Mul(int a, int b) => a * b;

        private static int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }
    }
}