using System;
using System.Collections;

namespace PigLatinCodingChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any sentence: ");
            Console.WriteLine(PigLatin(Console.ReadLine()));
        }

        public static string PigLatin(string word)
        {
            string[] Wplay = word.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string Rword = "";
            for (int i = 0; i < Wplay.Length; i++)
            {
                Rword += $"{Wplay[i].Substring(1)}{Wplay[i][0]}ay ";
            }

            return Rword;
        }
    }
}
