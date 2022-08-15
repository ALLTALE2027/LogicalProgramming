using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Fibonacci
    {
        //intial values for fibonacci
        private int firstPreviousValue = 0;
        private int secondPreviousValue = 1;
        private int fibonacci;



        public void GetFibonacciNum()
        {
            Console.WriteLine("Enter the n th no. for which you want fibonacci  number: ");
            int n = int.Parse(Console.ReadLine());


            if (n == 0)
                Console.WriteLine("Fibonacci no. is: " + "Zero");

            else if (n == 1)
                Console.WriteLine("Fibonacci no. is: " + 1);

            else
            {
                for (var i = 1; i < n; i++)
                {
                    fibonacci = firstPreviousValue + secondPreviousValue;
                    firstPreviousValue = secondPreviousValue;
                    secondPreviousValue = fibonacci;



                }

                Console.WriteLine("Fibonacci no. is: " + fibonacci);
            }
        }
    }
}
