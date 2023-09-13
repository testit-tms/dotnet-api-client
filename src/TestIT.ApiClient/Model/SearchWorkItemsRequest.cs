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
    /// SearchWorkItemsRequest
    /// </summary>
    [DataContract(Name = "SearchWorkItems_request")]
    public partial class SearchWorkItemsRequest : IEquatable<SearchWorkItemsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWorkItemsRequest" /> class.
        /// </summary>
        /// <param name="tagNames">Collection of tags.</param>
        /// <param name="entityTypes">Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;.</param>
        /// <param name="nameOrId">Name or identifier (UUID) of work item.</param>
        /// <param name="includeIds">Collection of identifiers of work items which need to be included in result regardless of filtering.</param>
        /// <param name="excludeIds">Collection of identifiers of work items which need to be excluded from result regardless of filtering.</param>
        /// <param name="name">Name of work item.</param>
        /// <param name="ids">Specifies a work item unique IDs to search for.</param>
        /// <param name="globalIds">Collection of global (integer) identifiers.</param>
        /// <param name="attributes">Custom attributes of work item.</param>
        /// <param name="isDeleted">Is result must consist of only actual/deleted work items.</param>
        /// <param name="projectIds">Collection of project identifiers.</param>
        /// <param name="sectionIds">Collection of section identifiers.</param>
        /// <param name="createdByIds">Collection of identifiers of users who created work item.</param>
        /// <param name="modifiedByIds">Collection of identifiers of users who applied last modification to work item.</param>
        /// <param name="states">Collection of states of work item.</param>
        /// <param name="priorities">Collection of priorities of work item.</param>
        /// <param name="types">Collection of types of work item.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="duration">duration.</param>
        /// <param name="medianDuration">medianDuration.</param>
        /// <param name="isAutomated">Is result must consist of only manual/automated work items.</param>
        /// <param name="tags">Collection of tags.</param>
        /// <param name="autoTestIds">Collection of identifiers of linked autotests.</param>
        public SearchWorkItemsRequest(List<string> tagNames = default(List<string>), List<WorkItemEntityTypes> entityTypes = default(List<WorkItemEntityTypes>), string nameOrId = default(string), List<Guid> includeIds = default(List<Guid>), List<Guid> excludeIds = default(List<Guid>), string name = default(string), List<Guid> ids = default(List<Guid>), List<long> globalIds = default(List<long>), Dictionary<string, List<string>> attributes = default(Dictionary<string, List<string>>), bool? isDeleted = default(bool?), List<Guid> projectIds = default(List<Guid>), List<Guid> sectionIds = default(List<Guid>), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), List<WorkItemStates> states = default(List<WorkItemStates>), List<WorkItemPriorityModel> priorities = default(List<WorkItemPriorityModel>), List<WorkItemEntityTypes> types = default(List<WorkItemEntityTypes>), TestPointFilterModelWorkItemCreatedDate createdDate = default(TestPointFilterModelWorkItemCreatedDate), TestPointFilterModelWorkItemModifiedDate modifiedDate = default(TestPointFilterModelWorkItemModifiedDate), TestSuiteWorkItemsSearchModelDuration duration = default(TestSuiteWorkItemsSearchModelDuration), TestSuiteWorkItemsSearchModelMedianDuration medianDuration = default(TestSuiteWorkItemsSearchModelMedianDuration), bool? isAutomated = default(bool?), List<string> tags = default(List<string>), List<Guid> autoTestIds = default(List<Guid>))
        {
            this.TagNames = tagNames;
            this.EntityTypes = entityTypes;
            this.NameOrId = nameOrId;
            this.IncludeIds = includeIds;
            this.ExcludeIds = excludeIds;
            this.Name = name;
            this.Ids = ids;
            this.GlobalIds = globalIds;
            this.Attributes = attributes;
            this.IsDeleted = isDeleted;
            this.ProjectIds = projectIds;
            this.SectionIds = sectionIds;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.States = states;
            this.Priorities = priorities;
            this.Types = types;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.Duration = duration;
            this.MedianDuration = medianDuration;
            this.IsAutomated = isAutomated;
            this.Tags = tags;
            this.AutoTestIds = autoTestIds;
        }

        /// <summary>
        /// Collection of tags
        /// </summary>
        /// <value>Collection of tags</value>
        [DataMember(Name = "tagNames", EmitDefaultValue = true)]
        [Obsolete]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;
        /// </summary>
        /// <value>Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;</value>
        [DataMember(Name = "entityTypes", EmitDefaultValue = true)]
        [Obsolete]
        public List<WorkItemEntityTypes> EntityTypes { get; set; }

        /// <summary>
        /// Name or identifier (UUID) of work item
        /// </summary>
        /// <value>Name or identifier (UUID) of work item</value>
        [DataMember(Name = "nameOrId", EmitDefaultValue = true)]
        public string NameOrId { get; set; }

        /// <summary>
        /// Collection of identifiers of work items which need to be included in result regardless of filtering
        /// </summary>
        /// <value>Collection of identifiers of work items which need to be included in result regardless of filtering</value>
        [DataMember(Name = "includeIds", EmitDefaultValue = true)]
        public List<Guid> IncludeIds { get; set; }

        /// <summary>
        /// Collection of identifiers of work items which need to be excluded from result regardless of filtering
        /// </summary>
        /// <value>Collection of identifiers of work items which need to be excluded from result regardless of filtering</value>
        [DataMember(Name = "excludeIds", EmitDefaultValue = true)]
        public List<Guid> ExcludeIds { get; set; }

        /// <summary>
        /// Name of work item
        /// </summary>
        /// <value>Name of work item</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a work item unique IDs to search for
        /// </summary>
        /// <value>Specifies a work item unique IDs to search for</value>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public List<Guid> Ids { get; set; }

        /// <summary>
        /// Collection of global (integer) identifiers
        /// </summary>
        /// <value>Collection of global (integer) identifiers</value>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Custom attributes of work item
        /// </summary>
        /// <value>Custom attributes of work item</value>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Attributes { get; set; }

        /// <summary>
        /// Is result must consist of only actual/deleted work items
        /// </summary>
        /// <value>Is result must consist of only actual/deleted work items</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Collection of project identifiers
        /// </summary>
        /// <value>Collection of project identifiers</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Collection of section identifiers
        /// </summary>
        /// <value>Collection of section identifiers</value>
        [DataMember(Name = "sectionIds", EmitDefaultValue = true)]
        public List<Guid> SectionIds { get; set; }

        /// <summary>
        /// Collection of identifiers of users who created work item
        /// </summary>
        /// <value>Collection of identifiers of users who created work item</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Collection of identifiers of users who applied last modification to work item
        /// </summary>
        /// <value>Collection of identifiers of users who applied last modification to work item</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Collection of states of work item
        /// </summary>
        /// <value>Collection of states of work item</value>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<WorkItemStates> States { get; set; }

        /// <summary>
        /// Collection of priorities of work item
        /// </summary>
        /// <value>Collection of priorities of work item</value>
        [DataMember(Name = "priorities", EmitDefaultValue = true)]
        public List<WorkItemPriorityModel> Priorities { get; set; }

        /// <summary>
        /// Collection of types of work item
        /// </summary>
        /// <value>Collection of types of work item</value>
        [DataMember(Name = "types", EmitDefaultValue = true)]
        public List<WorkItemEntityTypes> Types { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public TestPointFilterModelWorkItemCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public TestPointFilterModelWorkItemModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public TestSuiteWorkItemsSearchModelDuration Duration { get; set; }

        /// <summary>
        /// Gets or Sets MedianDuration
        /// </summary>
        [DataMember(Name = "medianDuration", EmitDefaultValue = true)]
        public TestSuiteWorkItemsSearchModelMedianDuration MedianDuration { get; set; }

        /// <summary>
        /// Is result must consist of only manual/automated work items
        /// </summary>
        /// <value>Is result must consist of only manual/automated work items</value>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool? IsAutomated { get; set; }

        /// <summary>
        /// Collection of tags
        /// </summary>
        /// <value>Collection of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Collection of identifiers of linked autotests
        /// </summary>
        /// <value>Collection of identifiers of linked autotests</value>
        [DataMember(Name = "autoTestIds", EmitDefaultValue = true)]
        public List<Guid> AutoTestIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchWorkItemsRequest {\n");
            sb.Append("  TagNames: ").Append(TagNames).Append("\n");
            sb.Append("  EntityTypes: ").Append(EntityTypes).Append("\n");
            sb.Append("  NameOrId: ").Append(NameOrId).Append("\n");
            sb.Append("  IncludeIds: ").Append(IncludeIds).Append("\n");
            sb.Append("  ExcludeIds: ").Append(ExcludeIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  SectionIds: ").Append(SectionIds).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  MedianDuration: ").Append(MedianDuration).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  AutoTestIds: ").Append(AutoTestIds).Append("\n");
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
            return this.Equals(input as SearchWorkItemsRequest);
        }

        /// <summary>
        /// Returns true if SearchWorkItemsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchWorkItemsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchWorkItemsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
                ) &&
                (
                    this.EntityTypes == input.EntityTypes ||
                    this.EntityTypes != null &&
                    input.EntityTypes != null &&
                    this.EntityTypes.SequenceEqual(input.EntityTypes)
                ) &&
                (
                    this.NameOrId == input.NameOrId ||
                    (this.NameOrId != null &&
                    this.NameOrId.Equals(input.NameOrId))
                ) &&
                (
                    this.IncludeIds == input.IncludeIds ||
                    this.IncludeIds != null &&
                    input.IncludeIds != null &&
                    this.IncludeIds.SequenceEqual(input.IncludeIds)
                ) &&
                (
                    this.ExcludeIds == input.ExcludeIds ||
                    this.ExcludeIds != null &&
                    input.ExcludeIds != null &&
                    this.ExcludeIds.SequenceEqual(input.ExcludeIds)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) &&
                (
                    this.GlobalIds == input.GlobalIds ||
                    this.GlobalIds != null &&
                    input.GlobalIds != null &&
                    this.GlobalIds.SequenceEqual(input.GlobalIds)
                ) &&
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) &&
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) &&
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) &&
                (
                    this.SectionIds == input.SectionIds ||
                    this.SectionIds != null &&
                    input.SectionIds != null &&
                    this.SectionIds.SequenceEqual(input.SectionIds)
                ) &&
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) &&
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
                ) &&
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) &&
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
                ) &&
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) &&
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) &&
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) &&
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) &&
                (
                    this.MedianDuration == input.MedianDuration ||
                    (this.MedianDuration != null &&
                    this.MedianDuration.Equals(input.MedianDuration))
                ) &&
                (
                    this.IsAutomated == input.IsAutomated ||
                    (this.IsAutomated != null &&
                    this.IsAutomated.Equals(input.IsAutomated))
                ) &&
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) &&
                (
                    this.AutoTestIds == input.AutoTestIds ||
                    this.AutoTestIds != null &&
                    input.AutoTestIds != null &&
                    this.AutoTestIds.SequenceEqual(input.AutoTestIds)
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
                if (this.TagNames != null)
                {
                    hashCode = (hashCode * 59) + this.TagNames.GetHashCode();
                }
                if (this.EntityTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypes.GetHashCode();
                }
                if (this.NameOrId != null)
                {
                    hashCode = (hashCode * 59) + this.NameOrId.GetHashCode();
                }
                if (this.IncludeIds != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeIds.GetHashCode();
                }
                if (this.ExcludeIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.GlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalIds.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
                }
                if (this.SectionIds != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIds.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.MedianDuration != null)
                {
                    hashCode = (hashCode * 59) + this.MedianDuration.GetHashCode();
                }
                if (this.IsAutomated != null)
                {
                    hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.AutoTestIds != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestIds.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}