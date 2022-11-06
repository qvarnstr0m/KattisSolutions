using System;

namespace KattisSolutions.Easy
{
    internal class N_Sum
    {
        internal void N_SumSolution()
        {
            int iterations = Convert.ToInt32(Console.ReadLine());
            string[] split = Console.ReadLine().Split(' ');
            int sum = 0;
            foreach (var item in split)
            {
                if (item != " ") sum += int.Parse(item.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
