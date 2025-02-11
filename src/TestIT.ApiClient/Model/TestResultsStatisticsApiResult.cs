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
    /// TestResultsStatisticsApiResult
    /// </summary>
    [DataContract(Name = "TestResultsStatisticsApiResult")]
    public partial class TestResultsStatisticsApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsStatisticsApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TestResultsStatisticsApiResult()
        {
        }

        /// <summary>
        /// Test results counts aggregated by outcome
        /// </summary>
        /// <value>Test results counts aggregated by outcome</value>
        [DataMember(Name = "statuses", IsRequired = true, EmitDefaultValue = true)]
        public TestResultsStatisticsStatusesApiResult Statuses { get; private set; }

        /// <summary>
        /// Returns false as Statuses should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatuses()
        {
            return false;
        }
        /// <summary>
        /// Test results counts aggregated by result failure categories
        /// </summary>
        /// <value>Test results counts aggregated by result failure categories</value>
        [DataMember(Name = "failureCategories", IsRequired = true, EmitDefaultValue = true)]
        public TestResultsStatisticsFailureCategoriesApiResult FailureCategories { get; private set; }

        /// <summary>
        /// Returns false as FailureCategories should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailureCategories()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultsStatisticsApiResult {\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
