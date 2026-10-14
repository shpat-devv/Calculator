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
      {5, "Test"},
      {6, "Exit"},
    };

    public static void Main(string[] args)
    {
      int userInput = 6;

      while (true)
      {
        Console.WriteLine("Hello User, choose your option: \n");

        Opts();

        try
        {
          userInput = Int16.Parse(Console.ReadLine());

          
          if (Options.ContainsKey(userInput))
          {
            Console.WriteLine("Handling Input...");
          } 

          else 
          {
            Console.WriteLine("Input not programmed.");
          }
        }

        catch (System.FormatException)
        {
          Console.WriteLine("Wrong Input type");
        }

        catch (Exception e)
        {
          Console.WriteLine($"error: {e}");
        }
      }
      
      //testing
      Console.WriteLine(Add(10, 20));
      Console.WriteLine(Sub(10, 20));
      Console.WriteLine(Mul(10, 20));
      Console.WriteLine(Div(10, 20));

    }

    private static void Opts()
    {
      foreach (KeyValuePair<int, string> option in Options) Console.WriteLine($"{option.Key}, {option.Value} \n");
    }

    private static int Add(int a, int b)
    {
      return a + b;
    }

    private static int Sub(int a, int b)
    {
      return a - b;
    }

    private static int Mul(int a, int b)
    {
      return a * b;
    }
    
    private static int Div(int a, int b)
    {
      return a / b;
    }
  }
}