using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal policyRating;
        public void Rate()
        {
            Log.Printf("Starting rate.", "Loading policy.");
            // FileSource Class will only be instantiated when method Rate is called
            FileSource File = new FileSource("policy.json");
            // Loads the File and Deserialize its content
            Policy policy = File.DeserializeFile();
            // Creates the policy identifier object
            PolicyIdentifierFactory policyIdentifier = new PolicyIdentifierFactory(this);
            // Identifies the policy and create its instance.
            Rating policyType = policyIdentifier.IdentifyPolicy(policy);
            // Computes the Rate base on the identified policy
            policyType.Rate(policy);

            Log.Printf("Rating completed.");
        }
    }
}
