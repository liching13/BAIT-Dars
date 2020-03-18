using System;
using System.Collections.Generic;
using System.Linq;

namespace HighestStringValue
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence: ");
            string uInput = Console.ReadLine();
            List<String> strList = ListString(uInput);
            List<int> strListVal = new List<int>();

            foreach (string s in strList)
            {
                int chrSum = 0;
                foreach (char c in s)
                {
                    int cVal = c - 96;
                    chrSum += cVal;
                }
                strListVal.Add(chrSum);
                Console.WriteLine(s + " = " + chrSum);
            }

            int maxVal = strListVal.ToArray().Max();
            int indx = strListVal.IndexOf(maxVal);
            Console.WriteLine("Highest String Value is: " + strList[indx]);

        }

        public static List<String> ListString(string str)
        {
            List<String> listString = new List<string>();
            string temp = "";
            foreach (char c in str.ToLower())
            {
                if (c == ' ')
                {
                    if (!temp.Equals(""))
                    {
                        listString.Add(temp);
                    }
                    temp = "";
                }
                else
                {
                    temp += c;
                }
            }
            listString.Add(temp);

            return listString;
        }

    }
}
