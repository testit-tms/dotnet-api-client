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
    /// AutotestHistoricalResultSelectModel
    /// </summary>
    [DataContract(Name = "AutotestHistoricalResultSelectModel")]
    public partial class AutotestHistoricalResultSelectModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestHistoricalResultSelectModel" /> class.
        /// </summary>
        /// <param name="outcomes">outcomes.</param>
        /// <param name="testPlanIds">testPlanIds.</param>
        /// <param name="testRunIds">testRunIds.</param>
        /// <param name="configurationIds">configurationIds.</param>
        /// <param name="launchSource">launchSource.</param>
        /// <param name="userIds">userIds.</param>
        /// <param name="duration">duration.</param>
        public AutotestHistoricalResultSelectModel(List<AutotestResultOutcome> outcomes = default(List<AutotestResultOutcome>), List<Guid> testPlanIds = default(List<Guid>), List<Guid> testRunIds = default(List<Guid>), List<Guid> configurationIds = default(List<Guid>), string launchSource = default(string), List<Guid> userIds = default(List<Guid>), Int64RangeSelectorModel duration = default(Int64RangeSelectorModel))
        {
            this.Outcomes = outcomes;
            this.TestPlanIds = testPlanIds;
            this.TestRunIds = testRunIds;
            this.ConfigurationIds = configurationIds;
            this.LaunchSource = launchSource;
            this.UserIds = userIds;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or Sets Outcomes
        /// </summary>
        [DataMember(Name = "outcomes", EmitDefaultValue = true)]
        public List<AutotestResultOutcome> Outcomes { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanIds
        /// </summary>
        [DataMember(Name = "testPlanIds", EmitDefaultValue = true)]
        public List<Guid> TestPlanIds { get; set; }

        /// <summary>
        /// Gets or Sets TestRunIds
        /// </summary>
        [DataMember(Name = "testRunIds", EmitDefaultValue = true)]
        public List<Guid> TestRunIds { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationIds
        /// </summary>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSource
        /// </summary>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name = "userIds", EmitDefaultValue = true)]
        public List<Guid> UserIds { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public Int64RangeSelectorModel Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutotestHistoricalResultSelectModel {\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
            sb.Append("  TestPlanIds: ").Append(TestPlanIds).Append("\n");
            sb.Append("  TestRunIds: ").Append(TestRunIds).Append("\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            // LaunchSource (string) maxLength
            if (this.LaunchSource != null && this.LaunchSource.Length > 255)
            {
                yield return new ValidationResult("Invalid value for LaunchSource, length must be less than 255.", new [] { "LaunchSource" });
            }

            // LaunchSource (string) minLength
            if (this.LaunchSource != null && this.LaunchSource.Length < 0)
            {
                yield return new ValidationResult("Invalid value for LaunchSource, length must be greater than 0.", new [] { "LaunchSource" });
            }

            yield break;
        }
    }

}
