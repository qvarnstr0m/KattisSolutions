using System;

namespace KattisSolutions
{
    internal class JackOJuxta
    {
        internal void JackOJuxtaSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int eyes = int.Parse(split[0]);
            int nose = int.Parse(split[1]);
            int mouth = int.Parse(split[2]);
            Console.Write(eyes * nose * mouth);
        }
    }
}
