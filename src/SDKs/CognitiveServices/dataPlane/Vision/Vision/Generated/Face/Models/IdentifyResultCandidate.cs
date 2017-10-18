// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.CognitiveServices;
    using Microsoft.Azure.CognitiveServices.Vision;
    using Microsoft.Azure.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// All possible faces that may qualify.
    /// </summary>
    public partial class IdentifyResultCandidate
    {
        /// <summary>
        /// Initializes a new instance of the IdentifyResultCandidate class.
        /// </summary>
        public IdentifyResultCandidate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentifyResultCandidate class.
        /// </summary>
        /// <param name="personId">Id of candidate</param>
        /// <param name="confidence">Confidence level in the candidate person:
        /// a float number between 0.0 and 1.0.</param>
        public IdentifyResultCandidate(string personId, double confidence)
        {
            PersonId = personId;
            Confidence = confidence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of candidate
        /// </summary>
        [JsonProperty(PropertyName = "personId")]
        public string PersonId { get; set; }

        /// <summary>
        /// Gets or sets confidence level in the candidate person: a float
        /// number between 0.0 and 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PersonId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PersonId");
            }
            if (Confidence > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Confidence", 1);
            }
            if (Confidence < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Confidence", 0);
            }
        }
    }
}