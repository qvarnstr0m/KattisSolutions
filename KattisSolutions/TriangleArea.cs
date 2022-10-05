using System;

namespace KattisSolutions
{
    internal class TriangleArea
    {
        internal void TriangleAreaSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            float cakeHeight = float.Parse(split[0]);
            float cakeBase = float.Parse(split[1]);
            Console.Write((cakeBase * cakeHeight) / 2);
        }
    }
}
