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
    /// TestRunTestResultsSelectModel
    /// </summary>
    [DataContract(Name = "TestRunTestResultsSelectModel")]
    public partial class TestRunTestResultsSelectModel : IEquatable<TestRunTestResultsSelectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunTestResultsSelectModel" /> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="testResultIdsExtractionModel">testResultIdsExtractionModel.</param>
        public TestRunTestResultsSelectModel(TestRunTestResultsSelectModelFilter filter = default(TestRunTestResultsSelectModelFilter), TestRunTestResultsSelectModelTestResultIdsExtractionModel testResultIdsExtractionModel = default(TestRunTestResultsSelectModelTestResultIdsExtractionModel))
        {
            this.Filter = filter;
            this.TestResultIdsExtractionModel = testResultIdsExtractionModel;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public TestRunTestResultsSelectModelFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets TestResultIdsExtractionModel
        /// </summary>
        [DataMember(Name = "testResultIdsExtractionModel", EmitDefaultValue = true)]
        public TestRunTestResultsSelectModelTestResultIdsExtractionModel TestResultIdsExtractionModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunTestResultsSelectModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  TestResultIdsExtractionModel: ").Append(TestResultIdsExtractionModel).Append("\n");
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
            return this.Equals(input as TestRunTestResultsSelectModel);
        }

        /// <summary>
        /// Returns true if TestRunTestResultsSelectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunTestResultsSelectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunTestResultsSelectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.TestResultIdsExtractionModel == input.TestResultIdsExtractionModel ||
                    (this.TestResultIdsExtractionModel != null &&
                    this.TestResultIdsExtractionModel.Equals(input.TestResultIdsExtractionModel))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.TestResultIdsExtractionModel != null)
                {
                    hashCode = (hashCode * 59) + this.TestResultIdsExtractionModel.GetHashCode();
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
