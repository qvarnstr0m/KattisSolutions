using System;

namespace KattisSolutions.Easy
{
    internal class QALY
    {
        internal void QALYSolution()
        {
            int periods = int.Parse(Console.ReadLine());
            decimal QalyTotal = 0m;

            for (int i = 0; i < periods; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                decimal qaly = decimal.Parse(split[0]);
                decimal time = decimal.Parse(split[1]);
                QalyTotal += qaly * time;
            }

            Console.Write(QalyTotal);
        }
    }
}
