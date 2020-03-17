using System;

namespace IntegerCodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Persistence(num);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter numbers only!");
            }
            
        }

        public static void Persistence(int num)
        {
            int persistNum = num, count = 0;
            while(persistNum.ToString().Length!=1)
            {
                    int prod = 1;
                    string number = persistNum.ToString();

                    for (int i = 0; i < number.Length; i++)
                    {
                        prod = prod * Int32.Parse(number[i].ToString());
                        Console.Write($"{number[i]} ");
                    }
                    Console.WriteLine($"= {prod}");
                    persistNum = prod;
                    count++;
            }
            Console.WriteLine($"The Total Number of Persistence is: {count}");
        }
    }
}
