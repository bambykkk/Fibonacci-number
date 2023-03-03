using System;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Fibonacci numbers");
            int numbers1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ulong x = 1;
            ulong y = 1;
            ulong sum = 0;

            for (int i = 0; i < numbers1; i++)
            {
                x = sum;
                sum = x + y;
                y=x;
                Console.WriteLine(sum);
            }
        }
    }
}
