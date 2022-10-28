using System;

namespace KattisSolutions.Easy
{
    internal class Datum
    {
        internal void DatumSolution()
        {
            string[] split = Console.ReadLine().Split(' ');
            int day = int.Parse(split[0]);
            int month = int.Parse(split[1]);

            DateTime weekday = new DateTime(2009, month, day);
            Console.WriteLine(weekday.ToString("dddd"));
        }
    }
}
