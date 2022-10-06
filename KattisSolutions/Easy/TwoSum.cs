using System;

namespace KattisSolutions.Easy
{
    internal class TwoSum
    {
        internal void TwoSumSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            Console.Write(int.Parse(split[0]) + int.Parse(split[1]));
        }
    }
}
