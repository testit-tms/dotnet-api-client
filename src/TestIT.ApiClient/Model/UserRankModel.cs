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
    /// UserRankModel
    /// </summary>
    [DataContract(Name = "UserRankModel")]
    public partial class UserRankModel : IEquatable<UserRankModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRankModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserRankModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRankModel" /> class.
        /// </summary>
        /// <param name="score">score (required).</param>
        /// <param name="workItemsCreated">workItemsCreated (required).</param>
        /// <param name="passedTestPoints">passedTestPoints (required).</param>
        /// <param name="failedTestPoints">failedTestPoints (required).</param>
        /// <param name="skippedTestPoints">skippedTestPoints (required).</param>
        /// <param name="blockedTestPoints">blockedTestPoints (required).</param>
        public UserRankModel(int score = default(int), int workItemsCreated = default(int), int passedTestPoints = default(int), int failedTestPoints = default(int), int skippedTestPoints = default(int), int blockedTestPoints = default(int))
        {
            this.Score = score;
            this.WorkItemsCreated = workItemsCreated;
            this.PassedTestPoints = passedTestPoints;
            this.FailedTestPoints = failedTestPoints;
            this.SkippedTestPoints = skippedTestPoints;
            this.BlockedTestPoints = blockedTestPoints;
        }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public int Score { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemsCreated
        /// </summary>
        [DataMember(Name = "workItemsCreated", IsRequired = true, EmitDefaultValue = true)]
        public int WorkItemsCreated { get; set; }

        /// <summary>
        /// Gets or Sets PassedTestPoints
        /// </summary>
        [DataMember(Name = "passedTestPoints", IsRequired = true, EmitDefaultValue = true)]
        public int PassedTestPoints { get; set; }

        /// <summary>
        /// Gets or Sets FailedTestPoints
        /// </summary>
        [DataMember(Name = "failedTestPoints", IsRequired = true, EmitDefaultValue = true)]
        public int FailedTestPoints { get; set; }

        /// <summary>
        /// Gets or Sets SkippedTestPoints
        /// </summary>
        [DataMember(Name = "skippedTestPoints", IsRequired = true, EmitDefaultValue = true)]
        public int SkippedTestPoints { get; set; }

        /// <summary>
        /// Gets or Sets BlockedTestPoints
        /// </summary>
        [DataMember(Name = "blockedTestPoints", IsRequired = true, EmitDefaultValue = true)]
        public int BlockedTestPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserRankModel {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  WorkItemsCreated: ").Append(WorkItemsCreated).Append("\n");
            sb.Append("  PassedTestPoints: ").Append(PassedTestPoints).Append("\n");
            sb.Append("  FailedTestPoints: ").Append(FailedTestPoints).Append("\n");
            sb.Append("  SkippedTestPoints: ").Append(SkippedTestPoints).Append("\n");
            sb.Append("  BlockedTestPoints: ").Append(BlockedTestPoints).Append("\n");
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
            return this.Equals(input as UserRankModel);
        }

        /// <summary>
        /// Returns true if UserRankModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRankModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRankModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.WorkItemsCreated == input.WorkItemsCreated ||
                    this.WorkItemsCreated.Equals(input.WorkItemsCreated)
                ) && 
                (
                    this.PassedTestPoints == input.PassedTestPoints ||
                    this.PassedTestPoints.Equals(input.PassedTestPoints)
                ) && 
                (
                    this.FailedTestPoints == input.FailedTestPoints ||
                    this.FailedTestPoints.Equals(input.FailedTestPoints)
                ) && 
                (
                    this.SkippedTestPoints == input.SkippedTestPoints ||
                    this.SkippedTestPoints.Equals(input.SkippedTestPoints)
                ) && 
                (
                    this.BlockedTestPoints == input.BlockedTestPoints ||
                    this.BlockedTestPoints.Equals(input.BlockedTestPoints)
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
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkItemsCreated.GetHashCode();
                hashCode = (hashCode * 59) + this.PassedTestPoints.GetHashCode();
                hashCode = (hashCode * 59) + this.FailedTestPoints.GetHashCode();
                hashCode = (hashCode * 59) + this.SkippedTestPoints.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockedTestPoints.GetHashCode();
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
