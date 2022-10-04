using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions
{
    internal class tarifa
    {
        internal void TarifaSolution()
        {
            int megaByte = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            int leftOver = 0;
            for (int i = 0; i < months; i++)
            {
                leftOver += megaByte - int.Parse(Console.ReadLine());
            }
            Console.Write(megaByte + leftOver);
        }
    }
}
