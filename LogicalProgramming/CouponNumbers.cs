using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumbers
    {
        public void GetCouponNumbers()
        {
            Console.WriteLine("Enter the total no. of coupons");
            int TotalNumbers = Convert.ToInt32(Console.ReadLine());
            var arr = new List<int>();
            int noOfCoupons = TotalNumbers;
            int values;
            int count = 0;
            var random = new Random();



            for (int i = 0; i < TotalNumbers; i++)
            {

                Console.WriteLine("Enter " + (i + 1) + " number ");
                values = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    arr[i] = values;
                }
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] != values)
                        arr.Add(values);
                    else
                    {
                        Console.WriteLine("Entered number is already selected for coupon, enter different number ");
                        i--;
                        break;
                    }
                }

            }

            var maxNumber = arr.Max();
            var numbersList = arr.ToList();
            while (noOfCoupons > 0)
            {
                count++;

                var checkForRandom = random.Next(maxNumber + 1);
                foreach (int num in numbersList)
                {
                    if (num == checkForRandom)
                    {
                        Console.WriteLine("You got value " + checkForRandom + " when the random was generated " + count + " times");
                        noOfCoupons--;
                    }
                }
                numbersList.Remove(checkForRandom);


            }
            Console.WriteLine("Total random numbers generated:  " + count);
        }
    }
}
