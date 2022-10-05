using System;

namespace KattisSolutions
{
    internal class Cold_puterScience
    {
        internal void Cold_puterScienceSolution()
        {
            int daysCollected = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            int[] splitInts = Array.ConvertAll(split, int.Parse);

            int daysBelowZero = 0;

            foreach (var item in splitInts)
            {
                if (item < 0) daysBelowZero++;
            }

            Console.Write(daysBelowZero);
        }
    }
}
