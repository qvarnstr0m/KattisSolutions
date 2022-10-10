using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class R2
    {
        internal void R2Solution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int R1 = int.Parse(split[0]);
            int S = int.Parse(split[1]);
            Console.Write((2 * S) - R1);
        }
    }
}
