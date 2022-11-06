using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class CountTheVowels
    {
        public void CountTheVowelsSolution()
        {
            string line = Console.ReadLine().ToLower();
            int vowels = 0;
            foreach (char c in line)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
            }
            Console.Write(vowels);
        }
    }
}
