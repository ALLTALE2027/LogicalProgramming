using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Reverse a  number");
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int rev = 0;
            int rem = 0;         // stores the remainder

            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;

            }


            Console.WriteLine("Reverse number is:" + rev);
        }
    }
}
