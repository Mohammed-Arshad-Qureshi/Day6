using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class CouponNumber
    {

        public static void coupon(int num)
        {

            Random r = new Random();
            int[] arr = new int[num];
            int i, j, k;

            for (i = 0; i < num; i++)
            {
                int check = r.Next(1, (num + 1));
                for (j = 0; j <= i - 1; j++)
                {
                    if (arr[j] == check)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    arr[i] = check;
                }
                else
                {
                    i--;
                }

            }
            for (k = 0; k < num; k++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter range to generate Distinct random numbers : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("##########################\n\n");
            coupon(num);
        }
    }
}
