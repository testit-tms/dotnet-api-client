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
    /// SharedStepReferenceSectionModel
    /// </summary>
    [DataContract(Name = "SharedStepReferenceSectionModel")]
    public partial class SharedStepReferenceSectionModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepReferenceSectionModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedStepReferenceSectionModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepReferenceSectionModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="hasThisSharedStepAsPrecondition">hasThisSharedStepAsPrecondition (required).</param>
        /// <param name="hasThisSharedStepAsPostcondition">hasThisSharedStepAsPostcondition (required).</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        public SharedStepReferenceSectionModel(Guid id = default(Guid), string name = default(string), bool hasThisSharedStepAsPrecondition = default(bool), bool hasThisSharedStepAsPostcondition = default(bool), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), bool isDeleted = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SharedStepReferenceSectionModel and cannot be null");
            }
            this.Name = name;
            this.HasThisSharedStepAsPrecondition = hasThisSharedStepAsPrecondition;
            this.HasThisSharedStepAsPostcondition = hasThisSharedStepAsPostcondition;
            this.CreatedById = createdById;
            this.IsDeleted = isDeleted;
            this.ModifiedById = modifiedById;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>cbb88fe6-c193-48e9-9e37-323fbc38de5f</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Basic template</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HasThisSharedStepAsPrecondition
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasThisSharedStepAsPrecondition", IsRequired = true, EmitDefaultValue = true)]
        public bool HasThisSharedStepAsPrecondition { get; set; }

        /// <summary>
        /// Gets or Sets HasThisSharedStepAsPostcondition
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasThisSharedStepAsPostcondition", IsRequired = true, EmitDefaultValue = true)]
        public bool HasThisSharedStepAsPostcondition { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        /*
        <example>cbb88fe6-c193-48e9-9e37-323fbc38de5f</example>
        */
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        /*
        <example>cbb88fe6-c193-48e9-9e37-323fbc38de5f</example>
        */
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        /*
        <example>2025-02-09T16:32:03.068992100Z</example>
        */
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        /*
        <example>2025-02-09T16:32:03.068992100Z</example>
        */
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepReferenceSectionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HasThisSharedStepAsPrecondition: ").Append(HasThisSharedStepAsPrecondition).Append("\n");
            sb.Append("  HasThisSharedStepAsPostcondition: ").Append(HasThisSharedStepAsPostcondition).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
