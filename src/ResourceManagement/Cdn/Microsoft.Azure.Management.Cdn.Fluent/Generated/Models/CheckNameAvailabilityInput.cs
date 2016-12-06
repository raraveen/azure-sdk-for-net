// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Input of CheckNameAvailability API.
    /// </summary>
    public partial class CheckNameAvailabilityInput
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        public CheckNameAvailabilityInput() { }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        /// <param name="name">The resource name to validate.</param>
        public CheckNameAvailabilityInput(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Static constructor for CheckNameAvailabilityInput class.
        /// </summary>
        static CheckNameAvailabilityInput()
        {
            Type = "Microsoft.Cdn/Profiles/Endpoints";
        }

        /// <summary>
        /// Gets or sets the resource name to validate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the resource whose name is to be validated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}