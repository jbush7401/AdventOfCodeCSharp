using System;
using System.Diagnostics;
using System.Reflection;
using AoCCSharp;
using Microsoft.VisualBasic;

namespace AoCCSharp {
    class Program {
        static void Main() {

            Console.WriteLine("Enter the Year Day of the Problem(IE 2022 1)");
            string[] input = Console.ReadLine().Split(' ');

            string year = input[0];
            string day = input[1];

            // Try to parse the year and day from the arguments
            // ... Rest of the code ...

            // Based on user input, load the appropriate class.
            string namespaceName = $"AoCCSharp.Y_{year}";
            string className = $"Day{day}";

            // Using reflection to get the type of the class
            Type dayType = Type.GetType($"{namespaceName}.{className}");

            if (dayType != null && typeof(IDay).IsAssignableFrom(dayType)) {
                IDay instance = (IDay)Activator.CreateInstance(dayType);

                Stopwatch stopwatch = new();
                stopwatch.Start();

                instance.PartOne();
                instance.PartTwo();

                stopwatch.Stop();
                Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
            }
            else {
                Console.WriteLine($"Couldn't find or load the class for Year {year} Day {day}.");
            }
        }
    }
}

