namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            Console.WriteLine("Enter the number from below choices to execute a program");
            Console.WriteLine("1. Fibonacci Number");

            int ans = int.Parse(Console.ReadLine());

            switch (ans)
            {

                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.GetFibonacciNum();
                    break;
                default:
                    Console.WriteLine("enter the number from given choices");
                    break;
            }
        }
    }
}