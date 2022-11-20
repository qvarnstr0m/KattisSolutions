using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class PokerHand
    {
        internal void PokerHandSolution()
        {
            Dictionary<char, int> rankDict = new Dictionary<char, int>()
            {
                {'A', 0},
                {'2', 0},
                {'3', 0},
                {'4', 0},
                {'5', 0},
                {'6', 0},
                {'7', 0},
                {'8', 0},
                {'9', 0},
                {'T', 0},
                {'J', 0},
                {'Q', 0},
                {'K', 0}
            };

            string[] cards = Console.ReadLine().Split(' ');

            foreach (string card in cards)
            {
                rankDict[Convert.ToChar(card.Substring(0, 1))]++;
            }

            Console.WriteLine(rankDict.Values.Max());
        }
    }
}
