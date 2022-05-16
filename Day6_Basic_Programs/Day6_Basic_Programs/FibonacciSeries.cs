using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class FibonacciSeries
    {
        public static void result(int fib)
        {
            int n1 = -1, n2 = 1, n3 = 0;

            for (int i = 0; i < fib; i++)
            {

                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            }
            Console.ReadLine();




        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter range to Print Fibonacci series :  ");
            int fib = Convert.ToInt32(Console.ReadLine());
            result(fib);
        }
    }
}
