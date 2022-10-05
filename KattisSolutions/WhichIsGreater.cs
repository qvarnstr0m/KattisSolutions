using System;

namespace KattisSolutions
{
    internal class WhichIsGreater
    {
        internal void WhichIsGreaterSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int first = int.Parse(split[0]);
            int second = int.Parse(split[1]);
            if (first > second) Console.Write("1");
            else Console.Write("0");
        }
    }
}
