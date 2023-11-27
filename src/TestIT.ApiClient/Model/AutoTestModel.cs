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
    /// AutoTestModel
    /// </summary>
    [DataContract(Name = "AutoTestModel")]
    public partial class AutoTestModel : IEquatable<AutoTestModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestModel" /> class.
        /// </summary>
        /// <param name="globalId">Global ID of the autotest (required).</param>
        /// <param name="isDeleted">Indicates if the autotest is deleted (required).</param>
        /// <param name="mustBeApproved">Indicates if the autotest has unapproved changes from linked work items (required).</param>
        /// <param name="id">Unique ID of the autotest (required).</param>
        /// <param name="createdDate">Creation date of the autotest (required).</param>
        /// <param name="modifiedDate">Last modification date of the project.</param>
        /// <param name="createdById">Unique ID of the project creator (required).</param>
        /// <param name="modifiedById">Unique ID of the project last editor.</param>
        /// <param name="lastTestRunId">Unique ID of the autotest last test run.</param>
        /// <param name="lastTestRunName">Name of the autotest last test run.</param>
        /// <param name="lastTestResultId">Unique ID of the autotest last test result.</param>
        /// <param name="lastTestResultOutcome">Outcome of the autotest last test result.</param>
        /// <param name="stabilityPercentage">Stability percentage of the autotest.</param>
        /// <param name="externalId">External ID of the autotest (required).</param>
        /// <param name="links">Collection of the autotest links.</param>
        /// <param name="projectId">Unique ID of the autotest project (required).</param>
        /// <param name="name">Name of the autotest (required).</param>
        /// <param name="_namespace">Name of the autotest namespace.</param>
        /// <param name="classname">Name of the autotest class.</param>
        /// <param name="steps">Collection of the autotest steps.</param>
        /// <param name="setup">Collection of the autotest setup steps.</param>
        /// <param name="teardown">Collection of the autotest teardown steps.</param>
        /// <param name="title">Name of the autotest in autotest&#39;s card.</param>
        /// <param name="description">Description of the autotest in autotest&#39;s card.</param>
        /// <param name="labels">Collection of the autotest labels.</param>
        /// <param name="isFlaky">Indicates if the autotest is marked as flaky.</param>
        /// <param name="externalKey">External key of the autotest.</param>
        public AutoTestModel(long globalId = default(long), bool isDeleted = default(bool), bool mustBeApproved = default(bool), Guid id = default(Guid), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), Guid? lastTestRunId = default(Guid?), string lastTestRunName = default(string), Guid? lastTestResultId = default(Guid?), string lastTestResultOutcome = default(string), int? stabilityPercentage = default(int?), string externalId = default(string), List<LinkPutModel> links = default(List<LinkPutModel>), Guid projectId = default(Guid), string name = default(string), string _namespace = default(string), string classname = default(string), List<AutoTestStepModel> steps = default(List<AutoTestStepModel>), List<AutoTestStepModel> setup = default(List<AutoTestStepModel>), List<AutoTestStepModel> teardown = default(List<AutoTestStepModel>), string title = default(string), string description = default(string), List<LabelShortModel> labels = default(List<LabelShortModel>), bool? isFlaky = default(bool?), string externalKey = default(string))
        {
            this.GlobalId = globalId;
            this.IsDeleted = isDeleted;
            this.MustBeApproved = mustBeApproved;
            this.Id = id;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for AutoTestModel and cannot be null");
            }
            this.ExternalId = externalId;
            this.ProjectId = projectId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutoTestModel and cannot be null");
            }
            this.Name = name;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.LastTestRunId = lastTestRunId;
            this.LastTestRunName = lastTestRunName;
            this.LastTestResultId = lastTestResultId;
            this.LastTestResultOutcome = lastTestResultOutcome;
            this.StabilityPercentage = stabilityPercentage;
            this.Links = links;
            this.Namespace = _namespace;
            this.Classname = classname;
            this.Steps = steps;
            this.Setup = setup;
            this.Teardown = teardown;
            this.Title = title;
            this.Description = description;
            this.Labels = labels;
            this.IsFlaky = isFlaky;
            this.ExternalKey = externalKey;
        }

        /// <summary>
        /// Global ID of the autotest
        /// </summary>
        /// <value>Global ID of the autotest</value>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Indicates if the autotest is deleted
        /// </summary>
        /// <value>Indicates if the autotest is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Indicates if the autotest has unapproved changes from linked work items
        /// </summary>
        /// <value>Indicates if the autotest has unapproved changes from linked work items</value>
        [DataMember(Name = "mustBeApproved", IsRequired = true, EmitDefaultValue = true)]
        public bool MustBeApproved { get; set; }

        /// <summary>
        /// Unique ID of the autotest
        /// </summary>
        /// <value>Unique ID of the autotest</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Creation date of the autotest
        /// </summary>
        /// <value>Creation date of the autotest</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last modification date of the project
        /// </summary>
        /// <value>Last modification date of the project</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Unique ID of the project creator
        /// </summary>
        /// <value>Unique ID of the project creator</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique ID of the project last editor
        /// </summary>
        /// <value>Unique ID of the project last editor</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Unique ID of the autotest last test run
        /// </summary>
        /// <value>Unique ID of the autotest last test run</value>
        [DataMember(Name = "lastTestRunId", EmitDefaultValue = true)]
        public Guid? LastTestRunId { get; set; }

        /// <summary>
        /// Name of the autotest last test run
        /// </summary>
        /// <value>Name of the autotest last test run</value>
        [DataMember(Name = "lastTestRunName", EmitDefaultValue = true)]
        public string LastTestRunName { get; set; }

        /// <summary>
        /// Unique ID of the autotest last test result
        /// </summary>
        /// <value>Unique ID of the autotest last test result</value>
        [DataMember(Name = "lastTestResultId", EmitDefaultValue = true)]
        public Guid? LastTestResultId { get; set; }

        /// <summary>
        /// Outcome of the autotest last test result
        /// </summary>
        /// <value>Outcome of the autotest last test result</value>
        [DataMember(Name = "lastTestResultOutcome", EmitDefaultValue = true)]
        public string LastTestResultOutcome { get; set; }

        /// <summary>
        /// Stability percentage of the autotest
        /// </summary>
        /// <value>Stability percentage of the autotest</value>
        [DataMember(Name = "stabilityPercentage", EmitDefaultValue = true)]
        public int? StabilityPercentage { get; set; }

        /// <summary>
        /// External ID of the autotest
        /// </summary>
        /// <value>External ID of the autotest</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Collection of the autotest links
        /// </summary>
        /// <value>Collection of the autotest links</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPutModel> Links { get; set; }

        /// <summary>
        /// Unique ID of the autotest project
        /// </summary>
        /// <value>Unique ID of the autotest project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Name of the autotest
        /// </summary>
        /// <value>Name of the autotest</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the autotest namespace
        /// </summary>
        /// <value>Name of the autotest namespace</value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Name of the autotest class
        /// </summary>
        /// <value>Name of the autotest class</value>
        [DataMember(Name = "classname", EmitDefaultValue = true)]
        public string Classname { get; set; }

        /// <summary>
        /// Collection of the autotest steps
        /// </summary>
        /// <value>Collection of the autotest steps</value>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Steps { get; set; }

        /// <summary>
        /// Collection of the autotest setup steps
        /// </summary>
        /// <value>Collection of the autotest setup steps</value>
        [DataMember(Name = "setup", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Setup { get; set; }

        /// <summary>
        /// Collection of the autotest teardown steps
        /// </summary>
        /// <value>Collection of the autotest teardown steps</value>
        [DataMember(Name = "teardown", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Teardown { get; set; }

        /// <summary>
        /// Name of the autotest in autotest&#39;s card
        /// </summary>
        /// <value>Name of the autotest in autotest&#39;s card</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Description of the autotest in autotest&#39;s card
        /// </summary>
        /// <value>Description of the autotest in autotest&#39;s card</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Collection of the autotest labels
        /// </summary>
        /// <value>Collection of the autotest labels</value>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<LabelShortModel> Labels { get; set; }

        /// <summary>
        /// Indicates if the autotest is marked as flaky
        /// </summary>
        /// <value>Indicates if the autotest is marked as flaky</value>
        [DataMember(Name = "isFlaky", EmitDefaultValue = true)]
        public bool? IsFlaky { get; set; }

        /// <summary>
        /// External key of the autotest
        /// </summary>
        /// <value>External key of the autotest</value>
        [DataMember(Name = "externalKey", EmitDefaultValue = true)]
        public string ExternalKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestModel {\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  MustBeApproved: ").Append(MustBeApproved).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  LastTestRunId: ").Append(LastTestRunId).Append("\n");
            sb.Append("  LastTestRunName: ").Append(LastTestRunName).Append("\n");
            sb.Append("  LastTestResultId: ").Append(LastTestResultId).Append("\n");
            sb.Append("  LastTestResultOutcome: ").Append(LastTestResultOutcome).Append("\n");
            sb.Append("  StabilityPercentage: ").Append(StabilityPercentage).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Classname: ").Append(Classname).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Teardown: ").Append(Teardown).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
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
            return this.Equals(input as AutoTestModel);
        }

        /// <summary>
        /// Returns true if AutoTestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.MustBeApproved == input.MustBeApproved ||
                    this.MustBeApproved.Equals(input.MustBeApproved)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.LastTestRunId == input.LastTestRunId ||
                    (this.LastTestRunId != null &&
                    this.LastTestRunId.Equals(input.LastTestRunId))
                ) && 
                (
                    this.LastTestRunName == input.LastTestRunName ||
                    (this.LastTestRunName != null &&
                    this.LastTestRunName.Equals(input.LastTestRunName))
                ) && 
                (
                    this.LastTestResultId == input.LastTestResultId ||
                    (this.LastTestResultId != null &&
                    this.LastTestResultId.Equals(input.LastTestResultId))
                ) && 
                (
                    this.LastTestResultOutcome == input.LastTestResultOutcome ||
                    (this.LastTestResultOutcome != null &&
                    this.LastTestResultOutcome.Equals(input.LastTestResultOutcome))
                ) && 
                (
                    this.StabilityPercentage == input.StabilityPercentage ||
                    (this.StabilityPercentage != null &&
                    this.StabilityPercentage.Equals(input.StabilityPercentage))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Classname == input.Classname ||
                    (this.Classname != null &&
                    this.Classname.Equals(input.Classname))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.Setup == input.Setup ||
                    this.Setup != null &&
                    input.Setup != null &&
                    this.Setup.SequenceEqual(input.Setup)
                ) && 
                (
                    this.Teardown == input.Teardown ||
                    this.Teardown != null &&
                    input.Teardown != null &&
                    this.Teardown.SequenceEqual(input.Teardown)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.IsFlaky == input.IsFlaky ||
                    (this.IsFlaky != null &&
                    this.IsFlaky.Equals(input.IsFlaky))
                ) && 
                (
                    this.ExternalKey == input.ExternalKey ||
                    (this.ExternalKey != null &&
                    this.ExternalKey.Equals(input.ExternalKey))
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
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                hashCode = (hashCode * 59) + this.MustBeApproved.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.LastTestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestRunId.GetHashCode();
                }
                if (this.LastTestRunName != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestRunName.GetHashCode();
                }
                if (this.LastTestResultId != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultId.GetHashCode();
                }
                if (this.LastTestResultOutcome != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultOutcome.GetHashCode();
                }
                if (this.StabilityPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.StabilityPercentage.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.Classname != null)
                {
                    hashCode = (hashCode * 59) + this.Classname.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                if (this.Setup != null)
                {
                    hashCode = (hashCode * 59) + this.Setup.GetHashCode();
                }
                if (this.Teardown != null)
                {
                    hashCode = (hashCode * 59) + this.Teardown.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.IsFlaky != null)
                {
                    hashCode = (hashCode * 59) + this.IsFlaky.GetHashCode();
                }
                if (this.ExternalKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalKey.GetHashCode();
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
            // ExternalId (string) minLength
            if (this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
