using System;

namespace KattisSolutions.Easy
{
    internal class ShatteredCake
    {
        internal void ShatteredCakeSolution()
        {
            int totalWidth = int.Parse(Console.ReadLine());
            int pieces = int.Parse(Console.ReadLine());
            int totalArea = 0;

            for (int i = 0; i < pieces; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' });
                int width = int.Parse(split[0]);
                int height = int.Parse(split[1]);
                totalArea += width * height;
            }

            Console.Write(totalArea / totalWidth);
        }
    }
}
