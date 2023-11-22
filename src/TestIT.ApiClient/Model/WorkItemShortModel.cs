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
    /// WorkItemShortModel
    /// </summary>
    [DataContract(Name = "WorkItemShortModel")]
    public partial class WorkItemShortModel : IEquatable<WorkItemShortModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemStates State { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemShortModel" /> class.
        /// </summary>
        /// <param name="id">Work Item internal unique identifier (required).</param>
        /// <param name="versionId">Work Item version identifier (required).</param>
        /// <param name="name">Work Item name (required).</param>
        /// <param name="entityTypeName">Work Item type. Possible values: CheckLists, SharedSteps, TestCases (required).</param>
        /// <param name="projectId">Project unique identifier (required).</param>
        /// <param name="sectionId">Identifier of Section where Work Item is located (required).</param>
        /// <param name="sectionName">Section name of Work Item (required).</param>
        /// <param name="isAutomated">Boolean flag determining whether Work Item is automated (required).</param>
        /// <param name="globalId">Work Item global identifier (required).</param>
        /// <param name="duration">Work Item duration (required).</param>
        /// <param name="medianDuration">Work Item median duration.</param>
        /// <param name="attributes">Work Item attributes.</param>
        /// <param name="createdById">Unique identifier of user who created Work Item (required).</param>
        /// <param name="modifiedById">Unique identifier of user who applied the latest modification of Work Item.</param>
        /// <param name="createdDate">Date and time of Work Item creation.</param>
        /// <param name="modifiedDate">Date and time of the latest modification of Work Item.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="isDeleted">Flag determining whether Work Item is deleted (required).</param>
        /// <param name="tagNames">Array of tag names of Work Item.</param>
        /// <param name="iterations">Set of iterations related to Work Item (required).</param>
        /// <param name="links">Set of links related to Work Item (required).</param>
        public WorkItemShortModel(Guid id = default(Guid), Guid versionId = default(Guid), string name = default(string), string entityTypeName = default(string), Guid projectId = default(Guid), Guid sectionId = default(Guid), string sectionName = default(string), bool isAutomated = default(bool), long globalId = default(long), int duration = default(int), long? medianDuration = default(long?), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), WorkItemStates state = default(WorkItemStates), WorkItemPriorityModel priority = default(WorkItemPriorityModel), bool isDeleted = default(bool), List<string> tagNames = default(List<string>), List<IterationModel> iterations = default(List<IterationModel>), List<LinkShortModel> links = default(List<LinkShortModel>))
        {
            this.Id = id;
            this.VersionId = versionId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WorkItemShortModel and cannot be null");
            }
            this.Name = name;
            // to ensure "entityTypeName" is required (not null)
            if (entityTypeName == null)
            {
                throw new ArgumentNullException("entityTypeName is a required property for WorkItemShortModel and cannot be null");
            }
            this.EntityTypeName = entityTypeName;
            this.ProjectId = projectId;
            this.SectionId = sectionId;
            // to ensure "sectionName" is required (not null)
            if (sectionName == null)
            {
                throw new ArgumentNullException("sectionName is a required property for WorkItemShortModel and cannot be null");
            }
            this.SectionName = sectionName;
            this.IsAutomated = isAutomated;
            this.GlobalId = globalId;
            this.Duration = duration;
            this.CreatedById = createdById;
            this.State = state;
            this.Priority = priority;
            this.IsDeleted = isDeleted;
            // to ensure "iterations" is required (not null)
            if (iterations == null)
            {
                throw new ArgumentNullException("iterations is a required property for WorkItemShortModel and cannot be null");
            }
            this.Iterations = iterations;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for WorkItemShortModel and cannot be null");
            }
            this.Links = links;
            this.MedianDuration = medianDuration;
            this.Attributes = attributes;
            this.ModifiedById = modifiedById;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.TagNames = tagNames;
        }

        /// <summary>
        /// Work Item internal unique identifier
        /// </summary>
        /// <value>Work Item internal unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Work Item version identifier
        /// </summary>
        /// <value>Work Item version identifier</value>
        [DataMember(Name = "versionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VersionId { get; set; }

        /// <summary>
        /// Work Item name
        /// </summary>
        /// <value>Work Item name</value>
        /// <example>&quot;Performance test&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Work Item type. Possible values: CheckLists, SharedSteps, TestCases
        /// </summary>
        /// <value>Work Item type. Possible values: CheckLists, SharedSteps, TestCases</value>
        /// <example>&quot;TestCases&quot;</example>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = true)]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Project unique identifier
        /// </summary>
        /// <value>Project unique identifier</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Identifier of Section where Work Item is located
        /// </summary>
        /// <value>Identifier of Section where Work Item is located</value>
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Section name of Work Item
        /// </summary>
        /// <value>Section name of Work Item</value>
        /// <example>&quot;Performance tests section&quot;</example>
        [DataMember(Name = "sectionName", IsRequired = true, EmitDefaultValue = true)]
        public string SectionName { get; set; }

        /// <summary>
        /// Boolean flag determining whether Work Item is automated
        /// </summary>
        /// <value>Boolean flag determining whether Work Item is automated</value>
        [DataMember(Name = "isAutomated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Work Item global identifier
        /// </summary>
        /// <value>Work Item global identifier</value>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Work Item duration
        /// </summary>
        /// <value>Work Item duration</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public int Duration { get; set; }

        /// <summary>
        /// Work Item median duration
        /// </summary>
        /// <value>Work Item median duration</value>
        [DataMember(Name = "medianDuration", EmitDefaultValue = true)]
        public long? MedianDuration { get; set; }

        /// <summary>
        /// Work Item attributes
        /// </summary>
        /// <value>Work Item attributes</value>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Unique identifier of user who created Work Item
        /// </summary>
        /// <value>Unique identifier of user who created Work Item</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique identifier of user who applied the latest modification of Work Item
        /// </summary>
        /// <value>Unique identifier of user who applied the latest modification of Work Item</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Date and time of Work Item creation
        /// </summary>
        /// <value>Date and time of Work Item creation</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time of the latest modification of Work Item
        /// </summary>
        /// <value>Date and time of the latest modification of Work Item</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Flag determining whether Work Item is deleted
        /// </summary>
        /// <value>Flag determining whether Work Item is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Array of tag names of Work Item
        /// </summary>
        /// <value>Array of tag names of Work Item</value>
        [DataMember(Name = "tagNames", EmitDefaultValue = true)]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// Set of iterations related to Work Item
        /// </summary>
        /// <value>Set of iterations related to Work Item</value>
        [DataMember(Name = "iterations", IsRequired = true, EmitDefaultValue = true)]
        public List<IterationModel> Iterations { get; set; }

        /// <summary>
        /// Set of links related to Work Item
        /// </summary>
        /// <value>Set of links related to Work Item</value>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkShortModel> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemShortModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  MedianDuration: ").Append(MedianDuration).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  TagNames: ").Append(TagNames).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as WorkItemShortModel);
        }

        /// <summary>
        /// Returns true if WorkItemShortModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemShortModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemShortModel input)
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
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.SectionName == input.SectionName ||
                    (this.SectionName != null &&
                    this.SectionName.Equals(input.SectionName))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    this.IsAutomated.Equals(input.IsAutomated)
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.MedianDuration == input.MedianDuration ||
                    (this.MedianDuration != null &&
                    this.MedianDuration.Equals(input.MedianDuration))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                    this.State.Equals(input.State)
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
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
                ) && 
                (
                    this.Iterations == input.Iterations ||
                    this.Iterations != null &&
                    input.Iterations != null &&
                    this.Iterations.SequenceEqual(input.Iterations)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EntityTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypeName.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.SectionName != null)
                {
                    hashCode = (hashCode * 59) + this.SectionName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.MedianDuration != null)
                {
                    hashCode = (hashCode * 59) + this.MedianDuration.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.TagNames != null)
                {
                    hashCode = (hashCode * 59) + this.TagNames.GetHashCode();
                }
                if (this.Iterations != null)
                {
                    hashCode = (hashCode * 59) + this.Iterations.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // EntityTypeName (string) minLength
            if (this.EntityTypeName != null && this.EntityTypeName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityTypeName, length must be greater than 1.", new [] { "EntityTypeName" });
            }

            // SectionName (string) minLength
            if (this.SectionName != null && this.SectionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionName, length must be greater than 1.", new [] { "SectionName" });
            }

            yield break;
        }
    }

}
