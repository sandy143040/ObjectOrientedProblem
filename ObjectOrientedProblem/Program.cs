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
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            StringOperations stringOps = new StringOperations(str);

            string reversedString = stringOps.ReverseWords();

            Console.WriteLine($"Reversed string: {reversedString}");

            Console.ReadLine();
        }
    }
}
