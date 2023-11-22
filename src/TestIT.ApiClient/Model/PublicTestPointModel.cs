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
using FileParameter = TestIt.ApiClient.Client.FileParameter;
using OpenAPIDateConverter = TestIt.ApiClient.Client.OpenAPIDateConverter;

namespace TestIt.ApiClient.Model
{
    /// <summary>
    /// PublicTestPointModel
    /// </summary>
    [DataContract(Name = "PublicTestPointModel")]
    public partial class PublicTestPointModel : IEquatable<PublicTestPointModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTestPointModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicTestPointModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTestPointModel" /> class.
        /// </summary>
        /// <param name="configurationId">configurationId (required).</param>
        /// <param name="configurationGlobalId">configurationGlobalId (required).</param>
        /// <param name="autoTestIds">autoTestIds.</param>
        /// <param name="iterationId">iterationId (required).</param>
        /// <param name="parameterModels">parameterModels.</param>
        public PublicTestPointModel(Guid configurationId = default(Guid), long configurationGlobalId = default(long), List<Guid> autoTestIds = default(List<Guid>), Guid iterationId = default(Guid), List<ParameterShortModel> parameterModels = default(List<ParameterShortModel>))
        {
            this.ConfigurationId = configurationId;
            this.ConfigurationGlobalId = configurationGlobalId;
            this.IterationId = iterationId;
            this.AutoTestIds = autoTestIds;
            this.ParameterModels = parameterModels;
        }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationGlobalId
        /// </summary>
        [DataMember(Name = "configurationGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long ConfigurationGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestIds
        /// </summary>
        [DataMember(Name = "autoTestIds", EmitDefaultValue = true)]
        public List<Guid> AutoTestIds { get; set; }

        /// <summary>
        /// Gets or Sets IterationId
        /// </summary>
        [DataMember(Name = "iterationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Gets or Sets ParameterModels
        /// </summary>
        [DataMember(Name = "parameterModels", EmitDefaultValue = true)]
        public List<ParameterShortModel> ParameterModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicTestPointModel {\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  ConfigurationGlobalId: ").Append(ConfigurationGlobalId).Append("\n");
            sb.Append("  AutoTestIds: ").Append(AutoTestIds).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
            sb.Append("  ParameterModels: ").Append(ParameterModels).Append("\n");
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
            return this.Equals(input as PublicTestPointModel);
        }

        /// <summary>
        /// Returns true if PublicTestPointModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicTestPointModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicTestPointModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.ConfigurationGlobalId == input.ConfigurationGlobalId ||
                    this.ConfigurationGlobalId.Equals(input.ConfigurationGlobalId)
                ) && 
                (
                    this.AutoTestIds == input.AutoTestIds ||
                    this.AutoTestIds != null &&
                    input.AutoTestIds != null &&
                    this.AutoTestIds.SequenceEqual(input.AutoTestIds)
                ) && 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
                ) && 
                (
                    this.ParameterModels == input.ParameterModels ||
                    this.ParameterModels != null &&
                    input.ParameterModels != null &&
                    this.ParameterModels.SequenceEqual(input.ParameterModels)
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
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConfigurationGlobalId.GetHashCode();
                if (this.AutoTestIds != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestIds.GetHashCode();
                }
                if (this.IterationId != null)
                {
                    hashCode = (hashCode * 59) + this.IterationId.GetHashCode();
                }
                if (this.ParameterModels != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterModels.GetHashCode();
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
