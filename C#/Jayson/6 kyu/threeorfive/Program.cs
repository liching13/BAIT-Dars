using System;

namespace threeorfive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Solution(10)}");
        }
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum+=i;
                }
                else if (i % 3 == 0)
                {
                    sum+=i;
                }
                else if (i % 5 == 0)
                {
                    sum+=i;
                }
            }
            return sum;
        }
    }
}
