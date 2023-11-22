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
    /// CreateWorkItemRequest
    /// </summary>
    [DataContract(Name = "CreateWorkItem_request")]
    public partial class CreateWorkItemRequest : IEquatable<CreateWorkItemRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntityTypeName
        /// </summary>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemEntityTypes EntityTypeName { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateWorkItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWorkItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkItemRequest" /> class.
        /// </summary>
        /// <param name="entityTypeName">entityTypeName (required).</param>
        /// <param name="description">description.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="steps">steps (required).</param>
        /// <param name="preconditionSteps">preconditionSteps (required).</param>
        /// <param name="postconditionSteps">postconditionSteps (required).</param>
        /// <param name="duration">Must be 0 for shared steps and greater than 0 for the other types of work items (required).</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="iterations">iterations.</param>
        /// <param name="links">links (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="projectId">This property is used to link workitem with project (required).</param>
        /// <param name="sectionId">sectionId (required).</param>
        /// <param name="autoTests">autoTests.</param>
        public CreateWorkItemRequest(WorkItemEntityTypes entityTypeName = default(WorkItemEntityTypes), string description = default(string), WorkItemStates state = default(WorkItemStates), WorkItemPriorityModel priority = default(WorkItemPriorityModel), List<StepPutModel> steps = default(List<StepPutModel>), List<StepPutModel> preconditionSteps = default(List<StepPutModel>), List<StepPutModel> postconditionSteps = default(List<StepPutModel>), int duration = default(int), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<TagShortModel> tags = default(List<TagShortModel>), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), List<IterationPutModel> iterations = default(List<IterationPutModel>), List<LinkPostModel> links = default(List<LinkPostModel>), string name = default(string), Guid projectId = default(Guid), Guid sectionId = default(Guid), List<AutoTestIdModel> autoTests = default(List<AutoTestIdModel>))
        {
            this.EntityTypeName = entityTypeName;
            this.State = state;
            this.Priority = priority;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.Steps = steps;
            // to ensure "preconditionSteps" is required (not null)
            if (preconditionSteps == null)
            {
                throw new ArgumentNullException("preconditionSteps is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.PreconditionSteps = preconditionSteps;
            // to ensure "postconditionSteps" is required (not null)
            if (postconditionSteps == null)
            {
                throw new ArgumentNullException("postconditionSteps is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.PostconditionSteps = postconditionSteps;
            this.Duration = duration;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.Tags = tags;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.Links = links;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateWorkItemRequest and cannot be null");
            }
            this.Name = name;
            this.ProjectId = projectId;
            this.SectionId = sectionId;
            this.Description = description;
            this.Attachments = attachments;
            this.Iterations = iterations;
            this.AutoTests = autoTests;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>&quot;This is a basic test template&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> PostconditionSteps { get; set; }

        /// <summary>
        /// Must be 0 for shared steps and greater than 0 for the other types of work items
        /// </summary>
        /// <value>Must be 0 for shared steps and greater than 0 for the other types of work items</value>
        /// <example>10000</example>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<TagShortModel> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Iterations
        /// </summary>
        [DataMember(Name = "iterations", EmitDefaultValue = true)]
        public List<IterationPutModel> Iterations { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkPostModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Basic template&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// This property is used to link workitem with project
        /// </summary>
        /// <value>This property is used to link workitem with project</value>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets AutoTests
        /// </summary>
        [DataMember(Name = "autoTests", EmitDefaultValue = true)]
        public List<AutoTestIdModel> AutoTests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWorkItemRequest {\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  AutoTests: ").Append(AutoTests).Append("\n");
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
            return this.Equals(input as CreateWorkItemRequest);
        }

        /// <summary>
        /// Returns true if CreateWorkItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWorkItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWorkItemRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityTypeName == input.EntityTypeName ||
                    this.EntityTypeName.Equals(input.EntityTypeName)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.PreconditionSteps == input.PreconditionSteps ||
                    this.PreconditionSteps != null &&
                    input.PreconditionSteps != null &&
                    this.PreconditionSteps.SequenceEqual(input.PreconditionSteps)
                ) && 
                (
                    this.PostconditionSteps == input.PostconditionSteps ||
                    this.PostconditionSteps != null &&
                    input.PostconditionSteps != null &&
                    this.PostconditionSteps.SequenceEqual(input.PostconditionSteps)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.AutoTests == input.AutoTests ||
                    this.AutoTests != null &&
                    input.AutoTests != null &&
                    this.AutoTests.SequenceEqual(input.AutoTests)
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
                hashCode = (hashCode * 59) + this.EntityTypeName.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                if (this.PreconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PreconditionSteps.GetHashCode();
                }
                if (this.PostconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PostconditionSteps.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Iterations != null)
                {
                    hashCode = (hashCode * 59) + this.Iterations.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.AutoTests != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTests.GetHashCode();
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
            // Duration (int) maximum
            if (this.Duration > (int)86400000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value less than or equal to 86400000.", new [] { "Duration" });
            }

            // Duration (int) minimum
            if (this.Duration < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
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
