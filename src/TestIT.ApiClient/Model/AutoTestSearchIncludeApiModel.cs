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
    /// AutoTestSearchIncludeApiModel
    /// </summary>
    [DataContract(Name = "AutoTestSearchIncludeApiModel")]
    public partial class AutoTestSearchIncludeApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestSearchIncludeApiModel" /> class.
        /// </summary>
        /// <param name="includeSteps">If autotest steps will be included.</param>
        /// <param name="includeLinks">If autotest links will be included.</param>
        /// <param name="includeLabels">If autotest labels will be included.</param>
        public AutoTestSearchIncludeApiModel(bool? includeSteps = default(bool?), bool? includeLinks = default(bool?), bool? includeLabels = default(bool?))
        {
            this.IncludeSteps = includeSteps;
            this.IncludeLinks = includeLinks;
            this.IncludeLabels = includeLabels;
        }

        /// <summary>
        /// If autotest steps will be included
        /// </summary>
        /// <value>If autotest steps will be included</value>
        [DataMember(Name = "includeSteps", EmitDefaultValue = true)]
        public bool? IncludeSteps { get; set; }

        /// <summary>
        /// If autotest links will be included
        /// </summary>
        /// <value>If autotest links will be included</value>
        [DataMember(Name = "includeLinks", EmitDefaultValue = true)]
        public bool? IncludeLinks { get; set; }

        /// <summary>
        /// If autotest labels will be included
        /// </summary>
        /// <value>If autotest labels will be included</value>
        [DataMember(Name = "includeLabels", EmitDefaultValue = true)]
        public bool? IncludeLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestSearchIncludeApiModel {\n");
            sb.Append("  IncludeSteps: ").Append(IncludeSteps).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
            sb.Append("  IncludeLabels: ").Append(IncludeLabels).Append("\n");
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
