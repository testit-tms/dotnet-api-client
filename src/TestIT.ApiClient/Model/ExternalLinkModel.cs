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
    /// ExternalLinkModel
    /// </summary>
    [DataContract(Name = "ExternalLinkModel")]
    public partial class ExternalLinkModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLinkModel" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="title">title.</param>
        /// <param name="issueTypeName">issueTypeName.</param>
        /// <param name="issueTypeIconUrl">issueTypeIconUrl.</param>
        /// <param name="priorityName">priorityName.</param>
        /// <param name="priorityIconUrl">priorityIconUrl.</param>
        /// <param name="statusName">statusName.</param>
        /// <param name="assigneeDisplayName">assigneeDisplayName.</param>
        public ExternalLinkModel(string url = default(string), string title = default(string), string issueTypeName = default(string), string issueTypeIconUrl = default(string), string priorityName = default(string), string priorityIconUrl = default(string), string statusName = default(string), string assigneeDisplayName = default(string))
        {
            this.Url = url;
            this.Title = title;
            this.IssueTypeName = issueTypeName;
            this.IssueTypeIconUrl = issueTypeIconUrl;
            this.PriorityName = priorityName;
            this.PriorityIconUrl = priorityIconUrl;
            this.StatusName = statusName;
            this.AssigneeDisplayName = assigneeDisplayName;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets IssueTypeName
        /// </summary>
        [DataMember(Name = "issueTypeName", EmitDefaultValue = true)]
        public string IssueTypeName { get; set; }

        /// <summary>
        /// Gets or Sets IssueTypeIconUrl
        /// </summary>
        [DataMember(Name = "issueTypeIconUrl", EmitDefaultValue = true)]
        public string IssueTypeIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets PriorityName
        /// </summary>
        [DataMember(Name = "priorityName", EmitDefaultValue = true)]
        public string PriorityName { get; set; }

        /// <summary>
        /// Gets or Sets PriorityIconUrl
        /// </summary>
        [DataMember(Name = "priorityIconUrl", EmitDefaultValue = true)]
        public string PriorityIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets StatusName
        /// </summary>
        [DataMember(Name = "statusName", EmitDefaultValue = true)]
        public string StatusName { get; set; }

        /// <summary>
        /// Gets or Sets AssigneeDisplayName
        /// </summary>
        [DataMember(Name = "assigneeDisplayName", EmitDefaultValue = true)]
        public string AssigneeDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalLinkModel {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IssueTypeName: ").Append(IssueTypeName).Append("\n");
            sb.Append("  IssueTypeIconUrl: ").Append(IssueTypeIconUrl).Append("\n");
            sb.Append("  PriorityName: ").Append(PriorityName).Append("\n");
            sb.Append("  PriorityIconUrl: ").Append(PriorityIconUrl).Append("\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  AssigneeDisplayName: ").Append(AssigneeDisplayName).Append("\n");
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
