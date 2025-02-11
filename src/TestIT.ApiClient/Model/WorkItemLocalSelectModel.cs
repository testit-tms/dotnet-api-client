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
    /// Model containing options to filter work items
    /// </summary>
    [DataContract(Name = "WorkItemLocalSelectModel")]
    public partial class WorkItemLocalSelectModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemLocalSelectModel" /> class.
        /// </summary>
        /// <param name="filter">Collection of filters to apply to search.</param>
        /// <param name="extractionModel">Rules for different level entities inclusion/exclusion.</param>
        public WorkItemLocalSelectModel(WorkItemLocalFilterModel filter = default(WorkItemLocalFilterModel), WorkItemExtractionModel extractionModel = default(WorkItemExtractionModel))
        {
            this.Filter = filter;
            this.ExtractionModel = extractionModel;
        }

        /// <summary>
        /// Collection of filters to apply to search
        /// </summary>
        /// <value>Collection of filters to apply to search</value>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public WorkItemLocalFilterModel Filter { get; set; }

        /// <summary>
        /// Rules for different level entities inclusion/exclusion
        /// </summary>
        /// <value>Rules for different level entities inclusion/exclusion</value>
        [DataMember(Name = "extractionModel", EmitDefaultValue = true)]
        public WorkItemExtractionModel ExtractionModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemLocalSelectModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ExtractionModel: ").Append(ExtractionModel).Append("\n");
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
