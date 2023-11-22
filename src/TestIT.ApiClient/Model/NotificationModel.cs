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
    /// NotificationModel
    /// </summary>
    [DataContract(Name = "NotificationModel")]
    public partial class NotificationModel : IEquatable<NotificationModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [DataMember(Name = "notificationType", IsRequired = true, EmitDefaultValue = true)]
        public NotificationTypeModel NotificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="isRead">isRead (required).</param>
        /// <param name="entityId">entityId (required).</param>
        /// <param name="notificationType">notificationType (required).</param>
        /// <param name="projectGlobalId">projectGlobalId.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="testPlanGlobalId">testPlanGlobalId (required).</param>
        /// <param name="testPlanName">testPlanName (required).</param>
        /// <param name="workitemGlobalId">workitemGlobalId.</param>
        /// <param name="comment">comment (required).</param>
        /// <param name="workItemName">workItemName (required).</param>
        /// <param name="attributeName">attributeName.</param>
        /// <param name="createdById">createdById (required).</param>
        public NotificationModel(Guid id = default(Guid), DateTime? createdDate = default(DateTime?), bool isRead = default(bool), Guid entityId = default(Guid), NotificationTypeModel notificationType = default(NotificationTypeModel), long? projectGlobalId = default(long?), string projectName = default(string), long testPlanGlobalId = default(long), string testPlanName = default(string), long? workitemGlobalId = default(long?), string comment = default(string), string workItemName = default(string), string attributeName = default(string), Guid createdById = default(Guid))
        {
            this.Id = id;
            this.IsRead = isRead;
            this.EntityId = entityId;
            this.NotificationType = notificationType;
            this.TestPlanGlobalId = testPlanGlobalId;
            // to ensure "testPlanName" is required (not null)
            if (testPlanName == null)
            {
                throw new ArgumentNullException("testPlanName is a required property for NotificationModel and cannot be null");
            }
            this.TestPlanName = testPlanName;
            // to ensure "comment" is required (not null)
            if (comment == null)
            {
                throw new ArgumentNullException("comment is a required property for NotificationModel and cannot be null");
            }
            this.Comment = comment;
            // to ensure "workItemName" is required (not null)
            if (workItemName == null)
            {
                throw new ArgumentNullException("workItemName is a required property for NotificationModel and cannot be null");
            }
            this.WorkItemName = workItemName;
            this.CreatedById = createdById;
            this.CreatedDate = createdDate;
            this.ProjectGlobalId = projectGlobalId;
            this.ProjectName = projectName;
            this.WorkitemGlobalId = workitemGlobalId;
            this.AttributeName = attributeName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets IsRead
        /// </summary>
        [DataMember(Name = "isRead", IsRequired = true, EmitDefaultValue = true)]
        public bool IsRead { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", IsRequired = true, EmitDefaultValue = true)]
        public Guid EntityId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectGlobalId
        /// </summary>
        [DataMember(Name = "projectGlobalId", EmitDefaultValue = true)]
        public long? ProjectGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name = "projectName", EmitDefaultValue = true)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanGlobalId
        /// </summary>
        [DataMember(Name = "testPlanGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long TestPlanGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanName
        /// </summary>
        [DataMember(Name = "testPlanName", IsRequired = true, EmitDefaultValue = true)]
        public string TestPlanName { get; set; }

        /// <summary>
        /// Gets or Sets WorkitemGlobalId
        /// </summary>
        [DataMember(Name = "workitemGlobalId", EmitDefaultValue = true)]
        public long? WorkitemGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", IsRequired = true, EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemName
        /// </summary>
        [DataMember(Name = "workItemName", IsRequired = true, EmitDefaultValue = true)]
        public string WorkItemName { get; set; }

        /// <summary>
        /// Gets or Sets AttributeName
        /// </summary>
        [DataMember(Name = "attributeName", EmitDefaultValue = true)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  ProjectGlobalId: ").Append(ProjectGlobalId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  TestPlanGlobalId: ").Append(TestPlanGlobalId).Append("\n");
            sb.Append("  TestPlanName: ").Append(TestPlanName).Append("\n");
            sb.Append("  WorkitemGlobalId: ").Append(WorkitemGlobalId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  WorkItemName: ").Append(WorkItemName).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
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
            return this.Equals(input as NotificationModel);
        }

        /// <summary>
        /// Returns true if NotificationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationModel input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.IsRead == input.IsRead ||
                    this.IsRead.Equals(input.IsRead)
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.NotificationType == input.NotificationType ||
                    this.NotificationType.Equals(input.NotificationType)
                ) && 
                (
                    this.ProjectGlobalId == input.ProjectGlobalId ||
                    (this.ProjectGlobalId != null &&
                    this.ProjectGlobalId.Equals(input.ProjectGlobalId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.TestPlanGlobalId == input.TestPlanGlobalId ||
                    this.TestPlanGlobalId.Equals(input.TestPlanGlobalId)
                ) && 
                (
                    this.TestPlanName == input.TestPlanName ||
                    (this.TestPlanName != null &&
                    this.TestPlanName.Equals(input.TestPlanName))
                ) && 
                (
                    this.WorkitemGlobalId == input.WorkitemGlobalId ||
                    (this.WorkitemGlobalId != null &&
                    this.WorkitemGlobalId.Equals(input.WorkitemGlobalId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.WorkItemName == input.WorkItemName ||
                    (this.WorkItemName != null &&
                    this.WorkItemName.Equals(input.WorkItemName))
                ) && 
                (
                    this.AttributeName == input.AttributeName ||
                    (this.AttributeName != null &&
                    this.AttributeName.Equals(input.AttributeName))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
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
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRead.GetHashCode();
                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NotificationType.GetHashCode();
                if (this.ProjectGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectGlobalId.GetHashCode();
                }
                if (this.ProjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestPlanGlobalId.GetHashCode();
                if (this.TestPlanName != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanName.GetHashCode();
                }
                if (this.WorkitemGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkitemGlobalId.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.WorkItemName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemName.GetHashCode();
                }
                if (this.AttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeName.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
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
