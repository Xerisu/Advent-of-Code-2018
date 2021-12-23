using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    internal abstract class DaySolver
    {
        protected readonly string[] lines;

        public DaySolver(string filename)
        {
            lines = File.ReadAllLines(filename);
        }

        protected abstract string SolvePart1();
        protected abstract string SolvePart2();

        public string GetAnswer()
        {
            return $"Part 1 = {SolvePart1()}\nPart 2 = {SolvePart2()}";
        }

        public static DaySolver CreateDaySolver(int day, string filename)
        {
            DaySolver solver;

            switch(day)
            {
                case 1:
                    solver = new Day1(filename);
                    break;
                case 2:
                    solver = new Day2(filename);
                    break;
                default:
                    throw new ArgumentException($"Day {day} not found");
            }

            return solver;
        }
    }
    
}
