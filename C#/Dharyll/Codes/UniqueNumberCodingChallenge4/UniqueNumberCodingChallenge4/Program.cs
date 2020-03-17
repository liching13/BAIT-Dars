using System;

namespace UniqueNumberCodingChallenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numbers: ");
            double[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), double.Parse);

            Console.WriteLine(FindUnique(numbers));
        }

        public static double FindUnique(double[] arrOfNumbers)
        {
            double[] sortedNumbers = arrOfNumbers;
            double uniqueNum = 0;

            Array.Sort(sortedNumbers);

            if (sortedNumbers[0] != sortedNumbers[sortedNumbers.Length - 2]) { uniqueNum = sortedNumbers[0]; }
            else { uniqueNum = sortedNumbers[sortedNumbers.Length - 1]; }

            return uniqueNum;
        }

        /*public static double FindUnique(double[] arrOfNumbers)
        {
            double[] sortedNumbers = arrOfNumbers;
            double uniqueNum = 0;

            Array.Sort(sortedNumbers);

            if (sortedNumbers[0] != sortedNumbers[sortedNumbers.Length / 2])
            {
                for (int i = 0; i < sortedNumbers.Length / 2; i++)
                {
                    double numberToCompare = sortedNumbers[i];
                    for (int j = 0; j < sortedNumbers.Length / 2; j++)
                    {
                        if (numberToCompare != sortedNumbers[j])
                        {
                            if (numberToCompare != sortedNumbers[j + 1] || numberToCompare != sortedNumbers[j + 2])
                            {
                                uniqueNum = numberToCompare;
                            }
                            else { uniqueNum = sortedNumbers[j]; }
                        }
                    }
                }
            }
            else
                for (int i = sortedNumbers.Length / 2; i < sortedNumbers.Length; i++)
                {
                    double numberToCompare = sortedNumbers[i];
                    for (int j = 0; j < sortedNumbers.Length / 2; j++)
                    {
                        if (numberToCompare != sortedNumbers[j])
                        {
                            if (numberToCompare != sortedNumbers[j + 1] || numberToCompare != sortedNumbers[j + 2])
                            {
                                uniqueNum = numberToCompare;
                            }
                            else { uniqueNum = sortedNumbers[j]; }
                        }
                    }
                }

            return uniqueNum;
        }*/

    }
}
