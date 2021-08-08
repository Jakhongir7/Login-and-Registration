using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhich Method do you want to use: ");
            Console.WriteLine(" 1.Iterative Approach");
            Console.WriteLine(" 2.Recursive Approach");
            Console.Write("Please Enter your choice: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("{0} ", FibonacciSeriesIterativeApproach(i));
                    }
                    break;
                case 2:
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("{0} ", FibonacciSeriesRecursiveApproach(i));
                    }
                    break;
                default:
                    Console.Write("Neither Approach has been choosen.");
                    break;
            }

            
            Console.WriteLine();
        }

        public static int FibonacciSeriesIterativeApproach(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }

        public static int FibonacciSeriesRecursiveApproach(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeriesRecursiveApproach(n - 1) + FibonacciSeriesRecursiveApproach(n - 2);
        }
    }
}
