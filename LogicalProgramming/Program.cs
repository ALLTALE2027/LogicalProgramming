namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            Console.WriteLine("Enter the number from below choices to execute a program");
            Console.WriteLine("1. Fibonacci Number");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse a number");
            Console.WriteLine("5. Coupon Numbers");

            int ans = int.Parse(Console.ReadLine());

            switch (ans)
            {

                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.GetFibonacciNum();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.perfect();
                    break;
                case 3:
                    var number = new PrimeNumber();
                    number.CheckPrime();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case 5:
                    CouponNumbers coupon = new CouponNumbers();
                    coupon.GetCouponNumbers();
                    break;
                default:
                    Console.WriteLine("enter the number from given choices");
                    break;
            }
        }
    }
}