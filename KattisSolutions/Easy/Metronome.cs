using System;

namespace KattisSolutions.Easy
{
    public class Metronome
    {
        internal void MetronomeSolution()
        {
            double songs = double.Parse(Console.ReadLine());
            Console.WriteLine(songs / 4);
        }
    }
}