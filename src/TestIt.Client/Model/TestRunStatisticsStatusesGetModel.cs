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
    /// TestRunStatisticsStatusesGetModel
    /// </summary>
    [DataContract(Name = "TestRunStatisticsStatusesGetModel")]
    public partial class TestRunStatisticsStatusesGetModel : IEquatable<TestRunStatisticsStatusesGetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunStatisticsStatusesGetModel" /> class.
        /// </summary>
        /// <param name="inProgress">inProgress.</param>
        /// <param name="passed">passed.</param>
        /// <param name="failed">failed.</param>
        /// <param name="skipped">skipped.</param>
        /// <param name="blocked">blocked.</param>
        public TestRunStatisticsStatusesGetModel(int inProgress = default(int), int passed = default(int), int failed = default(int), int skipped = default(int), int blocked = default(int))
        {
            this.InProgress = inProgress;
            this.Passed = passed;
            this.Failed = failed;
            this.Skipped = skipped;
            this.Blocked = blocked;
        }

        /// <summary>
        /// Gets or Sets InProgress
        /// </summary>
        [DataMember(Name = "inProgress", EmitDefaultValue = false)]
        public int InProgress { get; set; }

        /// <summary>
        /// Gets or Sets Passed
        /// </summary>
        [DataMember(Name = "passed", EmitDefaultValue = false)]
        public int Passed { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        public int Failed { get; set; }

        /// <summary>
        /// Gets or Sets Skipped
        /// </summary>
        [DataMember(Name = "skipped", EmitDefaultValue = false)]
        public int Skipped { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name = "blocked", EmitDefaultValue = false)]
        public int Blocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunStatisticsStatusesGetModel {\n");
            sb.Append("  InProgress: ").Append(InProgress).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
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
            return this.Equals(input as TestRunStatisticsStatusesGetModel);
        }

        /// <summary>
        /// Returns true if TestRunStatisticsStatusesGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunStatisticsStatusesGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunStatisticsStatusesGetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InProgress == input.InProgress ||
                    this.InProgress.Equals(input.InProgress)
                ) && 
                (
                    this.Passed == input.Passed ||
                    this.Passed.Equals(input.Passed)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    this.Skipped.Equals(input.Skipped)
                ) && 
                (
                    this.Blocked == input.Blocked ||
                    this.Blocked.Equals(input.Blocked)
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
                hashCode = (hashCode * 59) + this.InProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.Passed.GetHashCode();
                hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                hashCode = (hashCode * 59) + this.Skipped.GetHashCode();
                hashCode = (hashCode * 59) + this.Blocked.GetHashCode();
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
