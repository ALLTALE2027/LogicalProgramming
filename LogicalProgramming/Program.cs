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
                default:
                    Console.WriteLine("enter the number from given choices");
                    break;
            }
        }
    }
}