using System;

namespace KattisSolutions.Easy
{
    internal class JobExpenses
    {
        internal void JobExpensesSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' });
            int totalExpenses = 0;

            for (int i = 0; i < iterations; i++)
            {
                int x = int.Parse(split[i]);
                if (x < 0) totalExpenses += x * -1;
            }

            Console.Write(totalExpenses);
        }
    }
}
