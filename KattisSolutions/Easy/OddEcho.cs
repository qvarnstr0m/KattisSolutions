using System;

namespace KattisSolutions.Easy
{
    internal class OddEcho
    {
        internal void OddEchoSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 1; i <= iterations; i++)
            {
                string word = Console.ReadLine();
                if (i % 2 != 0)
                    Console.WriteLine(word);
            }
        }
    }
}
