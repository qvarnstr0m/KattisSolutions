using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SimonSays
    {
        internal void SimonSaysSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string input = Console.ReadLine();
                if (input.Length >= 10)
                {
                    if (input.Substring(0, 10) == "Simon says")
                    {
                        Console.WriteLine(input.Substring(11));
                    }
                }

            }
        }
    }
}
