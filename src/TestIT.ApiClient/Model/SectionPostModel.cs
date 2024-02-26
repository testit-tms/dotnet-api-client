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
    /// SectionPostModel
    /// </summary>
    [DataContract(Name = "SectionPostModel")]
    public partial class SectionPostModel : IEquatable<SectionPostModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionPostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionPostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionPostModel" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="preconditionSteps">preconditionSteps.</param>
        /// <param name="postconditionSteps">postconditionSteps.</param>
        /// <param name="attachments">attachments (required).</param>
        public SectionPostModel(string name = default(string), Guid projectId = default(Guid), Guid? parentId = default(Guid?), List<StepPostModel> preconditionSteps = default(List<StepPostModel>), List<StepPostModel> postconditionSteps = default(List<StepPostModel>), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SectionPostModel and cannot be null");
            }
            this.Name = name;
            this.ProjectId = projectId;
            // to ensure "attachments" is required (not null)
            if (attachments == null)
            {
                throw new ArgumentNullException("attachments is a required property for SectionPostModel and cannot be null");
            }
            this.Attachments = attachments;
            this.ParentId = parentId;
            this.PreconditionSteps = preconditionSteps;
            this.PostconditionSteps = postconditionSteps;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;11421721-181a-4696-aa8a-ec54c0d06fca&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        /// <example>&quot;11421721-181a-4696-aa8a-ec54c0d06fca&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        /// <example>&quot;11421721-181a-4696-aa8a-ec54c0d06fca&quot;</example>
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", EmitDefaultValue = true)]
        public List<StepPostModel> PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", EmitDefaultValue = true)]
        public List<StepPostModel> PostconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SectionPostModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as SectionPostModel);
        }

        /// <summary>
        /// Returns true if SectionPostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionPostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionPostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.PreconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PreconditionSteps.GetHashCode();
                }
                if (this.PostconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PostconditionSteps.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
