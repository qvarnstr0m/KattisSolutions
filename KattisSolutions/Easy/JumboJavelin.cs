using System;

namespace KattisSolutions.Easy
{
    internal class JumboJavelin
    {
        internal void JumboJavelinSolution()
        {
            int rods = int.Parse(Console.ReadLine());
            int lostLength = rods - 1;
            int totalLength = 0;

            for (int i = 0; i < rods; i++)
            {
                totalLength += int.Parse(Console.ReadLine());
            }

            Console.Write(totalLength - lostLength);
        }
    }
}
