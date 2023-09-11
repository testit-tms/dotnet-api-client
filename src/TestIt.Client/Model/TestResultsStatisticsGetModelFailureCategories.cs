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
    /// Test results counts aggregated by result failure categories
    /// </summary>
    [DataContract(Name = "TestResultsStatisticsGetModel_failureCategories")]
    public partial class TestResultsStatisticsGetModelFailureCategories : IEquatable<TestResultsStatisticsGetModelFailureCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsStatisticsGetModelFailureCategories" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestResultsStatisticsGetModelFailureCategories() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsStatisticsGetModelFailureCategories" /> class.
        /// </summary>
        /// <param name="noAnalytics">Number of test results which outcomes were not analyzed (required).</param>
        /// <param name="noDefect">Number of test results which outcomes were not caused by any defect (required).</param>
        /// <param name="infrastructureDefect">Number of test results which outcomes were caused by some infrastructure defect (required).</param>
        /// <param name="productDefect">Number of test results which outcomes were caused by some tested product defect (required).</param>
        /// <param name="testDefect">Number of test results which outcomes were caused by test itself (required).</param>
        public TestResultsStatisticsGetModelFailureCategories(int noAnalytics = default(int), int noDefect = default(int), int infrastructureDefect = default(int), int productDefect = default(int), int testDefect = default(int))
        {
            this.NoAnalytics = noAnalytics;
            this.NoDefect = noDefect;
            this.InfrastructureDefect = infrastructureDefect;
            this.ProductDefect = productDefect;
            this.TestDefect = testDefect;
        }

        /// <summary>
        /// Number of test results which outcomes were not analyzed
        /// </summary>
        /// <value>Number of test results which outcomes were not analyzed</value>
        [DataMember(Name = "noAnalytics", IsRequired = true, EmitDefaultValue = true)]
        public int NoAnalytics { get; set; }

        /// <summary>
        /// Number of test results which outcomes were not caused by any defect
        /// </summary>
        /// <value>Number of test results which outcomes were not caused by any defect</value>
        [DataMember(Name = "noDefect", IsRequired = true, EmitDefaultValue = true)]
        public int NoDefect { get; set; }

        /// <summary>
        /// Number of test results which outcomes were caused by some infrastructure defect
        /// </summary>
        /// <value>Number of test results which outcomes were caused by some infrastructure defect</value>
        [DataMember(Name = "infrastructureDefect", IsRequired = true, EmitDefaultValue = true)]
        public int InfrastructureDefect { get; set; }

        /// <summary>
        /// Number of test results which outcomes were caused by some tested product defect
        /// </summary>
        /// <value>Number of test results which outcomes were caused by some tested product defect</value>
        [DataMember(Name = "productDefect", IsRequired = true, EmitDefaultValue = true)]
        public int ProductDefect { get; set; }

        /// <summary>
        /// Number of test results which outcomes were caused by test itself
        /// </summary>
        /// <value>Number of test results which outcomes were caused by test itself</value>
        [DataMember(Name = "testDefect", IsRequired = true, EmitDefaultValue = true)]
        public int TestDefect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultsStatisticsGetModelFailureCategories {\n");
            sb.Append("  NoAnalytics: ").Append(NoAnalytics).Append("\n");
            sb.Append("  NoDefect: ").Append(NoDefect).Append("\n");
            sb.Append("  InfrastructureDefect: ").Append(InfrastructureDefect).Append("\n");
            sb.Append("  ProductDefect: ").Append(ProductDefect).Append("\n");
            sb.Append("  TestDefect: ").Append(TestDefect).Append("\n");
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
            return this.Equals(input as TestResultsStatisticsGetModelFailureCategories);
        }

        /// <summary>
        /// Returns true if TestResultsStatisticsGetModelFailureCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultsStatisticsGetModelFailureCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultsStatisticsGetModelFailureCategories input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoAnalytics == input.NoAnalytics ||
                    this.NoAnalytics.Equals(input.NoAnalytics)
                ) && 
                (
                    this.NoDefect == input.NoDefect ||
                    this.NoDefect.Equals(input.NoDefect)
                ) && 
                (
                    this.InfrastructureDefect == input.InfrastructureDefect ||
                    this.InfrastructureDefect.Equals(input.InfrastructureDefect)
                ) && 
                (
                    this.ProductDefect == input.ProductDefect ||
                    this.ProductDefect.Equals(input.ProductDefect)
                ) && 
                (
                    this.TestDefect == input.TestDefect ||
                    this.TestDefect.Equals(input.TestDefect)
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
                hashCode = (hashCode * 59) + this.NoAnalytics.GetHashCode();
                hashCode = (hashCode * 59) + this.NoDefect.GetHashCode();
                hashCode = (hashCode * 59) + this.InfrastructureDefect.GetHashCode();
                hashCode = (hashCode * 59) + this.ProductDefect.GetHashCode();
                hashCode = (hashCode * 59) + this.TestDefect.GetHashCode();
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