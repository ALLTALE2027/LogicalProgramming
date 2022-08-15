using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Stopwatch
    {
        public void watch()
        {
            Console.WriteLine("Stopwatch!!!");
            Console.WriteLine("press enter to start the stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;

            Console.WriteLine("press enter to stop the stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;

            Console.WriteLine("Elapsed time is:" + (stop - start));
        }
    }
}
