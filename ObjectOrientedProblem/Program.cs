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
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            ElementFrequency.CountElementFrequency(arr);

            Console.ReadLine();
        }
    }
}
