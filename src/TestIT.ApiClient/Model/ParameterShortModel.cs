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
    /// ParameterShortModel
    /// </summary>
    [DataContract(Name = "ParameterShortModel")]
    public partial class ParameterShortModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParameterShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterShortModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="parameterKeyId">parameterKeyId (required).</param>
        /// <param name="value">Value of the parameter (required).</param>
        /// <param name="name">Key of the parameter (required).</param>
        public ParameterShortModel(Guid id = default(Guid), Guid parameterKeyId = default(Guid), string value = default(string), string name = default(string))
        {
            this.Id = id;
            this.ParameterKeyId = parameterKeyId;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ParameterShortModel and cannot be null");
            }
            this.Value = value;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ParameterShortModel and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ParameterKeyId
        /// </summary>
        [DataMember(Name = "parameterKeyId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ParameterKeyId { get; set; }

        /// <summary>
        /// Value of the parameter
        /// </summary>
        /// <value>Value of the parameter</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Key of the parameter
        /// </summary>
        /// <value>Key of the parameter</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterShortModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParameterKeyId: ").Append(ParameterKeyId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 1500)
            {
                yield return new ValidationResult("Invalid value for Value, length must be less than 1500.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Value, length must be greater than 0.", new [] { "Value" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
