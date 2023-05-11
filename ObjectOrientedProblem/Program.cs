using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2, 5, 6, 7, 5 };

            int duplicates = DuplicateCounter.CountDuplicates(arr);

            Console.WriteLine("Total number of duplicate elements in the array: {0}", duplicates);
            Console.ReadLine();
        }
    }
}
