using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public struct Helper
    {
        public int ReadNumInput()
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
        
        public void PrintOptions()
        {
            var options = Constants.Options;
            foreach (KeyValuePair<int, string> option in options) 
                Console.WriteLine($"{option.Key}, {option.Value}");
        }
    }
}