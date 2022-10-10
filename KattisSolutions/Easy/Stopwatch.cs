using System;

namespace KattisSolutions.Easy
{
    internal class Stopwatch
    {
        public void StopClassSolution()
        {
            int timesPressed = int.Parse(Console.ReadLine());

            if (timesPressed % 2 != 0)
                Console.Write("still running");
            else
            {
                int timerSum = 0;
                int[] timerArray = new int[timesPressed];
                for (int i = 0; i < timesPressed; i++)
                {
                    timerArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < timerArray.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        timerSum += timerArray[i + 1] - timerArray[i];
                    }
                }

                Console.Write(timerSum);
            }
        }
    }
}
