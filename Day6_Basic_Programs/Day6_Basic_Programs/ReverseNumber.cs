using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class ReverseNumber
    {
        public static void check(int num)
        {
            int sum1 = 0, sum2 = 0, temp1 = num, temp2 = num, rem1, rem2;


            //calculating length by predefine method
            string len = num.ToString();
            Console.WriteLine(len.Length);


            //Calculating length by user define
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                count++;
            }


            Console.ReadLine();
            //Reversing number by using for loop 
            for (int i = 1; i <= count; i++)
            {
                rem1 = temp1 % 10;
                sum1 = sum1 * 10 + rem1;
                temp1 = temp1 / 10;
            }
            Console.WriteLine($"Reverse the number by for loop is {sum1} ");

            //Reversing number by using While loop

            while (temp2 != 0)
            {
                rem2 = temp2 % 10;
                sum2 = sum2 * 10 + rem2;
                temp2 = temp2 / 10;
            }
            Console.WriteLine($"Reverse the number by while loop is {sum2} ");
            Console.ReadLine();

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to Reverse the number :  ");
            int rs = Convert.ToInt32(Console.ReadLine());
            check(rs);
        }
    }
}
