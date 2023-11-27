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
    /// SharedStepReferenceModel
    /// </summary>
    [DataContract(Name = "SharedStepReferenceModel")]
    public partial class SharedStepReferenceModel : IEquatable<SharedStepReferenceModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepReferenceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedStepReferenceModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepReferenceModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="entityTypeName">entityTypeName (required).</param>
        /// <param name="hasThisSharedStepAsStep">hasThisSharedStepAsStep (required).</param>
        /// <param name="hasThisSharedStepAsPrecondition">hasThisSharedStepAsPrecondition (required).</param>
        /// <param name="hasThisSharedStepAsPostcondition">hasThisSharedStepAsPostcondition (required).</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        /// <param name="versionId">used for versioning changes in workitem (required).</param>
        /// <param name="isAutomated">isAutomated (required).</param>
        /// <param name="sectionId">sectionId (required).</param>
        /// <param name="tags">tags.</param>
        public SharedStepReferenceModel(Guid id = default(Guid), long globalId = default(long), string name = default(string), string entityTypeName = default(string), bool hasThisSharedStepAsStep = default(bool), bool hasThisSharedStepAsPrecondition = default(bool), bool hasThisSharedStepAsPostcondition = default(bool), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), string state = default(string), WorkItemPriorityModel priority = default(WorkItemPriorityModel), bool isDeleted = default(bool), Guid versionId = default(Guid), bool isAutomated = default(bool), Guid sectionId = default(Guid), List<TagShortModel> tags = default(List<TagShortModel>))
        {
            this.Id = id;
            this.GlobalId = globalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SharedStepReferenceModel and cannot be null");
            }
            this.Name = name;
            // to ensure "entityTypeName" is required (not null)
            if (entityTypeName == null)
            {
                throw new ArgumentNullException("entityTypeName is a required property for SharedStepReferenceModel and cannot be null");
            }
            this.EntityTypeName = entityTypeName;
            this.HasThisSharedStepAsStep = hasThisSharedStepAsStep;
            this.HasThisSharedStepAsPrecondition = hasThisSharedStepAsPrecondition;
            this.HasThisSharedStepAsPostcondition = hasThisSharedStepAsPostcondition;
            this.CreatedById = createdById;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for SharedStepReferenceModel and cannot be null");
            }
            this.State = state;
            this.Priority = priority;
            this.IsDeleted = isDeleted;
            this.VersionId = versionId;
            this.IsAutomated = isAutomated;
            this.SectionId = sectionId;
            this.ModifiedById = modifiedById;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Basic template&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EntityTypeName
        /// </summary>
        /// <example>&quot;TestCase&quot;</example>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = true)]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Gets or Sets HasThisSharedStepAsStep
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "hasThisSharedStepAsStep", IsRequired = true, EmitDefaultValue = true)]
        public bool HasThisSharedStepAsStep { get; set; }

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
        /// Gets or Sets State
        /// </summary>
        /// <example>&quot;Ready&quot;</example>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// used for versioning changes in workitem
        /// </summary>
        /// <value>used for versioning changes in workitem</value>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "versionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VersionId { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isAutomated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<TagShortModel> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepReferenceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  HasThisSharedStepAsStep: ").Append(HasThisSharedStepAsStep).Append("\n");
            sb.Append("  HasThisSharedStepAsPrecondition: ").Append(HasThisSharedStepAsPrecondition).Append("\n");
            sb.Append("  HasThisSharedStepAsPostcondition: ").Append(HasThisSharedStepAsPostcondition).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as SharedStepReferenceModel);
        }

        /// <summary>
        /// Returns true if SharedStepReferenceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedStepReferenceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedStepReferenceModel input)
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
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EntityTypeName == input.EntityTypeName ||
                    (this.EntityTypeName != null &&
                    this.EntityTypeName.Equals(input.EntityTypeName))
                ) && 
                (
                    this.HasThisSharedStepAsStep == input.HasThisSharedStepAsStep ||
                    this.HasThisSharedStepAsStep.Equals(input.HasThisSharedStepAsStep)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    this.IsAutomated.Equals(input.IsAutomated)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EntityTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasThisSharedStepAsStep.GetHashCode();
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
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
            yield break;
        }
    }

}
