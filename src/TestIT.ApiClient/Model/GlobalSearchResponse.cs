/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = TestIT.ApiClient.Client.FileParameter;
using OpenAPIDateConverter = TestIT.ApiClient.Client.OpenAPIDateConverter;

namespace TestIT.ApiClient.Model
{
    /// <summary>
    /// GlobalSearchResponse
    /// </summary>
    [DataContract(Name = "GlobalSearchResponse")]
    public partial class GlobalSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchResponse" /> class.
        /// </summary>
        /// <param name="results">results (required).</param>
        /// <param name="moreResultsAvailable">moreResultsAvailable (required).</param>
        /// <param name="availableResourceTypes">availableResourceTypes (required).</param>
        public GlobalSearchResponse(List<GlobalSearchItemResult> results = default(List<GlobalSearchItemResult>), bool moreResultsAvailable = default(bool), List<string> availableResourceTypes = default(List<string>))
        {
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for GlobalSearchResponse and cannot be null");
            }
            this.Results = results;
            this.MoreResultsAvailable = moreResultsAvailable;
            // to ensure "availableResourceTypes" is required (not null)
            if (availableResourceTypes == null)
            {
                throw new ArgumentNullException("availableResourceTypes is a required property for GlobalSearchResponse and cannot be null");
            }
            this.AvailableResourceTypes = availableResourceTypes;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<GlobalSearchItemResult> Results { get; set; }

        /// <summary>
        /// Gets or Sets MoreResultsAvailable
        /// </summary>
        [DataMember(Name = "moreResultsAvailable", IsRequired = true, EmitDefaultValue = true)]
        public bool MoreResultsAvailable { get; set; }

        /// <summary>
        /// Gets or Sets AvailableResourceTypes
        /// </summary>
        [DataMember(Name = "availableResourceTypes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AvailableResourceTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GlobalSearchResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  MoreResultsAvailable: ").Append(MoreResultsAvailable).Append("\n");
            sb.Append("  AvailableResourceTypes: ").Append(AvailableResourceTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
