using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class Log
    {
        public static void Printf(params string[] message)
        {
            StringBuilder sentence = new StringBuilder();
            foreach(string s in message)
            {
                sentence
                    .Append(s)
                    .AppendLine();
            }
            Console.WriteLine(sentence.ToString().Remove(sentence.Length - 1,1));
        }
    }
}
