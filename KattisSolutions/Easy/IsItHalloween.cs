using System;

namespace KattisSolutions.Easy
{
    internal class IsItHalloween
    {
        internal void IsItHalloweenSolution()
        {
            string line = Console.ReadLine();
            if (line == "OCT 31" || line == "DEC 25")
                Console.Write("yup");
            else
                Console.Write("nope");
        }
    }
}