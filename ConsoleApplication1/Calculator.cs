using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class CalculationEntry
    {
        public int FirstNumber { get; }
        public int SecondNumber { get; }
        public int Operation { get; }
        public int Result { get; }

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

        public int HandleCalculation(int userInput);
        {
            
        }

        public int Add(int a, int b) => a + b;

        public int Sub(int a, int b) => a - b;

        public int Mul(int a, int b) => a * b;

        public int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }
    }
}