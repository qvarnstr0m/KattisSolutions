using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class ParadoxOfAveragesEasy
    {
        internal void ParadoxOfAveragesEasySolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                Console.ReadLine();
                int possibleCases = 0;

                double[] noStudents = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

                double csStudents = noStudents[0];
                double ecoStudents = noStudents[1];

                double[] csArray = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                double[] ecoArray = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

                double csAve = csArray.Average();
                double ecoAve = ecoArray.Average();

                foreach (double iq in csArray)
                {
                    double newCsAve = (csArray.Sum() - iq) / (csStudents - 1);
                    double newEcoAve = (ecoArray.Sum() + iq) / (ecoStudents + 1);
                    if (newCsAve > csAve && newEcoAve > ecoAve) possibleCases++;
                }

                Console.WriteLine(possibleCases);
            }
        }
    }
}
