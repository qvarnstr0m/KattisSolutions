using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Greetings
    {
        internal void GreetingsSolution()
        {
            string greeting = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append("h");
            foreach (char item in greeting)
            {
                if (item == 'e') sb.Append("ee");
            }
            sb.Append("y");
            Console.Write(sb);
        }
    }
}
