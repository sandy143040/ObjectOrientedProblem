using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class UniqueElements
    {
        public static void PrintUniqueElements(int[] arr)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (KeyValuePair<int, int> kvp in counts)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
