using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class LandPolicy : Rating
    {
        public LandPolicy(RatingEngine ratingEngine) : base(ratingEngine) { }
        public override void Rate(Policy policy)
        {
            Log.Printf("Rating LAND policy...", "Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Log.Printf("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Log.Printf("Insufficient bond amount.");
                return;
            }
            ratingEngine.policyRating = policy.BondAmount * 0.05m;
        }

    }
}
