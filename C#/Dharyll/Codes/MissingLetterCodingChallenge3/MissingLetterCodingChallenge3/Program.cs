using System;
using System.Text;

namespace MissingLetterCodingChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the letters: ");
            char[] letters = Console.ReadLine().Replace(" ","").ToCharArray();
            
            Array.Sort(letters);

            //Display the output
            foreach (char c in letters) { Console.Write($"{c} "); }
            Console.Write($"=> {GetMissingLetter(letters)}");
            
        }

        public static char GetMissingLetter(char[] arrOfLetters)
        {
            //Convert array of letters to array of ASCII Codes
            byte[] asciiCode = Encoding.ASCII.GetBytes(arrOfLetters);

            //Increase the value of the last element of the ASCII array by 1 and Convert it into character
            char missingLetter = Convert.ToChar(asciiCode[asciiCode.Length - 1] + 1);

            return missingLetter;
        }
    }
}
