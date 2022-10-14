using System;

namespace KattisSolutions.Medium
{
    internal class ADifferentProblem
    {
        internal void ADifferentProblemSolution()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long a = Int64.Parse(split[0]);
                long b = Int64.Parse(split[1]);
                Console.WriteLine(Math.Abs(a - b));
            }
        }
    }
}