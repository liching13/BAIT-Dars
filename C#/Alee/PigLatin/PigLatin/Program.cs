using System;

namespace PigLatin
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter input: ");
            string str = Console.ReadLine();
            Console.WriteLine(pigLat(str));
        }

        public static string pigLat(string input)
        {
            string piglat = "";
            int temp = 0;
            string tempchar = "";
            for (int k = 0; k < input.Length; k++)
            {
                if (k == temp)
                {
                    tempchar = input[k].ToString();
                }
                else if (!input[k].ToString().Equals(" "))
                {
                    piglat = piglat + input[k];
                }
                else
                {
                    piglat = piglat + tempchar + "ay ";
                    temp = k + 1;
                }
            }
            piglat = piglat = piglat + tempchar + "ay";
            return piglat;
        }

    }
}
