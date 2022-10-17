using System;

namespace KattisSolutions.Easy
{
    internal class Oddities
    {
        internal void OdditiesSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0) Console.WriteLine($"{number} is even");
                else Console.WriteLine($"{number} is odd");
            }
        }
    }
}
