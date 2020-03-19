using System;

namespace KangarooCodingChallenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "repeat";
            do
            {
                Console.WriteLine("Enter two(2) Kangaroo Location and Speed followed by the number of jumps they should do");
                Console.WriteLine("(Ex: 0 3 4 2 : K1 = 0, S1 = 3, K2 = 4, S2 = 2) \n(Ex: 4 : Number of Jumps = 4)");
                Console.WriteLine("Enter here:");
                result = GetJump(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse(Console.ReadLine()));
            } while (result == "repeat");

            Console.WriteLine($"Will the kangaroo meet? {result}");
        }
        public static string GetJump(string[] kangarooJump, int jumpDistance)
        {
            string jump = "repeat";
            int fKang = int.Parse(kangarooJump[0]);
            int fKangJump = int.Parse(kangarooJump[1]);
            int sKang = int.Parse(kangarooJump[2]);
            int sKangJump = int.Parse(kangarooJump[3]);

            if((0 <= fKang && fKang < sKang && sKang <= 10000) && (0 < fKangJump && fKangJump <= 10000) && (0 < sKangJump && sKangJump < 10000) && (0 < jumpDistance && jumpDistance < 10000))
            {
                for(int i = 0; i < jumpDistance; i++)
                {
                    fKang += fKangJump;
                    sKang += sKangJump;

                    if (fKang == sKang) { jump = "Yes"; break; }
                    else { jump = "No"; }
                }
            }
            return jump;
        }
    }

    
}
