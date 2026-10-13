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
      //create a simple calculator
      
      Opts();

      while (true)
      {
        Console.WriteLine("Hello User, choose your option: ");
        int? userInput = Int16.Parse(Console.ReadLine());

        if (userInput == null)
        {
          break
        }
        
        if (userInput == "exit")
        {
          break;
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
      foreach (KeyValuePair<int, string> option in Options) Console.WriteLine($"{option.Key}, {option.Value}");
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