using System;

namespace kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(0,3,4,4));
        }
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
        return v1>v2&&(x2-x1)%(v1-v2)==0?"YES":"NO";
        }
    }
}
