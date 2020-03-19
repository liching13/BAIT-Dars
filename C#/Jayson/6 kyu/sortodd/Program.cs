using System;
using System.Collections.Generic;
namespace sortodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {5, 3, 2, 8, 1, 4};
            for(int i =0;i<input.Length;i++)
            {
                Console.WriteLine(input[i]);
            }
            SortArray(input);
            Console.WriteLine(" ");
               for(int i =0;i<input.Length;i++)
            {
                Console.WriteLine(input[i]);
            }
        }
        public static int[] SortArray(int[] array)
        {
            int oddcount=0;
            int temp=0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]%2!=0)
                    oddcount++;
            }
            int[] oddarray = new int[oddcount];
            
            for(int i =0; i<array.Length;i++){
                if(array[i]%2!=0)
                {
                    oddarray[temp]=array[i];
                    temp++;
                 }
            }
            Array.Sort(oddarray);
            temp = 0;
            for(int i=0;i<array.Length;i++){
                if(array[i]%2==1){
                    array[i]=oddarray[temp];
                    temp++;
                }
            }
            return array;
        }
    }
}
