using System;

namespace KattisSolutions.Easy
{
    internal class Sibice
    {
        internal void SibiceSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            double width = float.Parse(split[1]);
            double height = float.Parse(split[2]);
            double maxLength = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            for (int i = 0; i < int.Parse(split[0]); i++)
            {
                int match = int.Parse(Console.ReadLine());
                if (match <= maxLength)
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NE");
            }
        }
    }
}
