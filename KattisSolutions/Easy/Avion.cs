using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Avion
    {
        internal void AvionSolution()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i < 6; i++)
            {
                string line = Console.ReadLine();
                if (line.Contains("FBI"))
                {
                    result.Append(i + " ");
                }
            }

            if (result.Length < 1)
            {
                Console.WriteLine("HE GOT AWAY!");
            }
            else
            {
                Console.WriteLine(result.ToString().TrimEnd());
            }
        }
    }
}
