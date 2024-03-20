using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a for loop from 1 to X (15)
             * 3 and 5 = FizzBuzz
             * 3 = Fizz
             * 5 = Buzz
             * else = number
             */
            for (int i = 1; i <= 15; i++)
            {
                bool threeDiv = i % 3 == 0;
                bool fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
