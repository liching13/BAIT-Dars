using System;
using System.Linq;
using System.Collections.Generic;

namespace TrainCodingChallenge9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a series of number (Ex: 5 4 3 2 1):");
                int[] sortedNum = TrainSortOdd(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));
                foreach(int i in sortedNum) { Console.Write($"{i}, "); }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public static int[] TrainSortOdd(string[] numbers)
        {
            List<int> numOdd = new List<int>();
            List<int> numIndex = new List<int>();
            int[] num = new int[numbers.Length];

            //change data type of string array to int array
            for(int i = 0; i <numbers.Length; i++)
            {
                num[i] = int.Parse(numbers[i]);
            }

            //gets the odd numbers and there index
            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] != 0 && num[i]%2 != 0) 
                {
                    numOdd.Add(num[i]);
                    numIndex.Add(i);
                }
            }

            //sort all odd numbers
            numOdd.Sort();

            //insert the sorted odd numbers back to the array
            for(int i = 0; i < numIndex.Count; i++)
            {
                num[numIndex.ElementAt(i)] = numOdd.ElementAt(i);
            }

            return num;
        }
    }
}
