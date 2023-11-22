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
    /// SharedStepReferenceSectionModel
    /// </summary>
    [DataContract(Name = "SharedStepReferenceSectionModel")]
    public partial class SharedStepReferenceSectionModel : IEquatable<SharedStepReferenceSectionModel>, IValidatableObject
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
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Basic template&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HasThisSharedStepAsPrecondition
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "hasThisSharedStepAsPrecondition", IsRequired = true, EmitDefaultValue = true)]
        public bool HasThisSharedStepAsPrecondition { get; set; }

        /// <summary>
        /// Gets or Sets HasThisSharedStepAsPostcondition
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "hasThisSharedStepAsPostcondition", IsRequired = true, EmitDefaultValue = true)]
        public bool HasThisSharedStepAsPostcondition { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        /// <example>&quot;2023-11-20T14:26:39.252984700Z&quot;</example>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        /// <example>&quot;2023-11-20T14:26:39.252984700Z&quot;</example>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        /// <example>true</example>
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SharedStepReferenceSectionModel);
        }

        /// <summary>
        /// Returns true if SharedStepReferenceSectionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedStepReferenceSectionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedStepReferenceSectionModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HasThisSharedStepAsPrecondition == input.HasThisSharedStepAsPrecondition ||
                    this.HasThisSharedStepAsPrecondition.Equals(input.HasThisSharedStepAsPrecondition)
                ) && 
                (
                    this.HasThisSharedStepAsPostcondition == input.HasThisSharedStepAsPostcondition ||
                    this.HasThisSharedStepAsPostcondition.Equals(input.HasThisSharedStepAsPostcondition)
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasThisSharedStepAsPrecondition.GetHashCode();
                hashCode = (hashCode * 59) + this.HasThisSharedStepAsPostcondition.GetHashCode();
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
