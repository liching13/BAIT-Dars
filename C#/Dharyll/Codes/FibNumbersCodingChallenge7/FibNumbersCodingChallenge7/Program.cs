using System;

namespace FibNumbersCodingChallenge7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product of the numbers: ");
            int[] result = ProductFib(int.Parse(Console.ReadLine()));

            Console.Write("Result: ");
            foreach (int i in result) { Console.Write($"{i} ");}
        }

        public static int[] ProductFib(int prod)
        {
            int[] result = new int[3]{ 0, 0, 0};
            int firstNum = 0, secondNum = 1;

            for (int i = 0; i <= 99; i++)
            {
                int prevNum = firstNum;
                firstNum = secondNum;
                secondNum = prevNum + firstNum;
                if (firstNum*secondNum == prod) { result = new int[3]{ firstNum, secondNum, 1 }; break; }
                else if(firstNum * secondNum > prod) { result = new int[3] { firstNum, secondNum, 0 }; break; }
            }

            return result;
        }
    }
}
