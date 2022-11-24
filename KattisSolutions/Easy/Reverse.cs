using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Reverse
    {
        internal void ReverseSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }
            myList.Reverse();
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
