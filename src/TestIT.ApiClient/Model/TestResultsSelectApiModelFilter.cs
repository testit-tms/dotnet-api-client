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
    /// Test result filters
    /// </summary>
    [DataContract(Name = "TestResultsSelectApiModel_filter")]
    public partial class TestResultsSelectApiModelFilter : IEquatable<TestResultsSelectApiModelFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsSelectApiModelFilter" /> class.
        /// </summary>
        /// <param name="configurationIds">Specifies a test result configuration IDs to search for.</param>
        /// <param name="outcomes">Specifies a test result outcomes to search for.</param>
        /// <param name="statusCodes">Specifies a test result status codes to search for.</param>
        /// <param name="failureCategories">Specifies a test result failure categories to search for.</param>
        /// <param name="_namespace">Specifies a test result namespace to search for.</param>
        /// <param name="className">Specifies a test result class name to search for.</param>
        /// <param name="autoTestGlobalIds">Specifies an autotest global IDs to search results for.</param>
        /// <param name="name">Specifies an autotest name to search results for.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="duration">duration.</param>
        /// <param name="resultReasons">Specifies result reasons for searching test results.</param>
        /// <param name="testRunIds">Specifies a test result test run IDs to search for.</param>
        public TestResultsSelectApiModelFilter(List<Guid> configurationIds = default(List<Guid>), List<TestResultOutcome> outcomes = default(List<TestResultOutcome>), List<string> statusCodes = default(List<string>), List<FailureCategoryModel> failureCategories = default(List<FailureCategoryModel>), string _namespace = default(string), string className = default(string), List<long> autoTestGlobalIds = default(List<long>), string name = default(string), TestResultsFilterRequestCreatedDate createdDate = default(TestResultsFilterRequestCreatedDate), TestResultsFilterRequestModifiedDate modifiedDate = default(TestResultsFilterRequestModifiedDate), TestResultsFilterRequestStartedOn startedOn = default(TestResultsFilterRequestStartedOn), TestResultsFilterRequestCompletedOn completedOn = default(TestResultsFilterRequestCompletedOn), TestResultsFilterRequestDuration duration = default(TestResultsFilterRequestDuration), List<string> resultReasons = default(List<string>), List<Guid> testRunIds = default(List<Guid>))
        {
            this.ConfigurationIds = configurationIds;
            this.Outcomes = outcomes;
            this.StatusCodes = statusCodes;
            this.FailureCategories = failureCategories;
            this.Namespace = _namespace;
            this.ClassName = className;
            this.AutoTestGlobalIds = autoTestGlobalIds;
            this.Name = name;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.Duration = duration;
            this.ResultReasons = resultReasons;
            this.TestRunIds = testRunIds;
        }

        /// <summary>
        /// Specifies a test result configuration IDs to search for
        /// </summary>
        /// <value>Specifies a test result configuration IDs to search for</value>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Specifies a test result outcomes to search for
        /// </summary>
        /// <value>Specifies a test result outcomes to search for</value>
        [DataMember(Name = "outcomes", EmitDefaultValue = true)]
        [Obsolete]
        public List<TestResultOutcome> Outcomes { get; set; }

        /// <summary>
        /// Specifies a test result status codes to search for
        /// </summary>
        /// <value>Specifies a test result status codes to search for</value>
        [DataMember(Name = "statusCodes", EmitDefaultValue = true)]
        public List<string> StatusCodes { get; set; }

        /// <summary>
        /// Specifies a test result failure categories to search for
        /// </summary>
        /// <value>Specifies a test result failure categories to search for</value>
        [DataMember(Name = "failureCategories", EmitDefaultValue = true)]
        public List<FailureCategoryModel> FailureCategories { get; set; }

        /// <summary>
        /// Specifies a test result namespace to search for
        /// </summary>
        /// <value>Specifies a test result namespace to search for</value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies a test result class name to search for
        /// </summary>
        /// <value>Specifies a test result class name to search for</value>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Specifies an autotest global IDs to search results for
        /// </summary>
        /// <value>Specifies an autotest global IDs to search results for</value>
        [DataMember(Name = "autoTestGlobalIds", EmitDefaultValue = true)]
        public List<long> AutoTestGlobalIds { get; set; }

        /// <summary>
        /// Specifies an autotest name to search results for
        /// </summary>
        /// <value>Specifies an autotest name to search results for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public TestResultsFilterRequestCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public TestResultsFilterRequestModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public TestResultsFilterRequestStartedOn StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public TestResultsFilterRequestCompletedOn CompletedOn { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public TestResultsFilterRequestDuration Duration { get; set; }

        /// <summary>
        /// Specifies result reasons for searching test results
        /// </summary>
        /// <value>Specifies result reasons for searching test results</value>
        [DataMember(Name = "resultReasons", EmitDefaultValue = true)]
        public List<string> ResultReasons { get; set; }

        /// <summary>
        /// Specifies a test result test run IDs to search for
        /// </summary>
        /// <value>Specifies a test result test run IDs to search for</value>
        [DataMember(Name = "testRunIds", EmitDefaultValue = true)]
        public List<Guid> TestRunIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultsSelectApiModelFilter {\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
            sb.Append("  StatusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  FailureCategories: ").Append(FailureCategories).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  AutoTestGlobalIds: ").Append(AutoTestGlobalIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ResultReasons: ").Append(ResultReasons).Append("\n");
            sb.Append("  TestRunIds: ").Append(TestRunIds).Append("\n");
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
            return this.Equals(input as TestResultsSelectApiModelFilter);
        }

        /// <summary>
        /// Returns true if TestResultsSelectApiModelFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultsSelectApiModelFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultsSelectApiModelFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationIds == input.ConfigurationIds ||
                    this.ConfigurationIds != null &&
                    input.ConfigurationIds != null &&
                    this.ConfigurationIds.SequenceEqual(input.ConfigurationIds)
                ) && 
                (
                    this.Outcomes == input.Outcomes ||
                    this.Outcomes != null &&
                    input.Outcomes != null &&
                    this.Outcomes.SequenceEqual(input.Outcomes)
                ) && 
                (
                    this.StatusCodes == input.StatusCodes ||
                    this.StatusCodes != null &&
                    input.StatusCodes != null &&
                    this.StatusCodes.SequenceEqual(input.StatusCodes)
                ) && 
                (
                    this.FailureCategories == input.FailureCategories ||
                    this.FailureCategories != null &&
                    input.FailureCategories != null &&
                    this.FailureCategories.SequenceEqual(input.FailureCategories)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.AutoTestGlobalIds == input.AutoTestGlobalIds ||
                    this.AutoTestGlobalIds != null &&
                    input.AutoTestGlobalIds != null &&
                    this.AutoTestGlobalIds.SequenceEqual(input.AutoTestGlobalIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.CompletedOn == input.CompletedOn ||
                    (this.CompletedOn != null &&
                    this.CompletedOn.Equals(input.CompletedOn))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ResultReasons == input.ResultReasons ||
                    this.ResultReasons != null &&
                    input.ResultReasons != null &&
                    this.ResultReasons.SequenceEqual(input.ResultReasons)
                ) && 
                (
                    this.TestRunIds == input.TestRunIds ||
                    this.TestRunIds != null &&
                    input.TestRunIds != null &&
                    this.TestRunIds.SequenceEqual(input.TestRunIds)
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
                if (this.ConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationIds.GetHashCode();
                }
                if (this.Outcomes != null)
                {
                    hashCode = (hashCode * 59) + this.Outcomes.GetHashCode();
                }
                if (this.StatusCodes != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCodes.GetHashCode();
                }
                if (this.FailureCategories != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCategories.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                if (this.AutoTestGlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestGlobalIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.StartedOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartedOn.GetHashCode();
                }
                if (this.CompletedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedOn.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.ResultReasons != null)
                {
                    hashCode = (hashCode * 59) + this.ResultReasons.GetHashCode();
                }
                if (this.TestRunIds != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunIds.GetHashCode();
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
            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Namespace (string) minLength
            if (this.Namespace != null && this.Namespace.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be greater than 0.", new [] { "Namespace" });
            }

            // ClassName (string) maxLength
            if (this.ClassName != null && this.ClassName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassName, length must be less than 255.", new [] { "ClassName" });
            }

            // ClassName (string) minLength
            if (this.ClassName != null && this.ClassName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassName, length must be greater than 0.", new [] { "ClassName" });
            }

            yield break;
        }
    }

}