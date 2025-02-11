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
    /// TestPlanSummaryModel
    /// </summary>
    [DataContract(Name = "TestPlanSummaryModel")]
    public partial class TestPlanSummaryModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanSummaryModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanSummaryModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanSummaryModel" /> class.
        /// </summary>
        /// <param name="totalTestPointsCount">totalTestPointsCount (required).</param>
        /// <param name="manualTestPointsCount">manualTestPointsCount (required).</param>
        /// <param name="automatedTestPointsCount">automatedTestPointsCount (required).</param>
        /// <param name="completedTestPointsCount">completedTestPointsCount (required).</param>
        /// <param name="defectsCount">defectsCount (required).</param>
        /// <param name="plannedTestPointsDuration">plannedTestPointsDuration (required).</param>
        /// <param name="spentTestPointsDuration">spentTestPointsDuration.</param>
        public TestPlanSummaryModel(int totalTestPointsCount = default(int), int manualTestPointsCount = default(int), int automatedTestPointsCount = default(int), int completedTestPointsCount = default(int), int defectsCount = default(int), long plannedTestPointsDuration = default(long), long? spentTestPointsDuration = default(long?))
        {
            this.TotalTestPointsCount = totalTestPointsCount;
            this.ManualTestPointsCount = manualTestPointsCount;
            this.AutomatedTestPointsCount = automatedTestPointsCount;
            this.CompletedTestPointsCount = completedTestPointsCount;
            this.DefectsCount = defectsCount;
            this.PlannedTestPointsDuration = plannedTestPointsDuration;
            this.SpentTestPointsDuration = spentTestPointsDuration;
        }

        /// <summary>
        /// Gets or Sets TotalTestPointsCount
        /// </summary>
        [DataMember(Name = "totalTestPointsCount", IsRequired = true, EmitDefaultValue = true)]
        public int TotalTestPointsCount { get; set; }

        /// <summary>
        /// Gets or Sets ManualTestPointsCount
        /// </summary>
        [DataMember(Name = "manualTestPointsCount", IsRequired = true, EmitDefaultValue = true)]
        public int ManualTestPointsCount { get; set; }

        /// <summary>
        /// Gets or Sets AutomatedTestPointsCount
        /// </summary>
        [DataMember(Name = "automatedTestPointsCount", IsRequired = true, EmitDefaultValue = true)]
        public int AutomatedTestPointsCount { get; set; }

        /// <summary>
        /// Gets or Sets CompletedTestPointsCount
        /// </summary>
        [DataMember(Name = "completedTestPointsCount", IsRequired = true, EmitDefaultValue = true)]
        public int CompletedTestPointsCount { get; set; }

        /// <summary>
        /// Gets or Sets DefectsCount
        /// </summary>
        [DataMember(Name = "defectsCount", IsRequired = true, EmitDefaultValue = true)]
        public int DefectsCount { get; set; }

        /// <summary>
        /// Gets or Sets PlannedTestPointsDuration
        /// </summary>
        [DataMember(Name = "plannedTestPointsDuration", IsRequired = true, EmitDefaultValue = true)]
        public long PlannedTestPointsDuration { get; set; }

        /// <summary>
        /// Gets or Sets SpentTestPointsDuration
        /// </summary>
        [DataMember(Name = "spentTestPointsDuration", EmitDefaultValue = true)]
        public long? SpentTestPointsDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanSummaryModel {\n");
            sb.Append("  TotalTestPointsCount: ").Append(TotalTestPointsCount).Append("\n");
            sb.Append("  ManualTestPointsCount: ").Append(ManualTestPointsCount).Append("\n");
            sb.Append("  AutomatedTestPointsCount: ").Append(AutomatedTestPointsCount).Append("\n");
            sb.Append("  CompletedTestPointsCount: ").Append(CompletedTestPointsCount).Append("\n");
            sb.Append("  DefectsCount: ").Append(DefectsCount).Append("\n");
            sb.Append("  PlannedTestPointsDuration: ").Append(PlannedTestPointsDuration).Append("\n");
            sb.Append("  SpentTestPointsDuration: ").Append(SpentTestPointsDuration).Append("\n");
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
