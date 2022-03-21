using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 7, 9, 3, 7, 1, 2 };
            
            int[] filterData = Filter(data);

            foreach (int d in filterData)
            {
                Console.Write(d + " ");
            }
            Console.ReadKey();
        }

        static int[]  Filter(int[] data)
        {
            HashSet<int> hash = new HashSet<int>();

            return data.Where(i =>
            {
                if (hash.Contains(i))
                    return false;
                else
                {
                    hash.Add(i);
                    return true;
                } 
            }).ToArray();
        }
    }
}
