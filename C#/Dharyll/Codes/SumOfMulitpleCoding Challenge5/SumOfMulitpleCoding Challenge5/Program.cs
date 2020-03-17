using System;

namespace SumOfMulitpleCoding_Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            Console.WriteLine($"The Sum of these multiples is: {SumOfMultiple(int.Parse(Console.ReadLine()))}");

        }

        public static int SumOfMultiple(int num)
        {
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { sum += i; }
                else if (i % 3 == 0) { sum += i; }
                else if (i % 5 == 0) { sum += i; }
            }

            return sum;
        }
    }
}
