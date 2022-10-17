using System;

namespace KattisSolutions.Easy
{
    internal class JanitorTroubles
    {
        internal void JanitorTroublesSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            double a = double.Parse(split[0]);
            double b = double.Parse(split[1]);
            double c = double.Parse(split[2]);
            double d = double.Parse(split[3]);

            double total = (a + b + c + d) / 2;

            Console.Write(Math.Sqrt((total - a) * (total - b) * (total - c) * (total - d)));
        }
    }
}
