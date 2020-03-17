using System;

namespace Persistence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 2 digit number or more: ");
            int inp = Int32.Parse(Console.ReadLine());
            int count = 0;
            while (inp > 10)
            {
                int prod = 1;
                int[] arr = sDigits(inp);
                foreach (int a in arr)
                {

                    Console.Write(a + " ");

                    prod = prod * a;
                }
                Console.WriteLine("= " + prod);
                inp = prod;
                count += 1;
            }
            Console.WriteLine("Persistence is {0}", count);
        }
        public static int[] sDigits(int input)
        {
            int temp = input;
            int[] digits = new int[input.ToString().Length];
            for (int k = 0; k < input.ToString().Length; k++)
            {
                digits[k] = temp % 10;
                temp = temp / 10;
            }
            Array.Reverse(digits);
            return digits;
        }

    }
}
