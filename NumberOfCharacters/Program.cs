using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTimes = 0;
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter specific character");
            string specificCharacter = Console.ReadLine();

            for (int i = 0 ; i < word.Length; i++)
            {
                if (word[i].ToString() == specificCharacter)
                {
                    numberOfTimes = numberOfTimes + 1;
                }
                
            }

            Console.WriteLine(numberOfTimes.ToString());
            Console.ReadLine();
        }
    }
}
