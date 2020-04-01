using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class AutoPolicy : Rating
    {
        public AutoPolicy(RatingEngine ratingEngine) : base(ratingEngine){}
        public override void Rate(Policy policy)
        {
            Log.Printf("Rating AUTO policy...", "Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Log.Printf("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    ratingEngine.policyRating = 1000m;
                }
                ratingEngine.policyRating = 900m;
            }
        }
    }
}
