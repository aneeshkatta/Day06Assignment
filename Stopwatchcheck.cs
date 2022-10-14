using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day6logicalproblems
{
    public class Stopwatchcheck
    {
        public static void Stopwatchchec()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);

        }
    }
}
