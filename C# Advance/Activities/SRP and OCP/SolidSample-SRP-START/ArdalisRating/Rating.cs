using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    abstract class Rating
    {
        protected readonly RatingEngine ratingEngine;
        public Rating(RatingEngine ratingEngine)
        {
            this.ratingEngine = ratingEngine;
        }
        public abstract void Rate(Policy policy);
    }
}
