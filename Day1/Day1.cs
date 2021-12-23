using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    internal class Day1 : DaySolver
    {
        public Day1(string filename) : base(filename) { }

        protected override string SolvePart1()
        {
            int answer = 0;

            foreach (string line in lines)
            {
                answer += Int32.Parse(line);
            }
            return answer.ToString();
        }

        protected override string SolvePart2()
        {
            HashSet<int> frequencies = new();
            int actualFrequency = 0;
            while (true)
            {
                foreach (string line in lines)
                {
                    actualFrequency += Int32.Parse(line);

                    if (!frequencies.Add(actualFrequency))
                    {
                        return actualFrequency.ToString();
                    }
                }
            }
        }
    }
}
