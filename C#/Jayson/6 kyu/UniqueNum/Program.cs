using System;
using System.Collections.Generic;
namespace UniqueNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{FindMissingLetter(new [] {'a','b','c','e'})}");
            }
            public static char FindMissingLetter(char[] input)
            {
            
            // Dictionary<int, char> dict = new Dictionary<int, char>();
                // Put letters a-z into a Dictionary with index from 1-27
                // for(int i =97;i<123;i++){
                    
                //     dict.Add(i,(char)i);
                // }
                char output = ' ';
                for(int i=0; i<input.Length-1;i++){
                    int temp = (int)input[i]+1;
                    if(input[i+1]!=temp)
                            output=(char)temp;
                // Console.WriteLine((char)temp);
                }
        
                return output;
            }
    }
}
