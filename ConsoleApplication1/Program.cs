using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
  internal static class Program
  {
    private static readonly Dictionary<int, string> Options = new Dictionary<int, string>
    {
      {1, "Add"},
      {2, "Sub"},
      {3, "Mul"},
      {4, "Div"},
      {5, "Exit"},
    };

    public static void Main(string[] args)
    {
      var calc = new Calculator();

      while (true)
      {
        Console.WriteLine("Hello User, choose your option: \n");

        foreach (KeyValuePair<int, string> option in Options) Console.WriteLine($"{option.Key}, {option.Value} \n");

        var userInput = ReadNumInput();
          
        if (Options.ContainsKey(userInput))
        {
          if (userInput == 5)
          {
            break;
          }

          Console.WriteLine("Choose first number: ");
          var firstNum = ReadNumInput();

          Console.WriteLine("Choose second number: ");
          var secondNum = ReadNumInput();

          switch(userInput)
          {
            case 1:
              Console.WriteLine(calc.Add(firstNum, secondNum));
              break;
            case 2:
              Console.WriteLine(calc.Sub(firstNum, secondNum));
              break;
            case 3:
              Console.WriteLine(calc.Mul(firstNum, secondNum));
              break;
            case 4:
              Console.WriteLine(calc.Div(firstNum, secondNum));
              break;
          }
        } 
      }
    }

    private static int ReadNumInput()
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

      return 0;
    }
  }
}