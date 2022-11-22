using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class LaptopSticker
    {
        internal void LaptopStickerSolution()
        {
            int[] sizesArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if ((sizesArray[0] - 2) >= sizesArray[2] && (sizesArray[1] - 2) >= sizesArray[3])
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
