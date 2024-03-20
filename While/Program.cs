using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.WriteLine("Write first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Write second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.WriteLine("Whats the value of " + numberA + " X " + numberB + "? ");
            Console.WriteLine();

            /*while (answer != actualAnswer)
            {
                Console.WriteLine("Enter your answer");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }*/

            do
            {
                Console.WriteLine("Enter your answer");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (actualAnswer != answer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);
            Console.WriteLine("Well Done");

            Console.ReadLine();
        }
    }
}
