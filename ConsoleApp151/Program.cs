using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp151
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "started", "starting", "ended", "ending" };

            foreach (var element in strings)
            {
                if (element.StartsWith("st"))
                {
                    Console.WriteLine($" \"{element}\" starts with \"st\"");
                }
            }

            Console.WriteLine();



            foreach (var element in strings)
            {
                if (element.EndsWith("ed"))
                {
                    Console.WriteLine($" \"{element}\" ends with \"ed\"");
                }
            }

            Console.WriteLine();

            Console.ReadLine();



        }
    }
}
