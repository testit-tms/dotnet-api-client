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
    /// ApiV2WorkItemsMovePostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_workItems_move_post_request")]
    public partial class ApiV2WorkItemsMovePostRequest : IEquatable<ApiV2WorkItemsMovePostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2WorkItemsMovePostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2WorkItemsMovePostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2WorkItemsMovePostRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="newSectionId">newSectionId (required).</param>
        /// <param name="oldSectionId">oldSectionId.</param>
        /// <param name="nextWorkItemId">nextWorkItemId.</param>
        public ApiV2WorkItemsMovePostRequest(Guid id = default(Guid), Guid newSectionId = default(Guid), Guid? oldSectionId = default(Guid?), Guid? nextWorkItemId = default(Guid?))
        {
            this.Id = id;
            this.NewSectionId = newSectionId;
            this.OldSectionId = oldSectionId;
            this.NextWorkItemId = nextWorkItemId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets NewSectionId
        /// </summary>
        [DataMember(Name = "newSectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid NewSectionId { get; set; }

        /// <summary>
        /// Gets or Sets OldSectionId
        /// </summary>
        [DataMember(Name = "oldSectionId", EmitDefaultValue = true)]
        public Guid? OldSectionId { get; set; }

        /// <summary>
        /// Gets or Sets NextWorkItemId
        /// </summary>
        [DataMember(Name = "nextWorkItemId", EmitDefaultValue = true)]
        public Guid? NextWorkItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2WorkItemsMovePostRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NewSectionId: ").Append(NewSectionId).Append("\n");
            sb.Append("  OldSectionId: ").Append(OldSectionId).Append("\n");
            sb.Append("  NextWorkItemId: ").Append(NextWorkItemId).Append("\n");
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
            return this.Equals(input as ApiV2WorkItemsMovePostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2WorkItemsMovePostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2WorkItemsMovePostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2WorkItemsMovePostRequest input)
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
                    this.NewSectionId == input.NewSectionId ||
                    (this.NewSectionId != null &&
                    this.NewSectionId.Equals(input.NewSectionId))
                ) && 
                (
                    this.OldSectionId == input.OldSectionId ||
                    (this.OldSectionId != null &&
                    this.OldSectionId.Equals(input.OldSectionId))
                ) && 
                (
                    this.NextWorkItemId == input.NextWorkItemId ||
                    (this.NextWorkItemId != null &&
                    this.NextWorkItemId.Equals(input.NextWorkItemId))
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
                if (this.NewSectionId != null)
                {
                    hashCode = (hashCode * 59) + this.NewSectionId.GetHashCode();
                }
                if (this.OldSectionId != null)
                {
                    hashCode = (hashCode * 59) + this.OldSectionId.GetHashCode();
                }
                if (this.NextWorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.NextWorkItemId.GetHashCode();
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
