using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SpeedLimit
    {
        internal void SpeedLimitSolution()
        {
            while (true)
            {
                int iterations = int.Parse(Console.ReadLine());
                if (iterations == -1) break;

                int miles = 0;
                int carry = 0;
                for (int i = 0; i < iterations; i++)
                {
                    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int speed = input[0];
                    int hours = input[1] - carry;
                    miles += hours * speed;
                    carry += hours;
                }
                Console.WriteLine($"{miles} miles");
            }
        }
    }
}
