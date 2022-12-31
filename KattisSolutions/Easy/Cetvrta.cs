using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Cetvrta
    {
        internal void CetvrtaSolution()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');
            string[] thirdLine = Console.ReadLine().Split(' ');

            List<string> firstRow = new List<string>()
            {
                {firstLine[0] },
                {secondLine[0] },
                {thirdLine[0] }
            };

            List<string> secondRow = new List<string>()
            {
                {firstLine[1] },
                {secondLine[1] },
                {thirdLine[1] }
            };

            StringBuilder result = new StringBuilder();

            result.Append(firstRow.GroupBy(x => x).Single(x => x.Count() == 1).Key + " ");
            result.Append(secondRow.GroupBy(x => x).Single(x => x.Count() == 1).Key);

            Console.WriteLine(result.ToString());
        }
    }
}
