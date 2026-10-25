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
        
        public void ClearHistory()
        {
            _history.Clear();
        }
        
        public void GetHistoryToFile()
        {
            FileHandling handler = new FileHandling();
            string[] content = _history.Select(entry => entry.ToString()).ToArray();
            
            handler.WriteHistory(content);
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