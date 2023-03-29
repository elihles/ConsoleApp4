using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number \t Square");
            for (int i = 1; i <= 100; i++)
            {
                int square = i * i;
                Console.WriteLine("{0} \t {1}", i, square);
            }
            Console.ReadLine();
        }
    }
    }

