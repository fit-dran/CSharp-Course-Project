using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Adolfo\\Desktop\\C# Course\nNew line test";
            Console.WriteLine(speech);
            Console.WriteLine(path);

            path = @"C:\Users\Adolfo\Desktop\C# Course" + "\nNew line test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
