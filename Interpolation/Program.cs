using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age = 31;

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.WriteLine($"Your name is {name} and your age is {age}");

            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", age));

            string[] names = new string[] { "Aba", "Test", "Array" };
            Console.WriteLine(string.Concat(names));


            Console.ReadLine();

        }
    }
}
