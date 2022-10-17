using System;

namespace KattisSolutions.Easy
{
    internal class HissingMicrophone
    {
        internal void HissingMicrophoneSolution()
        {
            string line = Console.ReadLine();
            if (line.IndexOf("ss") == -1) Console.Write("no hiss");
            else Console.Write("hiss");
        }
    }
}