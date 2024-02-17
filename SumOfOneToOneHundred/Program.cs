using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOneToOneHundred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int counter = 1;

            while (counter <= 100)
            {
                result += counter;
                counter++;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
