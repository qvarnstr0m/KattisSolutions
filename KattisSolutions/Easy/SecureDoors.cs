using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SecureDoors
    {
        internal void SecureDoorsSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            List<string> inside = new List<string>();

            for (int i = 0; i < iterations; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                if (line[0] == "entry" && inside.Exists(x => x == line[1]) == false)
                {
                    Console.WriteLine($"{line[1]} entered");
                    inside.Add(line[1]);
                }
                else if (line[0] == "entry" && inside.Exists(x => x == line[1]) == true)
                {
                    Console.WriteLine($"{line[1]} entered (ANOMALY)");
                }
                else if (line[0] == "exit" && inside.Exists(x => x == line[1]) == true)
                {
                    Console.WriteLine($"{line[1]} exited");
                    inside.Remove(line[1]);
                }
                else if (line[0] == "exit" && inside.Exists(x => x == line[1]) == false)
                {
                    Console.WriteLine($"{line[1]} exited (ANOMALY)");
                }
            }
        }
    }
}
