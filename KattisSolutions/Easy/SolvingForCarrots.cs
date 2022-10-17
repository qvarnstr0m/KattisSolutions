using System;

namespace KattisSolutions.Easy
{
    internal class SolvingForCarrots
    {
        internal void SolvingForCarrotsSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            Console.Write(split[1]);
        }
    }
}
