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
    /// ConfigurationByParametersModel
    /// </summary>
    [DataContract(Name = "ConfigurationByParametersModel")]
    public partial class ConfigurationByParametersModel : IEquatable<ConfigurationByParametersModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationByParametersModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationByParametersModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationByParametersModel" /> class.
        /// </summary>
        /// <param name="projectId">This property is used to link configuration with project (required).</param>
        /// <param name="parameterIds">parameterIds (required).</param>
        public ConfigurationByParametersModel(Guid projectId = default(Guid), List<Guid> parameterIds = default(List<Guid>))
        {
            this.ProjectId = projectId;
            // to ensure "parameterIds" is required (not null)
            if (parameterIds == null)
            {
                throw new ArgumentNullException("parameterIds is a required property for ConfigurationByParametersModel and cannot be null");
            }
            this.ParameterIds = parameterIds;
        }

        /// <summary>
        /// This property is used to link configuration with project
        /// </summary>
        /// <value>This property is used to link configuration with project</value>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ParameterIds
        /// </summary>
        [DataMember(Name = "parameterIds", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> ParameterIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationByParametersModel {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ParameterIds: ").Append(ParameterIds).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationByParametersModel);
        }

        /// <summary>
        /// Returns true if ConfigurationByParametersModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationByParametersModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationByParametersModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ParameterIds == input.ParameterIds ||
                    this.ParameterIds != null &&
                    input.ParameterIds != null &&
                    this.ParameterIds.SequenceEqual(input.ParameterIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ParameterIds != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterIds.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
