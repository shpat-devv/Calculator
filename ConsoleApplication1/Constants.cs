using System.Collections.Generic;

namespace ConsoleApplication1
{
    public struct Constants
    {
        public static readonly Dictionary<int, string> Options = new Dictionary<int, string>
        {
            {1, "+"},
            {2, "-"},
            {3, "*"},
            {4, "/"},
            {5, "History"},
            {6, "Exit"},
        };
    }
}