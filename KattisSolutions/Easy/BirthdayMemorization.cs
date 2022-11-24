using System;
using System.Collections.Generic;
using System.Linq;

namespace KattisSolutions.Easy
{
    internal class BirthdayMemorization
    {
        internal class Friend
        {
            public string Name { get; set; }
            public int Rating { get; set; }
            public string Date { get; set; }

            public Friend(string name, int rating, string date)
            {
                Name = name;
                Rating = rating;
                Date = date;
            }
            public string ReturnDate()
            {
                return Date;
            }
        }

        internal void BirthdayMemorizationSolution()
        {
            List<Friend> friendList = new List<Friend>();
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                if (friendList.Any(x => x.Date == line[2]))
                {
                    Friend duplicate = friendList.Find(x => x.Date == line[2]);
                    if (int.Parse(line[1]) > duplicate.Rating)
                    {
                        friendList.Remove(duplicate);
                        friendList.Add(new Friend(line[0], int.Parse(line[1]), line[2]));
                    }
                }
                else
                {
                    friendList.Add(new Friend(line[0], int.Parse(line[1]), line[2]));
                }
            }
            friendList.Sort((x, y) => string.Compare(x.Name, y.Name));
            Console.WriteLine(friendList.Count);
            foreach (Friend f in friendList)
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
