using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6_Basic_Programs
{
    class StopWatch
    {
        public static void stopWatch(int time)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < time; i++)
            {
                Thread.Sleep(2);
            }
            s.Stop();
            Console.WriteLine(" Time elapsed: {0} ", s.Elapsed);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print elapsed time");
            int stop = Convert.ToInt32(Console.ReadLine());
            stopWatch(stop);
        }
    }
}
