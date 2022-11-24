using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class CodeToSaveLives
    {
        internal void CodeToSaveLivesSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int[] firstNumber = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int[] secondNumber = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                StringBuilder firstSb = new StringBuilder();
                foreach (var item in firstNumber)
                {
                    firstSb.Append(item);
                }
                StringBuilder secondSb = new StringBuilder();
                foreach (var item in secondNumber)
                {
                    secondSb.Append(item);
                }


                int totalNumber = int.Parse(firstSb.ToString()) + int.Parse(secondSb.ToString());
                StringBuilder totalSb = new StringBuilder();
                string totalString = Convert.ToString(totalNumber);
                foreach (char c in totalString)
                {
                    totalSb.Append(c + " ");
                }
                Console.WriteLine(totalSb.ToString().TrimEnd());
            }
        }
    }
}
