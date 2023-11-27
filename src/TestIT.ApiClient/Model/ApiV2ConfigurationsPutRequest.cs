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
    /// ApiV2ConfigurationsPutRequest
    /// </summary>
    [DataContract(Name = "_api_v2_configurations_put_request")]
    public partial class ApiV2ConfigurationsPutRequest : IEquatable<ApiV2ConfigurationsPutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2ConfigurationsPutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2ConfigurationsPutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2ConfigurationsPutRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="description">description.</param>
        /// <param name="parameters">parameters (required).</param>
        /// <param name="projectId">This property is used to link configuration with project (required).</param>
        /// <param name="isDefault">isDefault (required).</param>
        /// <param name="name">name (required).</param>
        public ApiV2ConfigurationsPutRequest(Guid id = default(Guid), string description = default(string), Dictionary<string, string> parameters = default(Dictionary<string, string>), Guid projectId = default(Guid), bool isDefault = default(bool), string name = default(string))
        {
            this.Id = id;
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters is a required property for ApiV2ConfigurationsPutRequest and cannot be null");
            }
            this.Parameters = parameters;
            this.ProjectId = projectId;
            this.IsDefault = isDefault;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiV2ConfigurationsPutRequest and cannot be null");
            }
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>&quot;Default configuration&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// This property is used to link configuration with project
        /// </summary>
        /// <value>This property is used to link configuration with project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Default&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2ConfigurationsPutRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ApiV2ConfigurationsPutRequest);
        }

        /// <summary>
        /// Returns true if ApiV2ConfigurationsPutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2ConfigurationsPutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2ConfigurationsPutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
