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
    /// TestPointShortResponseModel
    /// </summary>
    [DataContract(Name = "TestPointShortResponseModel")]
    public partial class TestPointShortResponseModel : IValidatableObject
    {

        /// <summary>
        /// Status of the test point
        /// </summary>
        /// <value>Status of the test point</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public TestPointStatus Status { get; set; }

        /// <summary>
        /// Priority of the test point
        /// </summary>
        /// <value>Priority of the test point</value>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }

        /// <summary>
        /// Work item state
        /// </summary>
        /// <value>Work item state</value>
        [DataMember(Name = "workItemState", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemState WorkItemState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointShortResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointShortResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointShortResponseModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the test point (required).</param>
        /// <param name="createdDate">Creation date of the test point (required).</param>
        /// <param name="createdById">Unique ID of the test point creator (required).</param>
        /// <param name="modifiedDate">Last modification date of the test point.</param>
        /// <param name="modifiedById">Unique ID of the test point last editor.</param>
        /// <param name="testerId">Unique ID of the test point assigned user.</param>
        /// <param name="parameters">Collection of the test point parameters.</param>
        /// <param name="attributes">Collection of attributes of work item the test point represents (required).</param>
        /// <param name="tags">Collection of the test point tags (required).</param>
        /// <param name="links">Collection of the test point links (required).</param>
        /// <param name="testSuiteId">Unique ID of test suite the test point assigned to (required).</param>
        /// <param name="testSuiteName">Name of the test suite (required).</param>
        /// <param name="workItemId">Unique ID of work item the test point represents (required).</param>
        /// <param name="workItemGlobalId">Global ID of work item the test point represents (required).</param>
        /// <param name="workItemVersionId">Unique ID of work item version the test point represents (required).</param>
        /// <param name="workItemVersionNumber">Number of work item version the test point represents (required).</param>
        /// <param name="workItemMedianDuration">Median duration of work item the test point represents.</param>
        /// <param name="status">Status of the test point (required).</param>
        /// <param name="statusModel">Status of the test point (required).</param>
        /// <param name="priority">Priority of the test point (required).</param>
        /// <param name="isAutomated">Indicates if the test point represents an autotest (required).</param>
        /// <param name="name">Name of the test point (required).</param>
        /// <param name="configurationId">Unique ID of the test point configuration (required).</param>
        /// <param name="duration">Duration of the test point (required).</param>
        /// <param name="sectionId">Unique ID of section where work item the test point represents is located (required).</param>
        /// <param name="sectionName">Name of section where work item the test point represents is located.</param>
        /// <param name="projectId">Unique ID of the test point project (required).</param>
        /// <param name="lastTestResult">Model of the test point last test result.</param>
        /// <param name="iterationId">Unique ID of work item iteration the test point represents (required).</param>
        /// <param name="workItemState">Work item state (required).</param>
        /// <param name="workItemCreatedById">Unique ID of the work item creator (required).</param>
        /// <param name="workItemCreatedDate">Creation date of work item (required).</param>
        /// <param name="workItemModifiedById">Unique ID of the work item last editor.</param>
        /// <param name="workItemModifiedDate">Modified date of work item.</param>
        public TestPointShortResponseModel(Guid id = default(Guid), DateTime createdDate = default(DateTime), Guid createdById = default(Guid), DateTime? modifiedDate = default(DateTime?), Guid? modifiedById = default(Guid?), Guid? testerId = default(Guid?), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<string> tags = default(List<string>), List<string> links = default(List<string>), Guid testSuiteId = default(Guid), string testSuiteName = default(string), Guid workItemId = default(Guid), long workItemGlobalId = default(long), Guid workItemVersionId = default(Guid), int workItemVersionNumber = default(int), long? workItemMedianDuration = default(long?), TestPointStatus status = default(TestPointStatus), TestStatusApiResult statusModel = default(TestStatusApiResult), WorkItemPriorityModel priority = default(WorkItemPriorityModel), bool isAutomated = default(bool), string name = default(string), Guid configurationId = default(Guid), int duration = default(int), Guid sectionId = default(Guid), string sectionName = default(string), Guid projectId = default(Guid), LastTestResultModel lastTestResult = default(LastTestResultModel), Guid iterationId = default(Guid), WorkItemState workItemState = default(WorkItemState), Guid workItemCreatedById = default(Guid), DateTime workItemCreatedDate = default(DateTime), Guid? workItemModifiedById = default(Guid?), DateTime? workItemModifiedDate = default(DateTime?))
        {
            this.Id = id;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.Tags = tags;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.Links = links;
            this.TestSuiteId = testSuiteId;
            // to ensure "testSuiteName" is required (not null)
            if (testSuiteName == null)
            {
                throw new ArgumentNullException("testSuiteName is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.TestSuiteName = testSuiteName;
            this.WorkItemId = workItemId;
            this.WorkItemGlobalId = workItemGlobalId;
            this.WorkItemVersionId = workItemVersionId;
            this.WorkItemVersionNumber = workItemVersionNumber;
            this.Status = status;
            // to ensure "statusModel" is required (not null)
            if (statusModel == null)
            {
                throw new ArgumentNullException("statusModel is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.StatusModel = statusModel;
            this.Priority = priority;
            this.IsAutomated = isAutomated;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestPointShortResponseModel and cannot be null");
            }
            this.Name = name;
            this.ConfigurationId = configurationId;
            this.Duration = duration;
            this.SectionId = sectionId;
            this.ProjectId = projectId;
            this.IterationId = iterationId;
            this.WorkItemState = workItemState;
            this.WorkItemCreatedById = workItemCreatedById;
            this.WorkItemCreatedDate = workItemCreatedDate;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.TesterId = testerId;
            this.Parameters = parameters;
            this.WorkItemMedianDuration = workItemMedianDuration;
            this.SectionName = sectionName;
            this.LastTestResult = lastTestResult;
            this.WorkItemModifiedById = workItemModifiedById;
            this.WorkItemModifiedDate = workItemModifiedDate;
        }

        /// <summary>
        /// Unique ID of the test point
        /// </summary>
        /// <value>Unique ID of the test point</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Creation date of the test point
        /// </summary>
        /// <value>Creation date of the test point</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Unique ID of the test point creator
        /// </summary>
        /// <value>Unique ID of the test point creator</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Last modification date of the test point
        /// </summary>
        /// <value>Last modification date of the test point</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Unique ID of the test point last editor
        /// </summary>
        /// <value>Unique ID of the test point last editor</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Unique ID of the test point assigned user
        /// </summary>
        /// <value>Unique ID of the test point assigned user</value>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Collection of the test point parameters
        /// </summary>
        /// <value>Collection of the test point parameters</value>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Collection of attributes of work item the test point represents
        /// </summary>
        /// <value>Collection of attributes of work item the test point represents</value>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Collection of the test point tags
        /// </summary>
        /// <value>Collection of the test point tags</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Collection of the test point links
        /// </summary>
        /// <value>Collection of the test point links</value>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Links { get; set; }

        /// <summary>
        /// Unique ID of test suite the test point assigned to
        /// </summary>
        /// <value>Unique ID of test suite the test point assigned to</value>
        [DataMember(Name = "testSuiteId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestSuiteId { get; set; }

        /// <summary>
        /// Name of the test suite
        /// </summary>
        /// <value>Name of the test suite</value>
        [DataMember(Name = "testSuiteName", IsRequired = true, EmitDefaultValue = true)]
        public string TestSuiteName { get; set; }

        /// <summary>
        /// Unique ID of work item the test point represents
        /// </summary>
        /// <value>Unique ID of work item the test point represents</value>
        [DataMember(Name = "workItemId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemId { get; set; }

        /// <summary>
        /// Global ID of work item the test point represents
        /// </summary>
        /// <value>Global ID of work item the test point represents</value>
        [DataMember(Name = "workItemGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long WorkItemGlobalId { get; set; }

        /// <summary>
        /// Unique ID of work item version the test point represents
        /// </summary>
        /// <value>Unique ID of work item version the test point represents</value>
        [DataMember(Name = "workItemVersionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemVersionId { get; set; }

        /// <summary>
        /// Number of work item version the test point represents
        /// </summary>
        /// <value>Number of work item version the test point represents</value>
        [DataMember(Name = "workItemVersionNumber", IsRequired = true, EmitDefaultValue = true)]
        public int WorkItemVersionNumber { get; set; }

        /// <summary>
        /// Median duration of work item the test point represents
        /// </summary>
        /// <value>Median duration of work item the test point represents</value>
        [DataMember(Name = "workItemMedianDuration", EmitDefaultValue = true)]
        public long? WorkItemMedianDuration { get; set; }

        /// <summary>
        /// Status of the test point
        /// </summary>
        /// <value>Status of the test point</value>
        [DataMember(Name = "statusModel", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusApiResult StatusModel { get; set; }

        /// <summary>
        /// Indicates if the test point represents an autotest
        /// </summary>
        /// <value>Indicates if the test point represents an autotest</value>
        [DataMember(Name = "isAutomated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Name of the test point
        /// </summary>
        /// <value>Name of the test point</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of the test point configuration
        /// </summary>
        /// <value>Unique ID of the test point configuration</value>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Duration of the test point
        /// </summary>
        /// <value>Duration of the test point</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public int Duration { get; set; }

        /// <summary>
        /// Unique ID of section where work item the test point represents is located
        /// </summary>
        /// <value>Unique ID of section where work item the test point represents is located</value>
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Name of section where work item the test point represents is located
        /// </summary>
        /// <value>Name of section where work item the test point represents is located</value>
        [DataMember(Name = "sectionName", EmitDefaultValue = true)]
        public string SectionName { get; set; }

        /// <summary>
        /// Unique ID of the test point project
        /// </summary>
        /// <value>Unique ID of the test point project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Model of the test point last test result
        /// </summary>
        /// <value>Model of the test point last test result</value>
        [DataMember(Name = "lastTestResult", EmitDefaultValue = true)]
        public LastTestResultModel LastTestResult { get; set; }

        /// <summary>
        /// Unique ID of work item iteration the test point represents
        /// </summary>
        /// <value>Unique ID of work item iteration the test point represents</value>
        [DataMember(Name = "iterationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Unique ID of the work item creator
        /// </summary>
        /// <value>Unique ID of the work item creator</value>
        [DataMember(Name = "workItemCreatedById", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemCreatedById { get; set; }

        /// <summary>
        /// Creation date of work item
        /// </summary>
        /// <value>Creation date of work item</value>
        [DataMember(Name = "workItemCreatedDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime WorkItemCreatedDate { get; set; }

        /// <summary>
        /// Unique ID of the work item last editor
        /// </summary>
        /// <value>Unique ID of the work item last editor</value>
        [DataMember(Name = "workItemModifiedById", EmitDefaultValue = true)]
        public Guid? WorkItemModifiedById { get; set; }

        /// <summary>
        /// Modified date of work item
        /// </summary>
        /// <value>Modified date of work item</value>
        [DataMember(Name = "workItemModifiedDate", EmitDefaultValue = true)]
        public DateTime? WorkItemModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointShortResponseModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  TestSuiteName: ").Append(TestSuiteName).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  WorkItemGlobalId: ").Append(WorkItemGlobalId).Append("\n");
            sb.Append("  WorkItemVersionId: ").Append(WorkItemVersionId).Append("\n");
            sb.Append("  WorkItemVersionNumber: ").Append(WorkItemVersionNumber).Append("\n");
            sb.Append("  WorkItemMedianDuration: ").Append(WorkItemMedianDuration).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusModel: ").Append(StatusModel).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  LastTestResult: ").Append(LastTestResult).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
            sb.Append("  WorkItemState: ").Append(WorkItemState).Append("\n");
            sb.Append("  WorkItemCreatedById: ").Append(WorkItemCreatedById).Append("\n");
            sb.Append("  WorkItemCreatedDate: ").Append(WorkItemCreatedDate).Append("\n");
            sb.Append("  WorkItemModifiedById: ").Append(WorkItemModifiedById).Append("\n");
            sb.Append("  WorkItemModifiedDate: ").Append(WorkItemModifiedDate).Append("\n");
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
