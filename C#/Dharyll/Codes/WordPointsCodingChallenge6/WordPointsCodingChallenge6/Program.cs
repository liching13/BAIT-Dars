using System;

namespace WordPointsCodingChallenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of words: ");
            Console.WriteLine(GetPoints(Console.ReadLine().ToLower().Split(" ")));
        }

        public static string GetPoints(string[] words)
        {
            int highestPoint = 0, highestPointIndex = 0;
            int[] wordPoints = new int[words.Length];

            for(int i = 0; i < words.Length; i++)
            {
                char[] charPoints = words[i].ToCharArray();
                int points = 0;
                foreach(char a in charPoints)
                {
                    points += a;
                }
                
                if (points > highestPoint) { highestPoint = points; highestPointIndex = i; }

                wordPoints.SetValue(points, i);
            }
            return words[highestPointIndex];
        }
    }
}
