using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    class LifePolicy : Rating
    {
        public LifePolicy(RatingEngine ratingEngine) : base(ratingEngine) { }
        public override void Rate(Policy policy)
        {
            Log.Printf("Rating LIFE policy...", "Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Log.Printf("Life policy must include Date of Birth.");
                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Log.Printf("Centenarians are not eligible for coverage.");
                return;
            }
            if (policy.Amount == 0)
            {
                Log.Printf("Life policy must include an Amount.");
                return;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
               ratingEngine.policyRating = baseRate * 2;
            }
            ratingEngine.policyRating = baseRate;
        }
    }
}
