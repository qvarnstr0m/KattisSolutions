using KattisSolutions.Medium;
using System;

namespace KattisSolutions.Easy
{
    internal class HeartRate
    {
        internal void HeartRateSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' });
                float b = float.Parse(split[0]);
                float p = float.Parse(split[1]);

                float diff = 60 / p;
                float bpm = (60 * b) / p;

                Console.WriteLine($"{(bpm - diff).ToString("0.0000")} {bpm.ToString("0.0000")} {(bpm + diff).ToString("0.0000")}");
            }
        }
    }
}
