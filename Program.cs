using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaySolver solver = DaySolver.CreateDaySolver(Int32.Parse(args[0]), args[1]);
            Console.WriteLine(solver.GetAnswer());
        }
    }
}
