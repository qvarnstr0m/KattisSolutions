using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class AddingWords
    {
        internal void AddingWordsSolution()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string originalCommand = Console.ReadLine();
                if (originalCommand == null) break;
                string[] command = originalCommand.Split(' ');
                int result = 0;

                switch (command[0])
                {
                    case "def":
                        if (!dict.ContainsKey(command[1])) dict.Add(command[1], int.Parse(command[2]));
                        else dict[command[1]] = int.Parse(command[2]);
                        break;

                    case "calc":
                        bool calculateResult = true;
                        for (int i = 1; i < command.Length - 1; i = i + 2)
                        {
                            if (!dict.ContainsKey(command[i]))
                            {
                                Console.WriteLine($"{originalCommand.Substring(5)} unknown");
                                calculateResult = false;
                                break;
                            }
                            else
                            {
                                if (command[i - 1] == "-") result -= dict[command[i]];
                                else result += dict[command[i]];
                            }
                        }

                        if (calculateResult)
                        {
                            if (dict.ContainsValue(result)) Console.WriteLine($"{originalCommand.Substring(5)} {dict.FirstOrDefault(x => x.Value == result).Key}");
                            else Console.WriteLine($"{originalCommand.Substring(5)} unknown");
                        }

                        break;

                    case "clear":
                        dict.Clear();
                        break;
                }
            }
        }
    }
}
