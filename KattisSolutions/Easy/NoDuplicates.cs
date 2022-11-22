using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class NoDuplicates
    {
        internal void NoDuplicatesSolution()
        {
            string[] lineSplit = Console.ReadLine().Split(' ');

            if (!lineSplit.All(new HashSet<string>().Add))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
