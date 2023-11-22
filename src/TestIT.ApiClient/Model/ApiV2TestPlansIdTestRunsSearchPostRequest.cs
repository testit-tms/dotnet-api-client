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
    /// ApiV2TestPlansIdTestRunsSearchPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testPlans__id__testRuns_search_post_request")]
    public partial class ApiV2TestPlansIdTestRunsSearchPostRequest : IEquatable<ApiV2TestPlansIdTestRunsSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestPlansIdTestRunsSearchPostRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="states">states.</param>
        /// <param name="startedDate">startedDate.</param>
        /// <param name="completedDate">completedDate.</param>
        /// <param name="createdByIds">createdByIds.</param>
        /// <param name="modifiedByIds">modifiedByIds.</param>
        public ApiV2TestPlansIdTestRunsSearchPostRequest(string name = default(string), List<TestRunState> states = default(List<TestRunState>), DateTimeRangeSelectorModel startedDate = default(DateTimeRangeSelectorModel), DateTimeRangeSelectorModel completedDate = default(DateTimeRangeSelectorModel), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>))
        {
            this.Name = name;
            this.States = states;
            this.StartedDate = startedDate;
            this.CompletedDate = completedDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<TestRunState> States { get; set; }

        /// <summary>
        /// Gets or Sets StartedDate
        /// </summary>
        [DataMember(Name = "startedDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel StartedDate { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name = "completedDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel CompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByIds
        /// </summary>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByIds
        /// </summary>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestPlansIdTestRunsSearchPostRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
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
            return this.Equals(input as ApiV2TestPlansIdTestRunsSearchPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestPlansIdTestRunsSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestPlansIdTestRunsSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestPlansIdTestRunsSearchPostRequest input)
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
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.StartedDate == input.StartedDate ||
                    (this.StartedDate != null &&
                    this.StartedDate.Equals(input.StartedDate))
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
                ) && 
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) && 
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
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
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.StartedDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartedDate.GetHashCode();
                }
                if (this.CompletedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
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
