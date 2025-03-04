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
    /// TestResultApiResult
    /// </summary>
    [DataContract(Name = "TestResultApiResult")]
    public partial class TestResultApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestResultApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultApiResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="durationInMs">durationInMs.</param>
        /// <param name="traces">traces.</param>
        /// <param name="failureType">failureType.</param>
        /// <param name="message">message.</param>
        /// <param name="runByUserId">runByUserId.</param>
        /// <param name="stoppedByUserId">stoppedByUserId.</param>
        /// <param name="outcome">outcome (required).</param>
        /// <param name="autoTestId">autoTestId.</param>
        /// <param name="testPointId">testPointId.</param>
        /// <param name="testRunId">testRunId (required).</param>
        /// <param name="configurationId">configurationId (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="testPoint">testPoint.</param>
        /// <param name="autoTest">autoTest.</param>
        /// <param name="autoTestStepResults">autoTestStepResults.</param>
        /// <param name="setupResults">setupResults.</param>
        /// <param name="teardownResults">teardownResults.</param>
        /// <param name="workItemVersionId">workItemVersionId.</param>
        /// <param name="workItemVersionNumber">workItemVersionNumber.</param>
        /// <param name="attachments">attachments (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="failureClasses">failureClasses (required).</param>
        /// <param name="stepComments">stepComments.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="properties">properties.</param>
        /// <param name="createdDate">createdDate (required).</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        public TestResultApiResult(Guid id = default(Guid), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? durationInMs = default(long?), string traces = default(string), string failureType = default(string), string message = default(string), Guid? runByUserId = default(Guid?), Guid? stoppedByUserId = default(Guid?), string outcome = default(string), Guid? autoTestId = default(Guid?), Guid? testPointId = default(Guid?), Guid testRunId = default(Guid), Guid configurationId = default(Guid), TestStatusApiResult status = default(TestStatusApiResult), TestPointShortApiResult testPoint = default(TestPointShortApiResult), AutoTestApiResult autoTest = default(AutoTestApiResult), List<AutoTestStepResultsApiResult> autoTestStepResults = default(List<AutoTestStepResultsApiResult>), List<AutoTestStepResultsApiResult> setupResults = default(List<AutoTestStepResultsApiResult>), List<AutoTestStepResultsApiResult> teardownResults = default(List<AutoTestStepResultsApiResult>), Guid? workItemVersionId = default(Guid?), int? workItemVersionNumber = default(int?), List<AttachmentApiResult> attachments = default(List<AttachmentApiResult>), List<LinkApiResult> links = default(List<LinkApiResult>), List<TestResultFailureClassApiResult> failureClasses = default(List<TestResultFailureClassApiResult>), List<StepCommentApiModel> stepComments = default(List<StepCommentApiModel>), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> properties = default(Dictionary<string, string>), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), bool isDeleted = default(bool))
        {
            this.Id = id;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for TestResultApiResult and cannot be null");
            }
            this.Outcome = outcome;
            this.TestRunId = testRunId;
            this.ConfigurationId = configurationId;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TestResultApiResult and cannot be null");
            }
            this.Status = status;
            // to ensure "attachments" is required (not null)
            if (attachments == null)
            {
                throw new ArgumentNullException("attachments is a required property for TestResultApiResult and cannot be null");
            }
            this.Attachments = attachments;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for TestResultApiResult and cannot be null");
            }
            this.Links = links;
            // to ensure "failureClasses" is required (not null)
            if (failureClasses == null)
            {
                throw new ArgumentNullException("failureClasses is a required property for TestResultApiResult and cannot be null");
            }
            this.FailureClasses = failureClasses;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.IsDeleted = isDeleted;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.DurationInMs = durationInMs;
            this.Traces = traces;
            this.FailureType = failureType;
            this.Message = message;
            this.RunByUserId = runByUserId;
            this.StoppedByUserId = stoppedByUserId;
            this.AutoTestId = autoTestId;
            this.TestPointId = testPointId;
            this.TestPoint = testPoint;
            this.AutoTest = autoTest;
            this.AutoTestStepResults = autoTestStepResults;
            this.SetupResults = setupResults;
            this.TeardownResults = teardownResults;
            this.WorkItemVersionId = workItemVersionId;
            this.WorkItemVersionNumber = workItemVersionNumber;
            this.StepComments = stepComments;
            this.Parameters = parameters;
            this.Properties = properties;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Gets or Sets DurationInMs
        /// </summary>
        [DataMember(Name = "durationInMs", EmitDefaultValue = true)]
        public long? DurationInMs { get; set; }

        /// <summary>
        /// Gets or Sets Traces
        /// </summary>
        [DataMember(Name = "traces", EmitDefaultValue = true)]
        public string Traces { get; set; }

        /// <summary>
        /// Gets or Sets FailureType
        /// </summary>
        [DataMember(Name = "failureType", EmitDefaultValue = true)]
        public string FailureType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets RunByUserId
        /// </summary>
        [DataMember(Name = "runByUserId", EmitDefaultValue = true)]
        public Guid? RunByUserId { get; set; }

        /// <summary>
        /// Gets or Sets StoppedByUserId
        /// </summary>
        [DataMember(Name = "stoppedByUserId", EmitDefaultValue = true)]
        public Guid? StoppedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestId
        /// </summary>
        [DataMember(Name = "autoTestId", EmitDefaultValue = true)]
        public Guid? AutoTestId { get; set; }

        /// <summary>
        /// Gets or Sets TestPointId
        /// </summary>
        [DataMember(Name = "testPointId", EmitDefaultValue = true)]
        public Guid? TestPointId { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusApiResult Status { get; set; }

        /// <summary>
        /// Gets or Sets TestPoint
        /// </summary>
        [DataMember(Name = "testPoint", EmitDefaultValue = true)]
        public TestPointShortApiResult TestPoint { get; set; }

        /// <summary>
        /// Gets or Sets AutoTest
        /// </summary>
        [DataMember(Name = "autoTest", EmitDefaultValue = true)]
        public AutoTestApiResult AutoTest { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestStepResults
        /// </summary>
        [DataMember(Name = "autoTestStepResults", EmitDefaultValue = true)]
        public List<AutoTestStepResultsApiResult> AutoTestStepResults { get; set; }

        /// <summary>
        /// Gets or Sets SetupResults
        /// </summary>
        [DataMember(Name = "setupResults", EmitDefaultValue = true)]
        public List<AutoTestStepResultsApiResult> SetupResults { get; set; }

        /// <summary>
        /// Gets or Sets TeardownResults
        /// </summary>
        [DataMember(Name = "teardownResults", EmitDefaultValue = true)]
        public List<AutoTestStepResultsApiResult> TeardownResults { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionId
        /// </summary>
        [DataMember(Name = "workItemVersionId", EmitDefaultValue = true)]
        public Guid? WorkItemVersionId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionNumber
        /// </summary>
        [DataMember(Name = "workItemVersionNumber", EmitDefaultValue = true)]
        public int? WorkItemVersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = true)]
        public List<AttachmentApiResult> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkApiResult> Links { get; set; }

        /// <summary>
        /// Gets or Sets FailureClasses
        /// </summary>
        [DataMember(Name = "failureClasses", IsRequired = true, EmitDefaultValue = true)]
        public List<TestResultFailureClassApiResult> FailureClasses { get; set; }

        /// <summary>
        /// Gets or Sets StepComments
        /// </summary>
        [DataMember(Name = "stepComments", EmitDefaultValue = true)]
        public List<StepCommentApiModel> StepComments { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultApiResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  DurationInMs: ").Append(DurationInMs).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
            sb.Append("  FailureType: ").Append(FailureType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RunByUserId: ").Append(RunByUserId).Append("\n");
            sb.Append("  StoppedByUserId: ").Append(StoppedByUserId).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  AutoTestId: ").Append(AutoTestId).Append("\n");
            sb.Append("  TestPointId: ").Append(TestPointId).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TestPoint: ").Append(TestPoint).Append("\n");
            sb.Append("  AutoTest: ").Append(AutoTest).Append("\n");
            sb.Append("  AutoTestStepResults: ").Append(AutoTestStepResults).Append("\n");
            sb.Append("  SetupResults: ").Append(SetupResults).Append("\n");
            sb.Append("  TeardownResults: ").Append(TeardownResults).Append("\n");
            sb.Append("  WorkItemVersionId: ").Append(WorkItemVersionId).Append("\n");
            sb.Append("  WorkItemVersionNumber: ").Append(WorkItemVersionNumber).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  FailureClasses: ").Append(FailureClasses).Append("\n");
            sb.Append("  StepComments: ").Append(StepComments).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
