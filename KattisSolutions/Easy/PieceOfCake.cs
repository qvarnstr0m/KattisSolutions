using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class PieceOfCake
    {
        internal void PieceOfCakeSolution()
        {
            int[] intArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int first = 0;
            if (intArray[1] > (intArray[0] / 2))
            {
                first = intArray[1];
            }
            else
            {
                first = intArray[0] - intArray[1];
            }

            int second = 0;
            if (intArray[2] > (intArray[0] / 2))
            {
                second = intArray[2];
            }
            else
            {
                second = intArray[0] - intArray[2];
            }

            Console.WriteLine(first * second * 4);
        }
    }
}
