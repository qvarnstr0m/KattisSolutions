using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class EstimatingTheAreaOfACircle
    {
        internal void EstimatingTheAreaOfACircleSolution()
        {
            string line;
            do
            {
                line = Console.ReadLine();
                double[] doubleArray = Array.ConvertAll(line.Split(' '), double.Parse);
                if (line != "0 0 0")
                {
                    double trueArea = doubleArray[0] * doubleArray[0] * 3.14159265359;
                    double estimatedArea = doubleArray[0] * 2 * (doubleArray[0] * 2) * (doubleArray[2] / doubleArray[1]);
                    Console.WriteLine($"{trueArea} {estimatedArea}");
                }
            } while (line != "0 0 0");
        }
    }
}
