using System;
using System.Collections.Generic;

namespace Arrays
{
    public class SockMerchant
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var val = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            if (n != val.Length)
            {
                Console.WriteLine("Weird input, Im exiting.");
                return;
            }

            Console.WriteLine(GetMaxPairs(val));
        }

        public static int GetMaxPairs(int[] val)
        {
            var sockList = new List<int>();
            var pairsCount = 0;

            foreach (var n in val)
            {
                if (sockList.Contains(n))
                {
                    pairsCount++;
                    sockList.Remove(n);
                }
                else
                {
                    sockList.Add(n);
                }
            }

            return pairsCount;
        }
    }
}
