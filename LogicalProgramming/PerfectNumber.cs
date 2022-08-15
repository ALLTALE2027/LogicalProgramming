using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNumber
    {
        public void perfect()
        {

            Console.WriteLine("Perfect Number check");
            Console.WriteLine("enter a number");
            int N = int.Parse(Console.ReadLine());

            int check = 0;

            for (int i = 1; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    check += i;
                }
            }


            if (check == N)
                Console.WriteLine("Entered Number is a perfect number!!!");
            else
                Console.WriteLine("Entered Number is not a perfect number");


        }
    }
}
