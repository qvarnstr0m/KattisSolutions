using System;

namespace KattisSolutions.Easy
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
