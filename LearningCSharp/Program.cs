using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] foShizzleMaNizzle)
        {

            var names = new List<string> { "Hytta", "Schalom", "Tistou", "Ajbar" };
            var index = names.IndexOf("Tistou");
            
            foreach (var name in names)
            {
                Console.WriteLine($"{names.IndexOf(name)}: {name}");
            }

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"{names.IndexOf(name)}: {name}");
            }
        }
    }
}