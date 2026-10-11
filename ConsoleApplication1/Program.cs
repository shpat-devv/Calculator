using System;

namespace ConsoleApplication1
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      //create a simple calculator
      
      //testing
      Console.WriteLine(Add(10, 20));
      Console.WriteLine(Sub(10, 20));
      Console.WriteLine(Mul(10, 20));
      Console.WriteLine(Div(10, 20));

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