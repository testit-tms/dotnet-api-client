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
    /// ConfigurationExtractionModel
    /// </summary>
    [DataContract(Name = "ConfigurationExtractionModel")]
    public partial class ConfigurationExtractionModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationExtractionModel" /> class.
        /// </summary>
        /// <param name="ids">Extraction parameters for configurations.</param>
        /// <param name="projectIds">Extraction parameters for projects.</param>
        public ConfigurationExtractionModel(GuidExtractionModel ids = default(GuidExtractionModel), GuidExtractionModel projectIds = default(GuidExtractionModel))
        {
            this.Ids = ids;
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Extraction parameters for configurations
        /// </summary>
        /// <value>Extraction parameters for configurations</value>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public GuidExtractionModel Ids { get; set; }

        /// <summary>
        /// Extraction parameters for projects
        /// </summary>
        /// <value>Extraction parameters for projects</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public GuidExtractionModel ProjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationExtractionModel {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
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
