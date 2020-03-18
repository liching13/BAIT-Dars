using System;

namespace consecfibo
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = productFib(714).ToString();
            Console.WriteLine(x);
        }
        public static ulong[] productFib(ulong prod)
        {
            ulong temp1 = 0;
            ulong temp2 = 1;
            
            ulong[] fiboseries = new ulong[99];
            for (int i = 0; i < 99; i++)
            {
                ulong temp3 = temp1;
                temp1 = temp2;
                temp2 = temp3 + temp2;
                fiboseries[i]= temp1*temp2;
                Console.WriteLine(fiboseries[i]);
                if(fiboseries[i]==prod){
                ulong[] output = new ulong[] {temp1,temp2,1};
                return output;
                }else if(fiboseries[i]>prod){
                ulong[] output = new ulong[] {temp1,temp2,0};
                return output;
                }
            }
           
            return new ulong[] { 0, 0, 0 };
        }
    }
}
