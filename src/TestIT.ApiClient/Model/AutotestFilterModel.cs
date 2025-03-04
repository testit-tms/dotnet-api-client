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
    /// AutoTestFilterModel
    /// </summary>
    [DataContract(Name = "AutoTestFilterModel")]
    public partial class AutoTestFilterModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LastTestResultOutcome
        /// </summary>
        [DataMember(Name = "lastTestResultOutcome", EmitDefaultValue = true)]
        public AutotestResultOutcome? LastTestResultOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestFilterModel" /> class.
        /// </summary>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="externalIds">externalIds.</param>
        /// <param name="globalIds">globalIds.</param>
        /// <param name="name">name.</param>
        /// <param name="isFlaky">isFlaky.</param>
        /// <param name="mustBeApproved">mustBeApproved.</param>
        /// <param name="stabilityPercentage">stabilityPercentage.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdByIds">createdByIds.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedByIds">modifiedByIds.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="isEmptyNamespace">isEmptyNamespace.</param>
        /// <param name="className">className.</param>
        /// <param name="isEmptyClassName">isEmptyClassName.</param>
        /// <param name="lastTestResultOutcome">lastTestResultOutcome.</param>
        /// <param name="lastTestResultStatusCode">lastTestResultStatusCode.</param>
        /// <param name="externalKey">externalKey.</param>
        /// <param name="lastTestResultConfigurationIds">lastTestResultConfigurationIds.</param>
        public AutoTestFilterModel(List<Guid> projectIds = default(List<Guid>), List<string> externalIds = default(List<string>), List<long> globalIds = default(List<long>), string name = default(string), bool? isFlaky = default(bool?), bool? mustBeApproved = default(bool?), Int64RangeSelectorModel stabilityPercentage = default(Int64RangeSelectorModel), DateTimeRangeSelectorModel createdDate = default(DateTimeRangeSelectorModel), List<Guid> createdByIds = default(List<Guid>), DateTimeRangeSelectorModel modifiedDate = default(DateTimeRangeSelectorModel), List<Guid> modifiedByIds = default(List<Guid>), bool? isDeleted = default(bool?), string varNamespace = default(string), bool? isEmptyNamespace = default(bool?), string className = default(string), bool? isEmptyClassName = default(bool?), AutotestResultOutcome? lastTestResultOutcome = default(AutotestResultOutcome?), string lastTestResultStatusCode = default(string), string externalKey = default(string), List<Guid> lastTestResultConfigurationIds = default(List<Guid>))
        {
            this.ProjectIds = projectIds;
            this.ExternalIds = externalIds;
            this.GlobalIds = globalIds;
            this.Name = name;
            this.IsFlaky = isFlaky;
            this.MustBeApproved = mustBeApproved;
            this.StabilityPercentage = stabilityPercentage;
            this.CreatedDate = createdDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedDate = modifiedDate;
            this.ModifiedByIds = modifiedByIds;
            this.IsDeleted = isDeleted;
            this.Namespace = varNamespace;
            this.IsEmptyNamespace = isEmptyNamespace;
            this.ClassName = className;
            this.IsEmptyClassName = isEmptyClassName;
            this.LastTestResultOutcome = lastTestResultOutcome;
            this.LastTestResultStatusCode = lastTestResultStatusCode;
            this.ExternalKey = externalKey;
            this.LastTestResultConfigurationIds = lastTestResultConfigurationIds;
        }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIds
        /// </summary>
        [DataMember(Name = "externalIds", EmitDefaultValue = true)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// Gets or Sets GlobalIds
        /// </summary>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsFlaky
        /// </summary>
        [DataMember(Name = "isFlaky", EmitDefaultValue = true)]
        public bool? IsFlaky { get; set; }

        /// <summary>
        /// Gets or Sets MustBeApproved
        /// </summary>
        [DataMember(Name = "mustBeApproved", EmitDefaultValue = true)]
        public bool? MustBeApproved { get; set; }

        /// <summary>
        /// Gets or Sets StabilityPercentage
        /// </summary>
        [DataMember(Name = "stabilityPercentage", EmitDefaultValue = true)]
        public Int64RangeSelectorModel StabilityPercentage { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByIds
        /// </summary>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByIds
        /// </summary>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets IsEmptyNamespace
        /// </summary>
        [DataMember(Name = "isEmptyNamespace", EmitDefaultValue = true)]
        public bool? IsEmptyNamespace { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets IsEmptyClassName
        /// </summary>
        [DataMember(Name = "isEmptyClassName", EmitDefaultValue = true)]
        public bool? IsEmptyClassName { get; set; }

        /// <summary>
        /// Gets or Sets LastTestResultStatusCode
        /// </summary>
        [DataMember(Name = "lastTestResultStatusCode", EmitDefaultValue = true)]
        public string LastTestResultStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets ExternalKey
        /// </summary>
        [DataMember(Name = "externalKey", EmitDefaultValue = true)]
        public string ExternalKey { get; set; }

        /// <summary>
        /// Gets or Sets LastTestResultConfigurationIds
        /// </summary>
        [DataMember(Name = "lastTestResultConfigurationIds", EmitDefaultValue = true)]
        public List<Guid> LastTestResultConfigurationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestFilterModel {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  MustBeApproved: ").Append(MustBeApproved).Append("\n");
            sb.Append("  StabilityPercentage: ").Append(StabilityPercentage).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  IsEmptyNamespace: ").Append(IsEmptyNamespace).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  IsEmptyClassName: ").Append(IsEmptyClassName).Append("\n");
            sb.Append("  LastTestResultOutcome: ").Append(LastTestResultOutcome).Append("\n");
            sb.Append("  LastTestResultStatusCode: ").Append(LastTestResultStatusCode).Append("\n");
            sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
            sb.Append("  LastTestResultConfigurationIds: ").Append(LastTestResultConfigurationIds).Append("\n");
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
