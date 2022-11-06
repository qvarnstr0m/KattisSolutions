using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Trik
    {
        internal void TrikSolution()
        {
            string line = Console.ReadLine();
            int cup = 1;

            foreach (char c in line)
            {
                switch (c)
                {
                    case 'A':
                        if (cup == 1)
                        {
                            cup = 2;
                        }
                        else if (cup == 2)
                        {
                            cup = 1;
                        }
                        break;
                    case 'B':
                        if (cup == 2)
                        {
                            cup = 3;
                        }
                        else if (cup == 3)
                        {
                            cup = 2;
                        }
                        break;
                    case 'C':
                        if (cup == 1)
                        {
                            cup = 3;
                        }
                        else if (cup == 3)
                        {
                            cup = 1;
                        }
                        break;
                }
            }

            Console.WriteLine(cup);
        }
    }
}
