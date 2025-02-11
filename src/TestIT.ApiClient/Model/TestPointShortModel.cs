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
    /// TestPointShortModel
    /// </summary>
    [DataContract(Name = "TestPointShortModel")]
    public partial class TestPointShortModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointShortModel" /> class.
        /// </summary>
        /// <param name="testSuiteId">testSuiteId (required).</param>
        /// <param name="id">Test point unique internal identifier (required).</param>
        /// <param name="testerId">Tester who is responded for the test unique internal identifier.</param>
        /// <param name="workItemId">Workitem to which test point relates unique identifier.</param>
        /// <param name="configurationId">Configuration to which test point relates unique identifier.</param>
        /// <param name="status">Test point status   Applies one of these values: Blocked, NoResults, Failed, Passed.</param>
        /// <param name="lastTestResultId">Last test result unique identifier.</param>
        /// <param name="iterationId">Iteration unique identifier (required).</param>
        /// <param name="workItemMedianDuration">Median duration of work item the test point represents.</param>
        public TestPointShortModel(Guid testSuiteId = default(Guid), Guid id = default(Guid), Guid? testerId = default(Guid?), Guid? workItemId = default(Guid?), Guid? configurationId = default(Guid?), string status = default(string), Guid? lastTestResultId = default(Guid?), Guid iterationId = default(Guid), long? workItemMedianDuration = default(long?))
        {
            this.TestSuiteId = testSuiteId;
            this.Id = id;
            this.IterationId = iterationId;
            this.TesterId = testerId;
            this.WorkItemId = workItemId;
            this.ConfigurationId = configurationId;
            this.Status = status;
            this.LastTestResultId = lastTestResultId;
            this.WorkItemMedianDuration = workItemMedianDuration;
        }

        /// <summary>
        /// Gets or Sets TestSuiteId
        /// </summary>
        /*
        <example>cbb88fe6-c193-48e9-9e37-323fbc38de5f</example>
        */
        [DataMember(Name = "testSuiteId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestSuiteId { get; set; }

        /// <summary>
        /// Test point unique internal identifier
        /// </summary>
        /// <value>Test point unique internal identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Tester who is responded for the test unique internal identifier
        /// </summary>
        /// <value>Tester who is responded for the test unique internal identifier</value>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Workitem to which test point relates unique identifier
        /// </summary>
        /// <value>Workitem to which test point relates unique identifier</value>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Configuration to which test point relates unique identifier
        /// </summary>
        /// <value>Configuration to which test point relates unique identifier</value>
        [DataMember(Name = "configurationId", EmitDefaultValue = true)]
        public Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Test point status   Applies one of these values: Blocked, NoResults, Failed, Passed
        /// </summary>
        /// <value>Test point status   Applies one of these values: Blocked, NoResults, Failed, Passed</value>
        /*
        <example>NoResult</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Last test result unique identifier
        /// </summary>
        /// <value>Last test result unique identifier</value>
        [DataMember(Name = "lastTestResultId", EmitDefaultValue = true)]
        public Guid? LastTestResultId { get; set; }

        /// <summary>
        /// Iteration unique identifier
        /// </summary>
        /// <value>Iteration unique identifier</value>
        [DataMember(Name = "iterationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Median duration of work item the test point represents
        /// </summary>
        /// <value>Median duration of work item the test point represents</value>
        [DataMember(Name = "workItemMedianDuration", EmitDefaultValue = true)]
        public long? WorkItemMedianDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointShortModel {\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastTestResultId: ").Append(LastTestResultId).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
            sb.Append("  WorkItemMedianDuration: ").Append(WorkItemMedianDuration).Append("\n");
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
