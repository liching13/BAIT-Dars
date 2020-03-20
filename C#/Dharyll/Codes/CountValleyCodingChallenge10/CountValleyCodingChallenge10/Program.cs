using System;

namespace CountValleyCodingChallenge10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valleyCount, steps;
                string path;
                do
                {
                    Console.Write("Enter number of hikers step (Note:steps should be more than 1): ");
                    steps = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter hikers path (Type:\"U\" for Uphill and \"D\" for Downhill EX:UDDDUDUU): ");
                    path = Console.ReadLine().Replace(" ", "").ToUpper();

                    valleyCount = CountingValley(steps, path);

                    if (valleyCount == -1)
                    {
                        Console.Clear();
                        Console.WriteLine("Number of steps must be more than 1!");
                    }
                    else if (valleyCount == -2)
                    {
                        Console.Clear();
                        Console.WriteLine("Please recheck hikers path.");
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine($"Hikers number of step:{steps} Hikers path:{path}");
                        Console.WriteLine($"The number of times the hiker pass the valley is {valleyCount}");
                    }
                } while (valleyCount == -1 || valleyCount == -2);
            }
            catch(Exception e) { Console.WriteLine($"Error:{e.Message}"); }
        }
        
        public static int CountingValley(int steps, string path)
        {
            char[] cPath = path.ToCharArray();
            int seaLvl = 0, valley = 0;

            if (steps <= 1) 
            {
                return -1;
            }
            else if (path.Length != steps)
            {
                return -2;
            }
            else
            {
                foreach (char c in cPath)
                {
                    if(c == 'D'){ seaLvl--; }
                    else if(c == 'U')
                    {
                        seaLvl++;
                        if (seaLvl == 0){ valley++; }
                    }
                    else { return -2; }
                }
                return valley; 
            }
        }
    }
}
