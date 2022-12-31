using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Ptice
    {
        internal void PticeSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            StringBuilder adrianSB = new StringBuilder();
            StringBuilder brunoSB = new StringBuilder();
            StringBuilder goranSB = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                adrianSB.Append("ABC");
                brunoSB.Append("BABC");
                goranSB.Append("CCAABB");
            }

            string adrianString = adrianSB.ToString(0, iterations);
            string brunoString = brunoSB.ToString(0, iterations);
            string goranString = goranSB.ToString(0, iterations);


            Dictionary<string, int> scoreDict = new Dictionary<string, int>()
            {
                {"Adrian", 0 },
                {"Bruno", 0 },
                {"Goran", 0 }
            };

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == adrianString[i]) scoreDict["Adrian"]++;
                if (line[i] == brunoString[i]) scoreDict["Bruno"]++;
                if (line[i] == goranString[i]) scoreDict["Goran"]++;
            }

            int topScore = scoreDict.Values.Max();

            Console.WriteLine(topScore);

            foreach (var item in scoreDict)
            {
                if (item.Value == topScore) Console.WriteLine(item.Key);
            }
        }
    }
}
