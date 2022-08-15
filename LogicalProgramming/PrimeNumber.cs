using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public void CheckPrime()
        {
            int prime = 0;

            Console.WriteLine("enter the number to check for prime: ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    prime += 1;
            }

            Console.WriteLine(prime > 0 ? "Not a prime number" : "Is a prime number");

        }
    }
}
