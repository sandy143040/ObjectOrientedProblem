using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblem
{
    public class StringOperations
    {
        private string str;

        public StringOperations(string str)
        {
            this.str = str;
        }

        public string ReverseWords()
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }
    }
}
