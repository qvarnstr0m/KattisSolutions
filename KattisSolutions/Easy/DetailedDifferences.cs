using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class DetailedDifferences
    {
        internal void DetailedDifferencesSolution()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                StringBuilder output = new StringBuilder();
                for (int j = 0; j < line1.Length; j++)
                {
                    if (line1[j] == line2[j]) output.Append('.');
                    else output.Append('*');
                }
                Console.WriteLine(line1);
                Console.WriteLine(line2);
                Console.WriteLine(output);
            }
        }
    }
}
