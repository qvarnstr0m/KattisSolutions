using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Tri
    {
        internal void TriSolution()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string answer = "";
            if (numbers[0] == numbers[1] + numbers[2]) answer = $"{numbers[0]}={numbers[1]}+{numbers[2]}";
            else if (numbers[0] == numbers[1] - numbers[2]) answer = $"{numbers[0]}={numbers[1]}-{numbers[2]}";
            else if (numbers[0] == numbers[1] * numbers[2]) answer = $"{numbers[0]}={numbers[1]}*{numbers[2]}";
            else if (numbers[0] == numbers[1] / numbers[2]) answer = $"{numbers[0]}={numbers[1]}/{numbers[2]}";
            else if (numbers[0] + numbers[1] == numbers[2]) answer = $"{numbers[0]}+{numbers[1]}={numbers[2]}";
            else if (numbers[0] - numbers[1] == numbers[2]) answer = $"{numbers[0]}-{numbers[1]}={numbers[2]}";
            else if (numbers[0] * numbers[1] == numbers[2]) answer = $"{numbers[0]}*{numbers[1]}={numbers[2]}";
            else if (numbers[0] / numbers[1] == numbers[2]) answer = $"{numbers[0]}/{numbers[1]}={numbers[2]}";
            Console.WriteLine(answer);
        }
    }
}
