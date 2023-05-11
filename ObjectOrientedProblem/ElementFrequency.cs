using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class ElementFrequency
    {
        public static void CountElementFrequency(int[] arr)
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
            Console.WriteLine("Element frequency in the array:");
            foreach (KeyValuePair<int, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} occurs {kvp.Value} time(s)");
            }
        }
    }
}
