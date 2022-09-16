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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// WebHookLogModel
    /// </summary>
    [DataContract(Name = "WebHookLogModel")]
    public partial class WebHookLogModel : IEquatable<WebHookLogModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public WebHookEventTypeModel? EventType { get; set; }

        /// <summary>
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "requestType", EmitDefaultValue = false)]
        public RequestTypeModel? RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookLogModel" /> class.
        /// </summary>
        /// <param name="webHookName">webHookName.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="webHookId">webHookId.</param>
        /// <param name="requestBody">requestBody.</param>
        /// <param name="requestMeta">requestMeta.</param>
        /// <param name="responseStatusCode">responseStatusCode.</param>
        /// <param name="responseBody">responseBody.</param>
        /// <param name="responseMeta">responseMeta.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="url">url.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById.</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted.</param>
        public WebHookLogModel(string webHookName = default(string), WebHookEventTypeModel? eventType = default(WebHookEventTypeModel?), Guid webHookId = default(Guid), string requestBody = default(string), string requestMeta = default(string), int responseStatusCode = default(int), string responseBody = default(string), string responseMeta = default(string), Guid projectId = default(Guid), string url = default(string), RequestTypeModel? requestType = default(RequestTypeModel?), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.WebHookName = webHookName;
            this.EventType = eventType;
            this.WebHookId = webHookId;
            this.RequestBody = requestBody;
            this.RequestMeta = requestMeta;
            this.ResponseStatusCode = responseStatusCode;
            this.ResponseBody = responseBody;
            this.ResponseMeta = responseMeta;
            this.ProjectId = projectId;
            this.Url = url;
            this.RequestType = requestType;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.CreatedById = createdById;
            this.ModifiedById = modifiedById;
            this.Id = id;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Gets or Sets WebHookName
        /// </summary>
        [DataMember(Name = "webHookName", EmitDefaultValue = true)]
        public string WebHookName { get; set; }

        /// <summary>
        /// Gets or Sets WebHookId
        /// </summary>
        [DataMember(Name = "webHookId", EmitDefaultValue = false)]
        public Guid WebHookId { get; set; }

        /// <summary>
        /// Gets or Sets RequestBody
        /// </summary>
        [DataMember(Name = "requestBody", EmitDefaultValue = true)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Gets or Sets RequestMeta
        /// </summary>
        [DataMember(Name = "requestMeta", EmitDefaultValue = true)]
        public string RequestMeta { get; set; }

        /// <summary>
        /// Gets or Sets ResponseStatusCode
        /// </summary>
        [DataMember(Name = "responseStatusCode", EmitDefaultValue = false)]
        public int ResponseStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets ResponseBody
        /// </summary>
        [DataMember(Name = "responseBody", EmitDefaultValue = true)]
        public string ResponseBody { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMeta
        /// </summary>
        [DataMember(Name = "responseMeta", EmitDefaultValue = true)]
        public string ResponseMeta { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", EmitDefaultValue = false)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHookLogModel {\n");
            sb.Append("  WebHookName: ").Append(WebHookName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  WebHookId: ").Append(WebHookId).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  RequestMeta: ").Append(RequestMeta).Append("\n");
            sb.Append("  ResponseStatusCode: ").Append(ResponseStatusCode).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  ResponseMeta: ").Append(ResponseMeta).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
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
            return this.Equals(input as WebHookLogModel);
        }

        /// <summary>
        /// Returns true if WebHookLogModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookLogModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookLogModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebHookName == input.WebHookName ||
                    (this.WebHookName != null &&
                    this.WebHookName.Equals(input.WebHookName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.WebHookId == input.WebHookId ||
                    (this.WebHookId != null &&
                    this.WebHookId.Equals(input.WebHookId))
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.RequestMeta == input.RequestMeta ||
                    (this.RequestMeta != null &&
                    this.RequestMeta.Equals(input.RequestMeta))
                ) && 
                (
                    this.ResponseStatusCode == input.ResponseStatusCode ||
                    this.ResponseStatusCode.Equals(input.ResponseStatusCode)
                ) && 
                (
                    this.ResponseBody == input.ResponseBody ||
                    (this.ResponseBody != null &&
                    this.ResponseBody.Equals(input.ResponseBody))
                ) && 
                (
                    this.ResponseMeta == input.ResponseMeta ||
                    (this.ResponseMeta != null &&
                    this.ResponseMeta.Equals(input.ResponseMeta))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
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
                if (this.WebHookName != null)
                {
                    hashCode = (hashCode * 59) + this.WebHookName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                if (this.WebHookId != null)
                {
                    hashCode = (hashCode * 59) + this.WebHookId.GetHashCode();
                }
                if (this.RequestBody != null)
                {
                    hashCode = (hashCode * 59) + this.RequestBody.GetHashCode();
                }
                if (this.RequestMeta != null)
                {
                    hashCode = (hashCode * 59) + this.RequestMeta.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResponseStatusCode.GetHashCode();
                if (this.ResponseBody != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseBody.GetHashCode();
                }
                if (this.ResponseMeta != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMeta.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
