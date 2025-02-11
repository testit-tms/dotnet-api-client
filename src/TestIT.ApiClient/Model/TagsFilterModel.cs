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
    /// TagsFilterModel
    /// </summary>
    [DataContract(Name = "TagsFilterModel")]
    public partial class TagsFilterModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsFilterModel" /> class.
        /// </summary>
        /// <param name="name">Specifies a tag name to search for.</param>
        /// <param name="createdDate">Specifies a tag range of creation date to search for.</param>
        /// <param name="createdByIds">Specifies a tag creator IDs to search for.</param>
        public TagsFilterModel(string name = default(string), DateTimeRangeSelectorModel createdDate = default(DateTimeRangeSelectorModel), List<Guid> createdByIds = default(List<Guid>))
        {
            this.Name = name;
            this.CreatedDate = createdDate;
            this.CreatedByIds = createdByIds;
        }

        /// <summary>
        /// Specifies a tag name to search for
        /// </summary>
        /// <value>Specifies a tag name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a tag range of creation date to search for
        /// </summary>
        /// <value>Specifies a tag range of creation date to search for</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel CreatedDate { get; set; }

        /// <summary>
        /// Specifies a tag creator IDs to search for
        /// </summary>
        /// <value>Specifies a tag creator IDs to search for</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagsFilterModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
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
