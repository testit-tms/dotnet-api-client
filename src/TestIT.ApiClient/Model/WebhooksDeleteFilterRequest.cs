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
    /// WebhooksDeleteFilterRequest
    /// </summary>
    [DataContract(Name = "WebhooksDeleteFilterRequest")]
    public partial class WebhooksDeleteFilterRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDeleteFilterRequest" /> class.
        /// </summary>
        /// <param name="name">Specifies a webhook name to search for.</param>
        /// <param name="eventTypes">Specifies a webhook event types to search for.</param>
        /// <param name="methods">Specifies a webhook methods to search for.</param>
        /// <param name="projectIds">Specifies a webhook project IDs to search for.</param>
        /// <param name="isEnabled">Specifies a webhook deleted status to search for.</param>
        public WebhooksDeleteFilterRequest(string name = default(string), List<WebHookEventTypeRequest> eventTypes = default(List<WebHookEventTypeRequest>), List<RequestTypeRequest> methods = default(List<RequestTypeRequest>), List<Guid> projectIds = default(List<Guid>), bool? isEnabled = default(bool?))
        {
            this.Name = name;
            this.EventTypes = eventTypes;
            this.Methods = methods;
            this.ProjectIds = projectIds;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Specifies a webhook name to search for
        /// </summary>
        /// <value>Specifies a webhook name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a webhook event types to search for
        /// </summary>
        /// <value>Specifies a webhook event types to search for</value>
        [DataMember(Name = "eventTypes", EmitDefaultValue = true)]
        public List<WebHookEventTypeRequest> EventTypes { get; set; }

        /// <summary>
        /// Specifies a webhook methods to search for
        /// </summary>
        /// <value>Specifies a webhook methods to search for</value>
        [DataMember(Name = "methods", EmitDefaultValue = true)]
        public List<RequestTypeRequest> Methods { get; set; }

        /// <summary>
        /// Specifies a webhook project IDs to search for
        /// </summary>
        /// <value>Specifies a webhook project IDs to search for</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Specifies a webhook deleted status to search for
        /// </summary>
        /// <value>Specifies a webhook deleted status to search for</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksDeleteFilterRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
