using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Aaah
    {
        internal void AaahSolution()
        {
            string marInput = Console.ReadLine();
            string docInput = Console.ReadLine();
            Console.Write(marInput.Length >= docInput.Length ? "go" : "no");
        }
    }
}
