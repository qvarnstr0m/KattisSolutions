using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions
{
    internal class FYI
    {
        internal void FYISolution()
        {
            string input = Console.ReadLine();
            if (input.Substring(0, 3) == "555")
                Console.Write("1");
            else
                Console.Write("0");
        }
    }
}
