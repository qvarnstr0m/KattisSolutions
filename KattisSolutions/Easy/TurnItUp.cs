using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class TurnItUp
    {
        internal void TurnItUpSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int volume = 7;

            for (int i = 0; i < iterations; i++)
            {
                string request = Console.ReadLine();

                if (request == "Skru op!" && volume != 10)
                {
                    volume++;
                }
                else if (request == "Skru ned!" && volume != 0)
                {
                    volume--;
                }
            }

            Console.WriteLine(volume);
        }
    }
}
