using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class PairingSocks
    {
        internal static void PairingSocksSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int[] socks = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int moves = 0;
            Stack<int> originalPile = new Stack<int>();
            Stack<int> auxPile = new Stack<int>();

            foreach (int sock in socks)
            {
                originalPile.Push(sock);
            }

            while (originalPile.Count > 0)
            {
                if (auxPile.Count > 0)
                {
                    if (originalPile.Peek() == auxPile.Peek())
                    {
                        originalPile.Pop();
                        auxPile.Pop();
                        moves++;
                        continue;
                    }
                }

                auxPile.Push(originalPile.Pop());
                moves++;
            }

            if (originalPile.Count == 0 && auxPile.Count == 0) Console.Write(moves);

            else
            {
                while (auxPile.Count > 0)
                {
                    if (originalPile.Count > 0)
                    {
                        if (originalPile.Peek() == auxPile.Peek())
                        {
                            originalPile.Pop();
                            auxPile.Pop();
                            moves++;
                        }
                    }

                    if (auxPile.Count > 0)
                    {
                        originalPile.Push(auxPile.Pop());
                        moves++;
                    }

                }

                if (originalPile.Count == 0 && auxPile.Count == 0) Console.Write(moves);
                else
                {
                    Console.Write("impossible");
                }
            }
        }
    }
}
