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
    /// AutoTestBulkDeleteApiModel
    /// </summary>
    [DataContract(Name = "AutoTestBulkDeleteApiModel")]
    public partial class AutoTestBulkDeleteApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestBulkDeleteApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestBulkDeleteApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestBulkDeleteApiModel" /> class.
        /// </summary>
        /// <param name="autoTestSelect">autoTestSelect (required).</param>
        public AutoTestBulkDeleteApiModel(AutoTestSelectModel autoTestSelect = default(AutoTestSelectModel))
        {
            // to ensure "autoTestSelect" is required (not null)
            if (autoTestSelect == null)
            {
                throw new ArgumentNullException("autoTestSelect is a required property for AutoTestBulkDeleteApiModel and cannot be null");
            }
            this.AutoTestSelect = autoTestSelect;
        }

        /// <summary>
        /// Gets or Sets AutoTestSelect
        /// </summary>
        [DataMember(Name = "autoTestSelect", IsRequired = true, EmitDefaultValue = true)]
        public AutoTestSelectModel AutoTestSelect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestBulkDeleteApiModel {\n");
            sb.Append("  AutoTestSelect: ").Append(AutoTestSelect).Append("\n");
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
