using System;

namespace ConsoleApplication1
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      var calc = new Calculator();
      var helper = new Helper();
      var options = Constants.Options;
      
      while (true)
      {
        Console.WriteLine("Hello User, choose your option: \n");

        helper.PrintOptions();
        
        int userInput = helper.ReadNumInput();
          
        if (options.ContainsKey(userInput))
        {
          if (options[userInput] == "Exit")
          {
            break;
          }
          
          if (options[userInput] == "History")
          {
            foreach (string operation in calc.GetHistory())
            {
              Console.WriteLine($"\n{operation}");
            }
          }
          
          Console.WriteLine("\nChoose first number: ");
          var firstNum = helper.ReadNumInput();

          Console.WriteLine("Choose second number: ");
          var secondNum = helper.ReadNumInput();
          
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
          
          calc.AddHistory(firstNum, secondNum, userInput, res);
          
          Console.Clear();
        } 
      }
    }
  }
}