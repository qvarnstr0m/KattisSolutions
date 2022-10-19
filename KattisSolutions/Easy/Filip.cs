using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Filip
    {
        internal void FilipSolution()
        {
            string[] line = Console.ReadLine().Split(' ');
            char[] firstNumber = line[0].ToCharArray();
            Array.Reverse(firstNumber);
            char[] secondNumber = line[1].ToCharArray();
            Array.Reverse(secondNumber);
            if (int.Parse(firstNumber) > int.Parse(secondNumber)) Console.WriteLine(firstNumber);
            else Console.WriteLine(secondNumber);
        }
    }
}
