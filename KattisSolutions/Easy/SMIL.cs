using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SMIL
    {
        internal void SMILSolution()
        {
            string line = Console.ReadLine();
            List<int> smiles = new List<int>();

            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line.Substring(i, 2) == ":)" || line.Substring(i, 2) == ";)")
                {
                    smiles.Add(i);
                }

                if (i < line.Length - 3)
                {
                    if (i < line.Length - 3 && line.Substring(i, 3) == ":-)" || line.Substring(i, 3) == ";-)")
                    {
                        smiles.Add(i);
                    }
                }
            }

            foreach (var item in smiles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
