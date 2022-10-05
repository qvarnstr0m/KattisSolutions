using System;

namespace KattisSolutions
{
    internal class FindingAnA
    {
        internal void FindingAnASolution()
        {
            string line = Console.ReadLine();
            Console.Write(line.Substring(line.IndexOf('a')));
        }
    }
}
