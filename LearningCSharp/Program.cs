using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] foShizzleMaNizzle)
        {
            
            var names = new List<string> { "<name>", "Ana", "Tistou" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
