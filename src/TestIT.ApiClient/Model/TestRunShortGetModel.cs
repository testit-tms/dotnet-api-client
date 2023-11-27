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
    /// TestRunShortGetModel
    /// </summary>
    [DataContract(Name = "TestRunShortGetModel")]
    public partial class TestRunShortGetModel : IEquatable<TestRunShortGetModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public TestRunState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunShortGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortGetModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the test run (required).</param>
        /// <param name="name">Name of the test run (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="createdDate">Date when the test run was created (required).</param>
        /// <param name="startedDate">Date when the test run was started.</param>
        /// <param name="completedDate">Completion date of the test run.</param>
        /// <param name="createdById">Unique ID of user who created the test run (required).</param>
        /// <param name="modifiedById">Unique ID of user who modified the test run last time.</param>
        /// <param name="isDeleted">Is the test run is deleted (required).</param>
        /// <param name="autoTestsCount">Number of AutoTests run in the test run (required).</param>
        /// <param name="statistics">statistics (required).</param>
        public TestRunShortGetModel(Guid id = default(Guid), string name = default(string), TestRunState state = default(TestRunState), DateTime createdDate = default(DateTime), DateTime? startedDate = default(DateTime?), DateTime? completedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), bool isDeleted = default(bool), int autoTestsCount = default(int), TestRunShortGetModelStatistics statistics = default(TestRunShortGetModelStatistics))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestRunShortGetModel and cannot be null");
            }
            this.Name = name;
            this.State = state;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.IsDeleted = isDeleted;
            this.AutoTestsCount = autoTestsCount;
            // to ensure "statistics" is required (not null)
            if (statistics == null)
            {
                throw new ArgumentNullException("statistics is a required property for TestRunShortGetModel and cannot be null");
            }
            this.Statistics = statistics;
            this.StartedDate = startedDate;
            this.CompletedDate = completedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Unique ID of the test run
        /// </summary>
        /// <value>Unique ID of the test run</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the test run
        /// </summary>
        /// <value>Name of the test run</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Date when the test run was created
        /// </summary>
        /// <value>Date when the test run was created</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date when the test run was started
        /// </summary>
        /// <value>Date when the test run was started</value>
        [DataMember(Name = "startedDate", EmitDefaultValue = true)]
        public DateTime? StartedDate { get; set; }

        /// <summary>
        /// Completion date of the test run
        /// </summary>
        /// <value>Completion date of the test run</value>
        [DataMember(Name = "completedDate", EmitDefaultValue = true)]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Unique ID of user who created the test run
        /// </summary>
        /// <value>Unique ID of user who created the test run</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique ID of user who modified the test run last time
        /// </summary>
        /// <value>Unique ID of user who modified the test run last time</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Is the test run is deleted
        /// </summary>
        /// <value>Is the test run is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Number of AutoTests run in the test run
        /// </summary>
        /// <value>Number of AutoTests run in the test run</value>
        [DataMember(Name = "autoTestsCount", IsRequired = true, EmitDefaultValue = true)]
        public int AutoTestsCount { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name = "statistics", IsRequired = true, EmitDefaultValue = true)]
        public TestRunShortGetModelStatistics Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunShortGetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  AutoTestsCount: ").Append(AutoTestsCount).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(input as TestRunShortGetModel);
        }

        /// <summary>
        /// Returns true if TestRunShortGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunShortGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunShortGetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.StartedDate == input.StartedDate ||
                    (this.StartedDate != null &&
                    this.StartedDate.Equals(input.StartedDate))
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.AutoTestsCount == input.AutoTestsCount ||
                    this.AutoTestsCount.Equals(input.AutoTestsCount)
                ) && 
                (
                    this.Statistics == input.Statistics ||
                    (this.Statistics != null &&
                    this.Statistics.Equals(input.Statistics))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.StartedDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartedDate.GetHashCode();
                }
                if (this.CompletedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedDate.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoTestsCount.GetHashCode();
                if (this.Statistics != null)
                {
                    hashCode = (hashCode * 59) + this.Statistics.GetHashCode();
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
