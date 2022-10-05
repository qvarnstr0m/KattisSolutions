using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Autori
    {
        internal void AutoriSolution()
        {
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                if (i == 0) sb.Append(line[0]);
                if (line[i] == '-') sb.Append(line[i + 1]);
            }

            Console.Write(sb);
        }
    }
}
