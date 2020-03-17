using System;

namespace scorewords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"{High("a fgztfhudkxsjqbcbg zzxsktnyub")}");
        }
        public static string High(string s){
        String[] words = s.Split(null);
        int index = 0;
        int max = 0;
        for(int i = 0 ; i<words.Length;i++){
            int sum = 0;
            char[] temp = words[i].ToCharArray();
                for(int o = 0; o <temp.Length;o++){
                    sum+=(int)temp[o] - 96;
                }
                Console.WriteLine($"{words[i]} {sum}");
                if(max<=sum){
                    max=sum;
                    index=i;
                }
        }

        return words[index];
        }
    }
}
