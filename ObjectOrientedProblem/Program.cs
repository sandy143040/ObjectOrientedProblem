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
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Unique elements in the array:");
            UniqueElements.PrintUniqueElements(arr);

            Console.ReadLine();
        }
    }
}
