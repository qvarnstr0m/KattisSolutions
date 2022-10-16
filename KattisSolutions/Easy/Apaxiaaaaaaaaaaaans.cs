using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Apaxiaaaaaaaaaaaans
    {
        internal void ApaxiansSolution()
        {
            var sb = new StringBuilder();
            string line = Console.ReadLine();
            sb.Append(line[0]);

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] != line[i - 1])
                {
                    sb.Append(line[i]);
                }
            }

            Console.Write(sb);
        }
    }
}
