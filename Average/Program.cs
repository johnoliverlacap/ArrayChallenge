using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int position = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                position += 1;
                Console.Write("Enter element {0}: ", position);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;
            Console.WriteLine("Average is {0}", average);
            Console.ReadLine();
        }
    }
}
