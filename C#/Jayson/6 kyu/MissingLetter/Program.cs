using System;
using System.Collections.Generic;
using System.Linq;
namespace MissingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter an array of numbers seperated by space: ");
             int[] input = Array.ConvertAll(Console.ReadLine().Split(" "),int.Parse);
             Console.WriteLine($"{GetUnique(input)}");
        }
            public static int GetUnique(IEnumerable<int> numbers)
            {
                int[] arr = numbers.ToArray();
                Array.Sort(arr);
                return (arr[0]!=arr[1])?arr[0]:arr[arr.Length-1]; 
                
            }
    }
}
