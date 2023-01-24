using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class Accounting
    {
        internal void AccountingSolution()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int setNumber = 0;

            for (int i = 0; i < input[1]; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "SET":
                        if (!dict.ContainsKey(int.Parse(command[1])))
                        {
                            dict.Add(int.Parse(command[1]), int.Parse(command[2]));
                        }
                        else
                        {
                            dict[int.Parse(command[1])] = int.Parse(command[2]);
                        }
                        dict[int.Parse(command[1])] = int.Parse(command[2]);
                        break;

                    case "PRINT":
                        if (!dict.ContainsKey(int.Parse(command[1])))
                        {
                            Console.WriteLine(setNumber);
                        }
                        else
                        {
                            Console.WriteLine(dict[int.Parse(command[1])]);
                        }
                        break;

                    case "RESTART":
                        dict.Clear();
                        setNumber = int.Parse(command[1]);
                        break;
                }
            }
        }
    }
}
