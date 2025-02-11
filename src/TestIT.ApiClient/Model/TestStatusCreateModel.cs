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
    /// TestStatusCreateModel
    /// </summary>
    [DataContract(Name = "TestStatusCreateModel")]
    public partial class TestStatusCreateModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestStatusCreateModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestStatusCreateModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestStatusCreateModel" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="description">description.</param>
        public TestStatusCreateModel(string name = default(string), TestStatusType type = default(TestStatusType), string code = default(string), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestStatusCreateModel and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for TestStatusCreateModel and cannot be null");
            }
            this.Code = code;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestStatusCreateModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Code, length must be less than 100.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Code, length must be greater than 0.", new [] { "Code" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }

}
