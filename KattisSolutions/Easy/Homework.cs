using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Homework
    {
        internal void HomeworkSolution()
        {
            string[] problemsArray = Console.ReadLine().Split(';');
            int totalProblems = 0;
            foreach (string item in problemsArray)
            {
                if (!item.Contains('-'))
                {
                    totalProblems++;
                }
                else
                {
                    int[] numbersArray = Array.ConvertAll(item.Split('-'), int.Parse);
                    for (int i = numbersArray[0]; i <= numbersArray[1]; i++)
                    {
                        totalProblems++;
                    }
                }
            }
            Console.Write(totalProblems);
        }
    }
}
