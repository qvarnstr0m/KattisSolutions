using System;

namespace KattisSolutions.Easy
{
    internal class QuadrantSelection
    {
        internal void QuadrantSelectionSolution()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0) Console.Write("1");
            else if (a < 0 && b > 0) Console.Write("2");
            else if (a < 0 && b < 0) Console.Write("3");
            else Console.WriteLine("4");
        }
    }
}
