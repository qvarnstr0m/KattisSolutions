using System;
using System.Linq;

namespace KattisSolutions.Easy
{
    internal class Zamka
    {
        internal void ZamkaSolution()
        {
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = low; i <= high; i++)
            {
                if (i.ToString().Sum(c => c - '0') == sum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            for (int i = high; i >= low; i--)
            {
                if (i.ToString().Sum(c => c - '0') == sum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
