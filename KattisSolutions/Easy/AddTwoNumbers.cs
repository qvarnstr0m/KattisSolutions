using System;

namespace KattisSolutions.Easy
{
    internal class AddTwoNumbers
    {
        internal void AddTwoNumbersSolutíon()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int first = int.Parse(split[0]);
            int second = int.Parse(split[1]);
            Console.Write(first + second);
        }
    }
}
