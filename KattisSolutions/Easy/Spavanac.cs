using System;

namespace KattisSolutions.Easy
{
    internal class Spavanac
    {
        internal void SpavanacSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int hour = int.Parse(split[0]);
            int minute = int.Parse(split[1]);

            minute -= 45;
            if (minute >= 0)
                Console.Write($"{hour} {minute}");
            else
            {
                hour -= 1;
                if (hour < 0) hour += 24;
                minute += 60;
                Console.Write($"{hour} {minute}");
            }
        }
    }
}
