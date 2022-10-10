using System;

namespace KattisSolutions.Medium
{
    internal class TrainPassangers
    {
        internal void TrainPassangersSolution()
        {
            string line1 = Console.ReadLine();
            string[] split1 = line1.Split(new char[] { ' ' }, StringSplitOptions.None);
            int capacity = int.Parse(split1[0]);
            int stations = int.Parse(split1[1]);
            int onBoard = 0;
            bool possible = true;

            for (int i = 0; i < stations; i++)
            {
                string line2 = Console.ReadLine();
                string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                int leaving = int.Parse(split2[0]);
                int entering = int.Parse(split2[1]);
                int waiting = int.Parse(split2[2]);

                if (i == 0 && leaving > 0)
                {
                    possible = false;
                    break;
                }

                onBoard += entering - leaving;

                if (onBoard > capacity || onBoard < capacity && waiting != 0)
                {
                    possible = false;
                    break;
                }

                if (waiting > 0 && onBoard < capacity)
                {
                    possible = false;
                    break;
                }

                if (i == stations - 1 && onBoard != 0)
                {
                    possible = false;
                }
            }

            if (possible == false)
            {
                Console.Write("impossible");
            }
            else
            {
                Console.Write("possible");
            }
        }
    }
}
