using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class FloodPolicy : Rating
    {
        public FloodPolicy(RatingEngine ratingEngine) : base(ratingEngine){ }

        public override void Rate(Policy policy)
        {
            Log.Printf("Rating Flood policy...", "Validating policy.");
            ratingEngine.policyRating = 12345m;
        }
    }
}
