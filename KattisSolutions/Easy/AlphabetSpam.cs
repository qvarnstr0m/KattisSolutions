using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class AlphabetSpam
    {
        internal void AlphabetSpamSolution()
        {
            string line = Console.ReadLine();
            double whiteSpace = 0d;
            double lowerCase = 0d;
            double upperCase = 0d;
            double symbols = 0d;

            foreach (char c in line)
            {
                if (c == '_')
                {
                    whiteSpace++;
                }
                else if (Char.IsUpper(c))
                {
                    upperCase++;
                }
                else if (Char.IsLower(c))
                {
                    lowerCase++;
                }
                else
                {
                    symbols++;
                }
            }

            Console.WriteLine(whiteSpace / Convert.ToDouble(line.Length));
            Console.WriteLine(lowerCase / Convert.ToDouble(line.Length));
            Console.WriteLine(upperCase / Convert.ToDouble(line.Length));
            Console.WriteLine(symbols / Convert.ToDouble(line.Length));
        }
    }
}
