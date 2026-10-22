using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Calculator
    {
        List<int> history = new List<int>();

        public void AddHistory(int firstNum, int secondNum, int operation, int result)
        {
            history.Add(firstNum);
            history.Add(operation);
            history.Add(secondNum);
            history.Add(result);
        }
        
        //Continuously feed operations to reader 
        public IEnumerable<string> GetHistory()
        {
            var options = Constants.Options;
            string operation = "";
            int currentOperationIndex = 0;
            
            for (int i = 0; i < history.Count; i++)
            {
                if (currentOperationIndex % 2 != 0)
                {
                    if (currentOperationIndex == 1)
                    {
                        operation += options[history[i]];
                    }

                    else if (currentOperationIndex == 3)
                    {
                        operation += "=" + history[i];
                        yield return operation;
                        operation = "";
                        currentOperationIndex = -1;
                    }
                }

                else
                {
                    operation += history[i].ToString();
                }
              
                currentOperationIndex++;
            }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}