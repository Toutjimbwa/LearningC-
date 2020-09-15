using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] foShizzleMaNizzle)
        {
            var fibonacci = new List<int> { 1, 1, };

            while (fibonacci.Count < 20)
            {
                var previous = fibonacci[fibonacci.Count - 1];
                var previous2 = fibonacci[fibonacci.Count - 2];
                fibonacci.Add(previous + previous2);
            }
            

            //Fastest way to debug?
            //Mouse, Right click, select "Run to cursor"


            foreach (var i in fibonacci)
            {
                Console.WriteLine(i);
            }
        }
    }
}