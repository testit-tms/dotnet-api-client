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
    /// ConfigurationFilterModel
    /// </summary>
    [DataContract(Name = "ConfigurationFilterModel")]
    public partial class ConfigurationFilterModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationFilterModel" /> class.
        /// </summary>
        /// <param name="projectIds">Collection of identifiers of projects from which configurations will be taken.</param>
        /// <param name="name">Filter to search by name (case-insensitive, partial match).</param>
        /// <param name="isDeleted">Is configurations deleted or existing.</param>
        /// <param name="globalIds">Collection of global (integer) identifiers to filter configurations.</param>
        public ConfigurationFilterModel(List<Guid> projectIds = default(List<Guid>), string name = default(string), bool? isDeleted = default(bool?), List<long> globalIds = default(List<long>))
        {
            this.ProjectIds = projectIds;
            this.Name = name;
            this.IsDeleted = isDeleted;
            this.GlobalIds = globalIds;
        }

        /// <summary>
        /// Collection of identifiers of projects from which configurations will be taken
        /// </summary>
        /// <value>Collection of identifiers of projects from which configurations will be taken</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Filter to search by name (case-insensitive, partial match)
        /// </summary>
        /// <value>Filter to search by name (case-insensitive, partial match)</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Is configurations deleted or existing
        /// </summary>
        /// <value>Is configurations deleted or existing</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Collection of global (integer) identifiers to filter configurations
        /// </summary>
        /// <value>Collection of global (integer) identifiers to filter configurations</value>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationFilterModel {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
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
