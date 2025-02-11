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
    /// ProjectShortModel
    /// </summary>
    [DataContract(Name = "ProjectShortModel")]
    public partial class ProjectShortModel : IValidatableObject
    {

        /// <summary>
        /// Type of the project
        /// </summary>
        /// <value>Type of the project</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ProjectTypeModel Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectShortModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the project (required).</param>
        /// <param name="description">Description of the project.</param>
        /// <param name="name">Name of the project (required).</param>
        /// <param name="isFavorite">Indicates if the project is marked as favorite (required).</param>
        /// <param name="testCasesCount">Number of test cases in the project.</param>
        /// <param name="sharedStepsCount">Number of shared steps in the project.</param>
        /// <param name="checkListsCount">Number of checklists in the project.</param>
        /// <param name="autoTestsCount">Number of autotests in the project.</param>
        /// <param name="isDeleted">Indicates if the project is deleted (required).</param>
        /// <param name="createdDate">Creation date of the project (required).</param>
        /// <param name="modifiedDate">Last modification date of the project.</param>
        /// <param name="createdById">Unique ID of the project creator (required).</param>
        /// <param name="modifiedById">Unique ID of the project last editor.</param>
        /// <param name="globalId">Global ID of the project (required).</param>
        /// <param name="type">Type of the project (required).</param>
        /// <param name="isFlakyAuto">Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically (required).</param>
        public ProjectShortModel(Guid id = default(Guid), string description = default(string), string name = default(string), bool isFavorite = default(bool), int? testCasesCount = default(int?), int? sharedStepsCount = default(int?), int? checkListsCount = default(int?), int? autoTestsCount = default(int?), bool isDeleted = default(bool), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), long globalId = default(long), ProjectTypeModel type = default(ProjectTypeModel), bool isFlakyAuto = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProjectShortModel and cannot be null");
            }
            this.Name = name;
            this.IsFavorite = isFavorite;
            this.IsDeleted = isDeleted;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.GlobalId = globalId;
            this.Type = type;
            this.IsFlakyAuto = isFlakyAuto;
            this.Description = description;
            this.TestCasesCount = testCasesCount;
            this.SharedStepsCount = sharedStepsCount;
            this.CheckListsCount = checkListsCount;
            this.AutoTestsCount = autoTestsCount;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Unique ID of the project
        /// </summary>
        /// <value>Unique ID of the project</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        /// <value>Description of the project</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        /// <value>Name of the project</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the project is marked as favorite
        /// </summary>
        /// <value>Indicates if the project is marked as favorite</value>
        [DataMember(Name = "isFavorite", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Number of test cases in the project
        /// </summary>
        /// <value>Number of test cases in the project</value>
        [DataMember(Name = "testCasesCount", EmitDefaultValue = true)]
        public int? TestCasesCount { get; set; }

        /// <summary>
        /// Number of shared steps in the project
        /// </summary>
        /// <value>Number of shared steps in the project</value>
        [DataMember(Name = "sharedStepsCount", EmitDefaultValue = true)]
        public int? SharedStepsCount { get; set; }

        /// <summary>
        /// Number of checklists in the project
        /// </summary>
        /// <value>Number of checklists in the project</value>
        [DataMember(Name = "checkListsCount", EmitDefaultValue = true)]
        public int? CheckListsCount { get; set; }

        /// <summary>
        /// Number of autotests in the project
        /// </summary>
        /// <value>Number of autotests in the project</value>
        [DataMember(Name = "autoTestsCount", EmitDefaultValue = true)]
        public int? AutoTestsCount { get; set; }

        /// <summary>
        /// Indicates if the project is deleted
        /// </summary>
        /// <value>Indicates if the project is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Creation date of the project
        /// </summary>
        /// <value>Creation date of the project</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last modification date of the project
        /// </summary>
        /// <value>Last modification date of the project</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Unique ID of the project creator
        /// </summary>
        /// <value>Unique ID of the project creator</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique ID of the project last editor
        /// </summary>
        /// <value>Unique ID of the project last editor</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Global ID of the project
        /// </summary>
        /// <value>Global ID of the project</value>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically
        /// </summary>
        /// <value>Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically</value>
        [DataMember(Name = "isFlakyAuto", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public bool IsFlakyAuto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectShortModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  TestCasesCount: ").Append(TestCasesCount).Append("\n");
            sb.Append("  SharedStepsCount: ").Append(SharedStepsCount).Append("\n");
            sb.Append("  CheckListsCount: ").Append(CheckListsCount).Append("\n");
            sb.Append("  AutoTestsCount: ").Append(AutoTestsCount).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsFlakyAuto: ").Append(IsFlakyAuto).Append("\n");
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
