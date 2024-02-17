using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            Console.WriteLine("Enter string: ");
            string word = Console.ReadLine();
 
            int index = word.Length - 1;
            while(index < word.Length && index != -1)
            {
                if (index >= 0)
                {
                    result = result + word[index]; 
                    index--;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();

            //hello
        }
    }
}
