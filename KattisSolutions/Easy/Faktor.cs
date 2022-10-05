using System;

namespace KattisSolutions.Easy
{
    internal class Faktor
    {
        internal void FaktorSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int articles = int.Parse(split[0]);
            int impactFactor = int.Parse(split[1]) - 1;
            Console.Write(articles * impactFactor + 1);
        }
    }
}
