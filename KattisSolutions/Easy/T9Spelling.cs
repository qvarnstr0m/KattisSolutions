using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class T9Spelling
    {
        internal void T9SpellingSolution()
        {
            Dictionary<char, string> myDict = new Dictionary<char, string>()
            {
                {'a', "2"},
                {'b', "22"},
                {'c', "222"},
                {'d', "3"},
                {'e', "33"},
                {'f', "333"},
                {'g', "4"},
                {'h', "44"},
                {'i', "444"},
                {'j', "5"},
                {'k', "55"},
                {'l', "555"},
                {'m', "6"},
                {'n', "66"},
                {'o', "666"},
                {'p', "7"},
                {'q', "77"},
                {'r', "777"},
                {'s', "7777"},
                {'t', "8"},
                {'u', "88"},
                {'v', "888"},
                {'w', "9"},
                {'x', "99"},
                {'y', "999"},
                {'z', "9999"},
                {' ', "0" }
            };

            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                StringBuilder result = new StringBuilder();
                result.Append(myDict[line[0]]);
                for (int j = 1; j < line.Length; j++)
                {
                    string current = myDict[line[j]];
                    char currentChar = current[0];
                    string last = myDict[line[j - 1]];
                    char lastChar = last[last.Length - 1];
                    int currentLength = current.Length;
                    if (lastChar == currentChar)
                    {
                        result.Append(" ");
                    }
                    result.Append(myDict[line[j]]);
                }
                Console.WriteLine($"Case #{i + 1}: {result.ToString()}");
            }
        }
    }
}
