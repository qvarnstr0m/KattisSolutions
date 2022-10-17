using System;

namespace KattisSolutions.Easy
{
    internal class BuildingPyramids
    {
        internal void BuildingPyramidsSolution()
        {
            double blocks = double.Parse(Console.ReadLine());
            int height = 0;
            double blocksInLayer = 1;
            int iterator = 1;
            while (blocks >= 0)
            {
                blocksInLayer = Math.Pow(iterator, 2);
                blocks -= blocksInLayer;
                iterator += 2;

                if (blocks >= 0) height++;
            }

            Console.Write(height);
        }
    }
}