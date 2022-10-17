//Note: this solution gets runtime error in testcase 2

using System;
using System.Linq;

namespace KattisSolutions.Medium
{
    internal class ParadoxOfAveragesHard
    {
        internal void ParadoxOfAveragesEasySolution()
        {
            int testCases = int.Parse(Console.ReadLine());


            for (int i = 0; i < testCases; i++)
            {
                int noOfStudents = 0;

                Console.ReadLine();

                string line1 = Console.ReadLine();
                string[] split1 = line1.Split(new char[] { ' ' }, StringSplitOptions.None);
                int csStudents = int.Parse(split1[0]);
                int eStudents = int.Parse(split1[1]);

                string line2 = Console.ReadLine();
                string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                float[] csIqs = new float[csStudents];

                for (int j = 0; j < csStudents; j++)
                {

                    csIqs[j] = float.Parse(split2[j]);
                }

                string line3 = Console.ReadLine();
                string[] split3 = line3.Split(new char[] { ' ' }, StringSplitOptions.None);
                float[] eIqs = new float[eStudents];

                for (int k = 0; k < eStudents; k++)
                {
                    eIqs[k] = float.Parse(split3[k]);
                }

                for (int l = 0; l < csStudents; l++)
                {
                    float oldCsAverage = csIqs.Sum() / csStudents;
                    float newCsAverage = (csIqs.Sum() - csIqs[l]) / (csStudents - 1);
                    float oldEAverage = eIqs.Sum() / eStudents;
                    float newEAverage = (eIqs.Sum() - eIqs[l]) / (eStudents - 1);

                    if (newCsAverage > oldCsAverage && newEAverage > oldEAverage)
                    {
                        noOfStudents++;
                    }
                }

                Console.WriteLine(noOfStudents);
            }
        }
    }
}
