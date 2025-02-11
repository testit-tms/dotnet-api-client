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
    /// SharedStepResult
    /// </summary>
    [DataContract(Name = "SharedStepResult")]
    public partial class SharedStepResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedStepResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepResult" /> class.
        /// </summary>
        /// <param name="stepId">stepId (required).</param>
        /// <param name="outcome">outcome (required).</param>
        public SharedStepResult(Guid stepId = default(Guid), string outcome = default(string))
        {
            this.StepId = stepId;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for SharedStepResult and cannot be null");
            }
            this.Outcome = outcome;
        }

        /// <summary>
        /// Gets or Sets StepId
        /// </summary>
        [DataMember(Name = "stepId", IsRequired = true, EmitDefaultValue = true)]
        public Guid StepId { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepResult {\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
