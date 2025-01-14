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
    /// Statistics of the test run
    /// </summary>
    [DataContract(Name = "TestRunShortGetModel_statistics")]
    public partial class TestRunShortGetModelStatistics : IEquatable<TestRunShortGetModelStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortGetModelStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunShortGetModelStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortGetModelStatistics" /> class.
        /// </summary>
        /// <param name="statuses">statuses (required).</param>
        /// <param name="failureCategories">failureCategories (required).</param>
        public TestRunShortGetModelStatistics(TestResultsStatisticsGetModelStatuses statuses = default(TestResultsStatisticsGetModelStatuses), TestResultsStatisticsGetModelFailureCategories failureCategories = default(TestResultsStatisticsGetModelFailureCategories))
        {
            // to ensure "statuses" is required (not null)
            if (statuses == null)
            {
                throw new ArgumentNullException("statuses is a required property for TestRunShortGetModelStatistics and cannot be null");
            }
            this.Statuses = statuses;
            // to ensure "failureCategories" is required (not null)
            if (failureCategories == null)
            {
                throw new ArgumentNullException("failureCategories is a required property for TestRunShortGetModelStatistics and cannot be null");
            }
            this.FailureCategories = failureCategories;
        }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name = "statuses", IsRequired = true, EmitDefaultValue = true)]
        public TestResultsStatisticsGetModelStatuses Statuses { get; set; }

        /// <summary>
        /// Gets or Sets FailureCategories
        /// </summary>
        [DataMember(Name = "failureCategories", IsRequired = true, EmitDefaultValue = true)]
        public TestResultsStatisticsGetModelFailureCategories FailureCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunShortGetModelStatistics {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  FailureCategories: ").Append(FailureCategories).Append("\n");
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
            return this.Equals(input as TestRunShortGetModelStatistics);
        }

        /// <summary>
        /// Returns true if TestRunShortGetModelStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunShortGetModelStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunShortGetModelStatistics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Statuses == input.Statuses ||
                    (this.Statuses != null &&
                    this.Statuses.Equals(input.Statuses))
                ) && 
                (
                    this.FailureCategories == input.FailureCategories ||
                    (this.FailureCategories != null &&
                    this.FailureCategories.Equals(input.FailureCategories))
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
                if (this.Statuses != null)
                {
                    hashCode = (hashCode * 59) + this.Statuses.GetHashCode();
                }
                if (this.FailureCategories != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCategories.GetHashCode();
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
