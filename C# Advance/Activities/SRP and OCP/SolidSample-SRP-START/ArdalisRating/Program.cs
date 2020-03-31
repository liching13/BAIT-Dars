using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Printf("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.policyRating > 0)
            {
                Log.Printf($"Rating: {engine.policyRating}");
            }
            else
            {
                Log.Printf("No rating produced.");
            }

        }
    }
}
