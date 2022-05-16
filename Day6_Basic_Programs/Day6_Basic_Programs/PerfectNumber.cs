using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class PerfectNumber
    {
        public static void check(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
                Console.WriteLine("Entered number is Perfect Number");
            else
                Console.WriteLine("Entered number is Not a Perfect Number");
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check is it perfect number or not :  ");
            int perfect = Convert.ToInt32(Console.ReadLine());
            check(perfect);
        }
    }
}
