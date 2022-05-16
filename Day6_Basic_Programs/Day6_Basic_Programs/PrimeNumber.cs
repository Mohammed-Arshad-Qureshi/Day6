using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class PrimeNumber
    {
        public static void Result(int num)
        {
            int i, j;
            for (i = 1; i <= num; i++)
            {
                for (j = 2; j < num; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter range to Print PrimeNumbers :  ");
            int Prime = Convert.ToInt32(Console.ReadLine());
            Result(Prime);
        }
    }
}
