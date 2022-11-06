using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Bijele
    {
        internal void BijeleSolution()
        {
            int[] pawnArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] pawnsOriginal = new int[] { 1, 1, 2, 2, 2, 8 };
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < pawnArray.Length; i++)
            {
                result.Append(pawnsOriginal[i] - pawnArray[i] + " ");
            }

            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
