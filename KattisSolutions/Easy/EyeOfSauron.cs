using System;
using System.Reflection;

namespace KattisSolutions.Easy
{
    internal class EyeOfSauron
    {
        internal void EyeOfSauronSolution()
        {
            string line = Console.ReadLine();
            string middle = line.Substring((line.Length - 1) / 2, 2);
            if (middle == "()" && line.Length % 2 == 0) Console.WriteLine("correct");
            else Console.WriteLine("fix");
        }
    }
}
