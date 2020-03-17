using System;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
                string str, nospaces;

                Console.WriteLine("Enter a palimdrome string: ");
                str = Console.ReadLine();
                nospaces = str.Replace(" ", "").ToLower();
                if (palCheck(nospaces))
                {
                    Console.WriteLine("It is a palimdrome");
                }
                else
                {
                    Console.WriteLine("It is not a palimdrome");
                }

            }

            public static Boolean palCheck(String a)
            {

                char[] toAr = a.ToCharArray();
                Array.Reverse(toAr);

                for (int k = 0; k < a.Length; k++)
                {
                    if (a[k] != toAr[k])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
}
