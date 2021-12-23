using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide 2 arguments: Day and input path");
                return;
            }

            bool dayIsANumber = Int32.TryParse(args[0], out int day);

            if (!dayIsANumber)
            {
                Console.WriteLine("Day must be a number");
                return;
            }

            try 
            {
                DaySolver solver = DaySolver.CreateDaySolver(day, args[1]);
                Console.WriteLine(solver.GetAnswer());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
