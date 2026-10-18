using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
  internal static class Program
  {
    private static readonly Dictionary<int, string> Options = new Dictionary<int, string>
    {
      {1, "+"},
      {2, "-"},
      {3, "*"},
      {4, "/"},
      {5, "History"},
      {6, "Exit"},
    };

    public static void Main(string[] args)
    {
      var calc = new Calculator();
      
      List<int> history = new List<int>();
      
      while (true)
      {
        Console.WriteLine("Hello User, choose your option: \n");

        foreach (KeyValuePair<int, string> option in Options) Console.WriteLine($"{option.Key}, {option.Value}");

        int userInput = ReadNumInput();
          
        if (Options.ContainsKey(userInput))
        {
          if (Options[userInput] == "Exit")
          {
            break;
          }
          
          if (Options[userInput] == "History")
          {
            string operation = "";
            int currentOperationIndex = 0;
            
            for (int i = 0; i < history.Count; i++)
            {
              if (currentOperationIndex % 2 != 0)
              {
                if (currentOperationIndex == 1)
                {
                  operation += Options[history[i]];
                }

                else if (currentOperationIndex == 3)
                {
                  operation += "=" + history[i];
                  Console.WriteLine($"\n{operation}");
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
            
            continue;
          }
          
          Console.WriteLine("\nChoose first number: ");
          var firstNum = ReadNumInput();

          Console.WriteLine("Choose second number: ");
          var secondNum = ReadNumInput();
          
          var res = 0;
          
          switch(userInput)
          {
            case 1:
              res = calc.Add(firstNum, secondNum);
              break;
            case 2:
              res = calc.Sub(firstNum, secondNum);
              break;
            case 3:
              res = calc.Mul(firstNum, secondNum);
              break;
            case 4:
              res = calc.Div(firstNum, secondNum);
              break;
          }
          
          Console.WriteLine($"\nResult: {res}, \nContinue? (y/n)");
          
          if (Console.ReadKey().Key == ConsoleKey.N){
            break;
          }
          
          AddHistory(history, firstNum, secondNum, userInput, res);
          
          Console.Clear();
        } 
      }
    }

    private static void AddHistory(List<int> history, int firstNum, int secondNum, int operation, int result)
    {
      history.Add(firstNum);
      history.Add(operation);
      history.Add(secondNum);
      history.Add(result);
    }

    private static int ReadNumInput()
    {
      while (true)
      {
        try
        {
          int userInput = int.Parse(Console.ReadLine());
          return userInput;
        }

        catch (FormatException)
        {
          Console.WriteLine("Please Enter Valid Number.");
        }
      }
    }
  }
}