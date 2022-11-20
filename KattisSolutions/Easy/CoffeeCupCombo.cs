using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class CoffeeCupCombo
    {
        internal void CoffeeCupComboSolution()
        {
            Console.ReadLine();
            string line = Console.ReadLine();

            int awake = 0;
            int carry = 0;

            foreach (char c in line)
            {
                if (c == '1')
                {
                    awake++;
                    carry = 2;
                }
                else
                {
                    if (carry > 0)
                    {
                        awake++;
                        carry--;
                    }
                }
            }
            Console.Write(awake);
        }
    }
}
