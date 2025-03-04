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
    /// SearchCustomAttributeTemplateGetModel
    /// </summary>
    [DataContract(Name = "SearchCustomAttributeTemplateGetModel")]
    public partial class SearchCustomAttributeTemplateGetModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCustomAttributeTemplateGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchCustomAttributeTemplateGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCustomAttributeTemplateGetModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="projectShortestModels">projectShortestModels (required).</param>
        /// <param name="customAttributeModels">customAttributeModels (required).</param>
        public SearchCustomAttributeTemplateGetModel(Guid id = default(Guid), bool isDeleted = default(bool), string name = default(string), List<ProjectShortestModel> projectShortestModels = default(List<ProjectShortestModel>), List<CustomAttributeModel> customAttributeModels = default(List<CustomAttributeModel>))
        {
            this.Id = id;
            this.IsDeleted = isDeleted;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SearchCustomAttributeTemplateGetModel and cannot be null");
            }
            this.Name = name;
            // to ensure "projectShortestModels" is required (not null)
            if (projectShortestModels == null)
            {
                throw new ArgumentNullException("projectShortestModels is a required property for SearchCustomAttributeTemplateGetModel and cannot be null");
            }
            this.ProjectShortestModels = projectShortestModels;
            // to ensure "customAttributeModels" is required (not null)
            if (customAttributeModels == null)
            {
                throw new ArgumentNullException("customAttributeModels is a required property for SearchCustomAttributeTemplateGetModel and cannot be null");
            }
            this.CustomAttributeModels = customAttributeModels;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectShortestModels
        /// </summary>
        [DataMember(Name = "projectShortestModels", IsRequired = true, EmitDefaultValue = true)]
        public List<ProjectShortestModel> ProjectShortestModels { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributeModels
        /// </summary>
        [DataMember(Name = "customAttributeModels", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomAttributeModel> CustomAttributeModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchCustomAttributeTemplateGetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectShortestModels: ").Append(ProjectShortestModels).Append("\n");
            sb.Append("  CustomAttributeModels: ").Append(CustomAttributeModels).Append("\n");
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
            yield break;
        }
    }

}
