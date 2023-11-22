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
    /// LastTestResultModel
    /// </summary>
    [DataContract(Name = "LastTestResultModel")]
    public partial class LastTestResultModel : IEquatable<LastTestResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastTestResultModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LastTestResultModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LastTestResultModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="testRunId">testRunId (required).</param>
        /// <param name="autoTestId">autoTestId.</param>
        /// <param name="comment">comment.</param>
        /// <param name="links">links.</param>
        /// <param name="workItemVersionId">workItemVersionId (required).</param>
        /// <param name="attachments">attachments.</param>
        public LastTestResultModel(Guid id = default(Guid), Guid testRunId = default(Guid), Guid? autoTestId = default(Guid?), string comment = default(string), List<LinkModel> links = default(List<LinkModel>), Guid workItemVersionId = default(Guid), List<AttachmentModel> attachments = default(List<AttachmentModel>))
        {
            this.Id = id;
            this.TestRunId = testRunId;
            this.WorkItemVersionId = workItemVersionId;
            this.AutoTestId = autoTestId;
            this.Comment = comment;
            this.Links = links;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestId
        /// </summary>
        [DataMember(Name = "autoTestId", EmitDefaultValue = true)]
        public Guid? AutoTestId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionId
        /// </summary>
        [DataMember(Name = "workItemVersionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemVersionId { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LastTestResultModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  AutoTestId: ").Append(AutoTestId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  WorkItemVersionId: ").Append(WorkItemVersionId).Append("\n");
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
            return this.Equals(input as LastTestResultModel);
        }

        /// <summary>
        /// Returns true if LastTestResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of LastTestResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastTestResultModel input)
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
                    this.TestRunId == input.TestRunId ||
                    (this.TestRunId != null &&
                    this.TestRunId.Equals(input.TestRunId))
                ) && 
                (
                    this.AutoTestId == input.AutoTestId ||
                    (this.AutoTestId != null &&
                    this.AutoTestId.Equals(input.AutoTestId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.WorkItemVersionId == input.WorkItemVersionId ||
                    (this.WorkItemVersionId != null &&
                    this.WorkItemVersionId.Equals(input.WorkItemVersionId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunId.GetHashCode();
                }
                if (this.AutoTestId != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestId.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.WorkItemVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemVersionId.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
