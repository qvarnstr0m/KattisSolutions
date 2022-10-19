using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Pokechat
    {
        internal void PokechatSolution()
        {
            string encodingString = Console.ReadLine();
            string idNumbers = Console.ReadLine();
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < idNumbers.Length; i += 3)
            {
                string chunk = idNumbers.Substring(i, 3);
                int chunkId = int.Parse(chunk);
                message.Append(encodingString[chunkId - 1]);
            }
            Console.Write(message);
        }
    }
}
