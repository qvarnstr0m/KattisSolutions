using System;

namespace KattisSolutions.Easy
{
    internal class SortTwoNumbers
    {
        internal void SortTwoNumbersSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);

            if (int.Parse(split[0]) <= int.Parse(split[1]))
                Console.Write($"{split[0]} {split[1]}");
            else
                Console.Write($"{split[1]} {split[0]}");
        }
    }
}
