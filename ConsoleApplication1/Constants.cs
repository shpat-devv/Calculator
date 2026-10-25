using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class Constants
    {
        public const int Add = 1;
        public const int Sub = 2;
        public const int Mul = 3;
        public const int Div = 4;
        public const int History = 5;
        public const int Exit = 6;

        public static readonly Dictionary<int, string> Options = new Dictionary<int, string>
        {
            { Add, "+" },
            { Sub, "-" },
            { Mul, "*" },
            { Div, "/" },
            { History, "History" },
            { Exit, "Exit" }
        };
    }
}