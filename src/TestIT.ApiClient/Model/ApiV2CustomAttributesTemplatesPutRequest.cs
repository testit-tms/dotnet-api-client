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
    /// ApiV2CustomAttributesTemplatesPutRequest
    /// </summary>
    [DataContract(Name = "_api_v2_customAttributes_templates_put_request")]
    public partial class ApiV2CustomAttributesTemplatesPutRequest : IEquatable<ApiV2CustomAttributesTemplatesPutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2CustomAttributesTemplatesPutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2CustomAttributesTemplatesPutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2CustomAttributesTemplatesPutRequest" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the attribute template (required).</param>
        /// <param name="customAttributeIds">Collection of attribute IDs.</param>
        /// <param name="name">Custom attributes template name (required).</param>
        public ApiV2CustomAttributesTemplatesPutRequest(Guid id = default(Guid), List<Guid> customAttributeIds = default(List<Guid>), string name = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiV2CustomAttributesTemplatesPutRequest and cannot be null");
            }
            this.Name = name;
            this.CustomAttributeIds = customAttributeIds;
        }

        /// <summary>
        /// Unique ID of the attribute template
        /// </summary>
        /// <value>Unique ID of the attribute template</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Collection of attribute IDs
        /// </summary>
        /// <value>Collection of attribute IDs</value>
        [DataMember(Name = "customAttributeIds", EmitDefaultValue = true)]
        public List<Guid> CustomAttributeIds { get; set; }

        /// <summary>
        /// Custom attributes template name
        /// </summary>
        /// <value>Custom attributes template name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2CustomAttributesTemplatesPutRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomAttributeIds: ").Append(CustomAttributeIds).Append("\n");
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
            return this.Equals(input as ApiV2CustomAttributesTemplatesPutRequest);
        }

        /// <summary>
        /// Returns true if ApiV2CustomAttributesTemplatesPutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2CustomAttributesTemplatesPutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2CustomAttributesTemplatesPutRequest input)
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
                    this.CustomAttributeIds == input.CustomAttributeIds ||
                    this.CustomAttributeIds != null &&
                    input.CustomAttributeIds != null &&
                    this.CustomAttributeIds.SequenceEqual(input.CustomAttributeIds)
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
                if (this.CustomAttributeIds != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeIds.GetHashCode();
                }
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
