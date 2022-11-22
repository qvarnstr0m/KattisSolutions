using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class FiftyShadesOfPink
    {
        internal void FiftyShadesOfPinkSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int buttons = 0;
            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine().ToLower();
                if (line.Contains("pink") || line.Contains("rose"))
                {
                    buttons++;
                }
            }
            if (buttons > 0)
            {
                Console.WriteLine(buttons);
            }
            else
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
        }
    }
}
