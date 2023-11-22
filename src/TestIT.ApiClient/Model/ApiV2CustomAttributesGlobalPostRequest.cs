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
    /// ApiV2CustomAttributesGlobalPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_customAttributes_global_post_request")]
    public partial class ApiV2CustomAttributesGlobalPostRequest : IEquatable<ApiV2CustomAttributesGlobalPostRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public CustomAttributeTypesEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2CustomAttributesGlobalPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2CustomAttributesGlobalPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2CustomAttributesGlobalPostRequest" /> class.
        /// </summary>
        /// <param name="name">Name of attribute (required).</param>
        /// <param name="isEnabled">Indicates whether the attribute is available.</param>
        /// <param name="isRequired">Indicates whether the attribute value is mandatory to specify.</param>
        /// <param name="options">Collection of attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only.</param>
        /// <param name="type">type (required).</param>
        public ApiV2CustomAttributesGlobalPostRequest(string name = default(string), bool? isEnabled = default(bool?), bool? isRequired = default(bool?), List<CustomAttributeOptionPostModel> options = default(List<CustomAttributeOptionPostModel>), CustomAttributeTypesEnum type = default(CustomAttributeTypesEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiV2CustomAttributesGlobalPostRequest and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.IsEnabled = isEnabled;
            this.IsRequired = isRequired;
            this.Options = options;
        }

        /// <summary>
        /// Name of attribute
        /// </summary>
        /// <value>Name of attribute</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the attribute is available
        /// </summary>
        /// <value>Indicates whether the attribute is available</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Indicates whether the attribute value is mandatory to specify
        /// </summary>
        /// <value>Indicates whether the attribute value is mandatory to specify</value>
        [DataMember(Name = "isRequired", EmitDefaultValue = true)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Collection of attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only
        /// </summary>
        /// <value>Collection of attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only</value>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<CustomAttributeOptionPostModel> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2CustomAttributesGlobalPostRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ApiV2CustomAttributesGlobalPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2CustomAttributesGlobalPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2CustomAttributesGlobalPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2CustomAttributesGlobalPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IsEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                }
                if (this.IsRequired != null)
                {
                    hashCode = (hashCode * 59) + this.IsRequired.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
