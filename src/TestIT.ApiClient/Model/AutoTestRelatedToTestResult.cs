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
    /// AutoTestRelatedToTestResult
    /// </summary>
    [DataContract(Name = "auto_test_related_to_test_result")]
    public partial class AutoTestRelatedToTestResult : IEquatable<AutoTestRelatedToTestResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestRelatedToTestResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestRelatedToTestResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestRelatedToTestResult" /> class.
        /// </summary>
        /// <param name="externalId">This property is used to set autotest identifier from client system.</param>
        /// <param name="links">links.</param>
        /// <param name="projectId">This property is used to link autotest with project (required).</param>
        /// <param name="name">name.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="classname">classname.</param>
        /// <param name="steps">steps.</param>
        /// <param name="setup">setup.</param>
        /// <param name="teardown">teardown.</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="labels">labels.</param>
        /// <param name="id">Unique ID of the entity (required).</param>
        /// <param name="isDeleted">Indicates if the entity is deleted (required).</param>
        public AutoTestRelatedToTestResult(string externalId = default(string), List<LinkModel> links = default(List<LinkModel>), Guid projectId = default(Guid), string name = default(string), string _namespace = default(string), string classname = default(string), List<AutoTestStepModel> steps = default(List<AutoTestStepModel>), List<AutoTestStepModel> setup = default(List<AutoTestStepModel>), List<AutoTestStepModel> teardown = default(List<AutoTestStepModel>), long globalId = default(long), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), List<LabelShortModel> labels = default(List<LabelShortModel>), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.ProjectId = projectId;
            this.GlobalId = globalId;
            this.CreatedById = createdById;
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.ExternalId = externalId;
            this.Links = links;
            this.Name = name;
            this.Namespace = _namespace;
            this.Classname = classname;
            this.Steps = steps;
            this.Setup = setup;
            this.Teardown = teardown;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.Labels = labels;
        }

        /// <summary>
        /// This property is used to set autotest identifier from client system
        /// </summary>
        /// <value>This property is used to set autotest identifier from client system</value>
        /// <example>&quot;10001&quot;</example>
        [DataMember(Name = "externalId", EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// This property is used to link autotest with project
        /// </summary>
        /// <value>This property is used to link autotest with project</value>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;WorkItem valid creation test&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        /// <example>&quot;UnitTest.Core&quot;</example>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Classname
        /// </summary>
        /// <example>&quot;WorkItemServiceTest.cs&quot;</example>
        [DataMember(Name = "classname", EmitDefaultValue = true)]
        public string Classname { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name = "setup", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Setup { get; set; }

        /// <summary>
        /// Gets or Sets Teardown
        /// </summary>
        [DataMember(Name = "teardown", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Teardown { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        /// <example>&quot;2023-09-05T14:27:24.282190200Z&quot;</example>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        /// <example>&quot;2023-09-05T14:27:24.282190200Z&quot;</example>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<LabelShortModel> Labels { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestRelatedToTestResult {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Classname: ").Append(Classname).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Teardown: ").Append(Teardown).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as AutoTestRelatedToTestResult);
        }

        /// <summary>
        /// Returns true if AutoTestRelatedToTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestRelatedToTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestRelatedToTestResult input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
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
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
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
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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