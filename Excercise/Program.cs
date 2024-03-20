using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ask the user for a number for the table
             * Write a loop to print X times table
             */

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, number, i * number);
                
            }
            Console.ReadLine();

        }
    }
}
