using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class BigTruck //In progress not solved
    {
        internal static List<Node> nodeList = new List<Node>();
        internal static void BigTruckSolution()
        {
            int totalNodes = int.Parse(Console.ReadLine());
            int[] nodesWeight = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                int[] currentNode = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (!nodeList.Any(x => x.Name == currentNode[0]))
                {
                    Node newNode = new Node(currentNode[0], nodesWeight[currentNode[0] - 1]);
                    newNode.Adjacent.Add(currentNode[1], currentNode[2]);
                    nodeList.Add(newNode);
                }
                else
                {
                    Node addToNode = nodeList.Find(x => x.Name == currentNode[0]);
                    addToNode.Adjacent.Add(currentNode[1], currentNode[2]);
                }

                if (!nodeList.Any(x => x.Name == currentNode[1]))
                {
                    Node newNode = new Node(currentNode[1], nodesWeight[currentNode[1] - 1]);
                    newNode.Adjacent.Add(currentNode[0], currentNode[2]);
                    nodeList.Add(newNode);
                }
                else
                {
                    Node addToNode = nodeList.Find(x => x.Name == currentNode[1]);
                    addToNode.Adjacent.Add(currentNode[0], currentNode[2]);
                }
            }

            PriorityQueue<Node, int> frontier = new PriorityQueue<Node, int>();
            //Queue<Node> frontier = new Queue<Node>();
            Node startNode = nodeList.First(x => x.Name == 1);
            frontier.Enqueue(startNode, 0);

            Dictionary<int, int> cameFrom = new Dictionary<int, int>();
            cameFrom.Add(startNode.Name, 0);

            Dictionary<int, int> costSoFar = new Dictionary<int, int>();
            costSoFar.Add(startNode.Name, 0);

            Dictionary<int, int> itemsSoFar = new Dictionary<int, int>();
            itemsSoFar.Add(startNode.Name, startNode.Items);

            int carry = 0;

            while (frontier.Count > 0)
            {
                Node currentNode = frontier.Dequeue();
                Console.WriteLine($"Visiting {currentNode.Name}");
                if (currentNode.Name == nodesWeight.Length)
                {
                    Console.WriteLine("Stop");
                }

                foreach (var adjecent in currentNode.Adjacent)
                {
                    int newCost = costSoFar[currentNode.Name] + adjecent.Value;
                    int newItems = itemsSoFar[currentNode.Name] + nodeList.First(x => x.Name == adjecent.Key).Items;
                    if (!cameFrom.ContainsKey(adjecent.Key) || newCost < costSoFar[adjecent.Key] || newItems > itemsSoFar[adjecent.Key])
                    {
                        costSoFar[adjecent.Key] = newCost;
                        itemsSoFar[adjecent.Key] = newItems;
                        frontier.Enqueue(nodeList.First(x => x.Name == adjecent.Key), newCost);
                        cameFrom[adjecent.Key] = currentNode.Name;
                    }
                }
            }

            Node startNodeReverse = nodeList.First(x => x.Name == nodesWeight.Length);
            while (startNodeReverse.Name != 1)
            {
                carry += startNodeReverse.Items;
                startNodeReverse = nodeList.First(x => x.Name == cameFrom[startNodeReverse.Name]);
            }

            Console.WriteLine($"{costSoFar[nodesWeight.Length]} {itemsSoFar[nodesWeight.Length]}");

            //foreach (var item in nodeList)
            //{
            //    Console.WriteLine(item);
            //    foreach (var ajd in item.Adjacent)
            //    {
            //        Console.WriteLine($"Adj: {ajd.Key} Weight: {ajd.Value}");
            //    }
            //    Console.WriteLine();
            //}


        }
    }

    internal class Node
    {
        public int Name { get; set; }
        public Dictionary<int, int> Adjacent { get; set; }
        public int Items { get; set; }
        public Node(int name, int items)
        {
            Name = name;
            Items = items;
            Adjacent = new Dictionary<int, int>();
        }

        public override string ToString()
        {
            return $"Name: {Name} Items: {Items}";
        }
    }

    public class PriorityQueue<TElement, TPriority>
    {
        private List<Tuple<TElement, TPriority>> elements = new List<Tuple<TElement, TPriority>>();

        public int Count
        {
            get { return elements.Count; }
        }

        public void Enqueue(TElement item, TPriority priority)
        {
            elements.Add(Tuple.Create(item, priority));
        }

        public TElement Dequeue()
        {
            Comparer<TPriority> comparer = Comparer<TPriority>.Default;
            int bestIndex = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                if (comparer.Compare(elements[i].Item2, elements[bestIndex].Item2) < 0)
                {
                    bestIndex = i;
                }
            }

            TElement bestItem = elements[bestIndex].Item1;
            elements.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
