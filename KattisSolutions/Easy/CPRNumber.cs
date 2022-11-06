using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class CPRNumber
    {
        internal void CPRNumberSolution()
        {
            string line = Console.ReadLine().Remove(6, 1);
            double total = 0;
            total += 4 * int.Parse(line[0].ToString());
            total += 3 * int.Parse(line[1].ToString());
            total += 2 * int.Parse(line[2].ToString());
            total += 7 * int.Parse(line[3].ToString());
            total += 6 * int.Parse(line[4].ToString());
            total += 5 * int.Parse(line[5].ToString());
            total += 4 * int.Parse(line[6].ToString());
            total += 3 * int.Parse(line[7].ToString());
            total += 2 * int.Parse(line[8].ToString());
            total += 1 * int.Parse(line[9].ToString());
            double newTotal = Convert.ToDouble(total);
            double remainder = newTotal / 11;
            if (remainder % 1 == 0) Console.WriteLine("1");
            else Console.WriteLine("0");
        }
    }
}
