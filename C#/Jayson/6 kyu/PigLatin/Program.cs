using System;
using System.Collections.Generic;
namespace PigLatin
{
    class Program
    {
          static void Main(string[] args)
            {
                Console.Write("Enter a sentence: ");
                String input = Console.ReadLine();
                Console.WriteLine(getPigLatin(input));
            
            }
            public static String getPigLatin(String input){
            List<String> ls = new List<String>();
            String[] words = input.Split(" ");

            for(int i=0;i<words.Length;i++){
            ls.Add($"{words[i].Substring(1)}{words[i].ToCharArray().GetValue(0)}ay");
            }
            return String.Join(" ",ls.ToArray());
            }
    }
}
