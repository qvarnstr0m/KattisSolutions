using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class BusNumbers
    {
        internal static void BusNumbersSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(numbers);
            StringBuilder result = new StringBuilder();
            List<int> carry = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                if (i == 0)
                {
                    carry.Add(numbers[i]);
                }
                else
                {
                    if (carry.Count > 0)
                    {
                        if (numbers[i] - carry.Last() == 1)
                        {
                            carry.Add(numbers[i]);
                        }
                        else
                        {
                            result = BuildString(result, carry);
                            carry.Clear();
                            carry.Add(numbers[i]);
                        }
                    }
                    else
                    {
                        carry.Add(numbers[i]);
                    }
                }
            }
            if (carry.Count > 0) result = BuildString(result, carry);
            Console.WriteLine(result.ToString().TrimEnd());
        }

        static StringBuilder BuildString(StringBuilder result, List<int> carry)
        {
            if (carry.Count > 2)
            {
                result.Append(carry.Min() + "-" + carry.Max() + " ");
            }
            else
            {
                foreach (int number in carry)
                {
                    result.Append(number + " ");
                }
            }
            return result;
        }
    }
}
