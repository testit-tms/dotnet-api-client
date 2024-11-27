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
    /// GlobalSearchItemResult
    /// </summary>
    [DataContract(Name = "GlobalSearchItemResult")]
    public partial class GlobalSearchItemResult : IEquatable<GlobalSearchItemResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchItemResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalSearchItemResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchItemResult" /> class.
        /// </summary>
        /// <param name="resourceType">resourceType (required).</param>
        /// <param name="resourceId">resourceId (required).</param>
        /// <param name="globalId">globalId.</param>
        /// <param name="name">name (required).</param>
        /// <param name="projectGlobalId">projectGlobalId (required).</param>
        public GlobalSearchItemResult(string resourceType = default(string), Guid resourceId = default(Guid), long? globalId = default(long?), string name = default(string), long projectGlobalId = default(long))
        {
            // to ensure "resourceType" is required (not null)
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType is a required property for GlobalSearchItemResult and cannot be null");
            }
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GlobalSearchItemResult and cannot be null");
            }
            this.Name = name;
            this.ProjectGlobalId = projectGlobalId;
            this.GlobalId = globalId;
        }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name = "resourceType", IsRequired = true, EmitDefaultValue = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name = "resourceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ResourceId { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        [DataMember(Name = "globalId", EmitDefaultValue = true)]
        public long? GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectGlobalId
        /// </summary>
        [DataMember(Name = "projectGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long ProjectGlobalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GlobalSearchItemResult {\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectGlobalId: ").Append(ProjectGlobalId).Append("\n");
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
            return this.Equals(input as GlobalSearchItemResult);
        }

        /// <summary>
        /// Returns true if GlobalSearchItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalSearchItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalSearchItemResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    (this.GlobalId != null &&
                    this.GlobalId.Equals(input.GlobalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectGlobalId == input.ProjectGlobalId ||
                    this.ProjectGlobalId.Equals(input.ProjectGlobalId)
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
                if (this.ResourceType != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceType.GetHashCode();
                }
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
                }
                if (this.GlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProjectGlobalId.GetHashCode();
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
