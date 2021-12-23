using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    internal class Day2 : DaySolver
    {
        public Day2(string filename) : base(filename) { }

        protected override string SolvePart1()
        {
            int twoLetters = 0;
            int threeLetters = 0;

            foreach (string line in lines)
            {
                Dictionary<char, int> letters = new();
                foreach (char c in line)
                {
                    if (letters.ContainsKey(c))
                        letters[c] += 1;
                    else
                        letters[c] = 1;

                }
                    

                if (letters.Values.Contains(2))
                    twoLetters++;
                if (letters.Values.Contains(3))
                    threeLetters++;
            }
            return (twoLetters * threeLetters).ToString();
        }

        protected override string SolvePart2()
        {
            foreach(string line1 in lines)
            {
                foreach(string line2 in lines)
                {
                    int lastMistakeIndex = -1;
                    int mistakes = 0;
                    for (int i = 0; i < line1.Length; i++)
                    {
                        if (line1[i] != line2[i]) { 
                            mistakes++;
                            lastMistakeIndex = i;
                        }
                           
                    }
                        
                    if (mistakes == 1)
                    {
                        return line1.Remove(lastMistakeIndex, 1);
                    }

                }
                
            }
            return "Invalid Input";
        }
    }
}
