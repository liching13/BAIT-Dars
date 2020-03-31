using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class PolicyIdentifierFactory
    {
        private readonly RatingEngine _ratingEngine;
        public PolicyIdentifierFactory(RatingEngine ratingEngine)
        {
            this._ratingEngine = ratingEngine;
        }

        public Rating IdentifyPolicy(Policy policy)
        {
            Rating ratingImplementation;

            switch (policy.Type)
            {
                case PolicyType.Auto:
                    ratingImplementation = new AutoPolicy(_ratingEngine);
                    break;

                case PolicyType.Land:
                    ratingImplementation = new LandPolicy(_ratingEngine);
                    break;

                case PolicyType.Life:
                    ratingImplementation = new LifePolicy(_ratingEngine);
                    break;
                case PolicyType.Flood:
                    ratingImplementation = new FloodPolicy(_ratingEngine);
                    break;

                default:
                    Log.Printf("Unknown policy type.",
                        "The Policy you are searching for is not being offered.");
                    ratingImplementation = null;
                    break;
            }
            return ratingImplementation;
        }
    }
}
