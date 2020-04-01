using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class UnknownPolicy : Rating
    {
        public UnknownPolicy(RatingEngine ratingEngine) : base(ratingEngine) { }

        public override void Rate(Policy policy)
        {
            Log.Printf("Unknown policy type.", "The Policy you are searching for is not being offered.");
        }
    }
}
