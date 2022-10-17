using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class RatingProblems
    {
        internal void RatingProblemsSolution()
        {
            string firstLine = Console.ReadLine();
            string[] split = firstLine.Split(new char[] { ' ' });
            int totalJudges = int.Parse(split[0]);
            int scores = int.Parse(split[1]);
            int leftToJudge = totalJudges - scores;

            int totalScores = 0;

            for (int i = 0; i < scores; i++)
            {
                totalScores += int.Parse(Console.ReadLine());
            }

            float maxScores = (totalScores + 3f * leftToJudge) / totalJudges;
            float minScores = (totalScores + -3f * leftToJudge) / totalJudges;

            Console.Write($"{minScores} {maxScores}");
        }
    }
}
