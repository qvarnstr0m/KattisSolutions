using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Canadians
    {
        internal void CanadiansSolution()
        {
            string input = Console.ReadLine();
            if (input.Substring(input.Length - 3) == "eh?")
            {
                Console.WriteLine("Canadian!");
            }
            else
            {
                Console.WriteLine("Imposter!");
            }
        }
    }
}
