using System;

namespace KattisSolutions.Easy
{
    internal class FizzBuzz
    {
        internal void FizzBuzzSolution()
        {
            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);
            int n = int.Parse(line[2]);

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0) Console.WriteLine("FizzBuzz");
                else if (i % x == 0) Console.WriteLine("Fizz");
                else if (i % y == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
