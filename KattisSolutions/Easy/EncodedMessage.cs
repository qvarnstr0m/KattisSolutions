using System;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class EncodedMessage
    {
        internal void EncodedMessageSolution()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string encodedMessage = Console.ReadLine();
                double rows = Math.Sqrt(encodedMessage.Length);
                StringBuilder decodedMessage = new StringBuilder();

                for (int j = 0; j < rows; j++)
                {
                    for (int k = Convert.ToInt32(rows); k <= encodedMessage.Length; k = k + Convert.ToInt32(rows))
                    {
                        decodedMessage.Append(encodedMessage[(k - j) - 1]);
                    }
                }

                Console.WriteLine(decodedMessage);
                decodedMessage.Clear();
            }
        }
    }
}
