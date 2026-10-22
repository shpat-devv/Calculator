using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class Helper
    {
        public static int ReadNumInput()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var userInput))
                {
                    return userInput;
                }

                Console.WriteLine("Please enter a valid number.");
            }
        }
        
        public static void PrintOptions()
        {
            foreach (KeyValuePair<int, string> option in Constants.Options)
            {
                Console.WriteLine($"{option.Key}, {option.Value}");
            }
        }
    }
}