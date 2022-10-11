using System;

namespace KattisSolutions.Easy
{
    internal class Pet
    {
        internal void PetSolution()
        {
            int topScore = 0;
            int winner = 0;
            int total = 0;

            for (int i = 1; i <= 5; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int firstScore = int.Parse(split[0]);
                int secondScore = int.Parse(split[1]);
                int thirdScore = int.Parse(split[2]);
                int fourthScore = int.Parse(split[3]);
                total = firstScore + secondScore + thirdScore + fourthScore;
                if (total > topScore)
                {
                    topScore = total;
                    winner = i;
                }
            }
            Console.Write($"{winner} {topScore}");
        }
    }
}
