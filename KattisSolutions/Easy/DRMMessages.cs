using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class DRMMessages
    {
        internal void DRMMessagesSolution()
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>()
            {
                {'A', 0 },
                {'B', 1 },
                {'C', 2 },
                {'D', 3 },
                {'E', 4 },
                {'F', 5 },
                {'G', 6 },
                {'H', 7 },
                {'I', 8 },
                {'J', 9 },
                {'K', 10 },
                {'L', 11 },
                {'M', 12 },
                {'N', 13 },
                {'O', 14 },
                {'P', 15 },
                {'Q', 16 },
                {'R', 17 },
                {'S', 18 },
                {'T', 19 },
                {'U', 20 },
                {'V', 21 },
                {'W', 22 },
                {'X', 23 },
                {'Y', 24 },
                {'Z', 25 }
            };

            Dictionary<int, char> reveresedDict = new Dictionary<int, char>()
            {
                {0, 'A' },
                {1, 'B' },
                {2, 'C' },
                {3, 'D' },
                {4, 'E' },
                {5, 'F' },
                {6, 'G' },
                {7, 'H' },
                {8, 'I' },
                {9, 'J' },
                {10, 'K' },
                {11, 'L' },
                {12, 'M' },
                {13, 'N' },
                {14, 'O' },
                {15, 'P' },
                {16, 'Q' },
                {17, 'R' },
                {18, 'S' },
                {19, 'T' },
                {20, 'U' },
                {21, 'V' },
                {22, 'W' },
                {23, 'X' },
                {24, 'Y' },
                {25, 'Z' }
            };

            string encodedMessage = Console.ReadLine();
            string firstHalf = encodedMessage.Substring(0, encodedMessage.Length / 2);
            string secondHalf = encodedMessage.Substring(encodedMessage.Length / 2);

            int firstRotationValue = 0;
            foreach (char c in firstHalf)
            {
                firstRotationValue += myDict[c];
            }

            if (firstRotationValue >= 26)
            {
                firstRotationValue = firstRotationValue % 26;
            }

            StringBuilder firstSB = new StringBuilder();

            foreach (char c in firstHalf)
            {
                int number = myDict[c] + firstRotationValue;
                if (number > 25)
                {
                    number -= 26;
                }
                firstSB.Append(reveresedDict[number]);
            }

            firstHalf = firstSB.ToString();

            int secondRotationValue = 0;
            foreach (char c in secondHalf)
            {
                secondRotationValue += myDict[c];
            }

            if (secondRotationValue >= 26)
            {
                secondRotationValue = secondRotationValue % 26;
            }

            StringBuilder secondSB = new StringBuilder();

            foreach (char c in secondHalf)
            {
                int number = myDict[c] + secondRotationValue;
                if (number > 25)
                {
                    number -= 26;
                }
                secondSB.Append(reveresedDict[number]);
            }

            secondHalf = secondSB.ToString();

            StringBuilder finalResult = new StringBuilder();

            for (int i = 0; i < firstHalf.Length; i++)
            {
                int rotations = myDict[secondHalf[i]];

                int finalPosition = myDict[firstHalf[i]] + rotations;

                if (finalPosition > 25)
                {
                    finalPosition -= 26;
                }
                finalResult.Append(reveresedDict[finalPosition]);
            }

            Console.WriteLine(finalResult.ToString());
        }
    }
}
