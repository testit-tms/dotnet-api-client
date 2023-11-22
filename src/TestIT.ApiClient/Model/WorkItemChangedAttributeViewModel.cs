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
using FileParameter = TestIt.ApiClient.Client.FileParameter;
using OpenAPIDateConverter = TestIt.ApiClient.Client.OpenAPIDateConverter;

namespace TestIt.ApiClient.Model
{
    /// <summary>
    /// WorkItemChangedAttributeViewModel
    /// </summary>
    [DataContract(Name = "WorkItemChangedAttributeViewModel")]
    public partial class WorkItemChangedAttributeViewModel : IEquatable<WorkItemChangedAttributeViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedAttributeViewModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemChangedAttributeViewModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedAttributeViewModel" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="oldAttributeName">oldAttributeName (required).</param>
        /// <param name="newAttributeName">newAttributeName (required).</param>
        /// <param name="oldValue">oldValue (required).</param>
        /// <param name="newValue">newValue (required).</param>
        public WorkItemChangedAttributeViewModel(string type = default(string), string oldAttributeName = default(string), string newAttributeName = default(string), Object oldValue = default(Object), Object newValue = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for WorkItemChangedAttributeViewModel and cannot be null");
            }
            this.Type = type;
            // to ensure "oldAttributeName" is required (not null)
            if (oldAttributeName == null)
            {
                throw new ArgumentNullException("oldAttributeName is a required property for WorkItemChangedAttributeViewModel and cannot be null");
            }
            this.OldAttributeName = oldAttributeName;
            // to ensure "newAttributeName" is required (not null)
            if (newAttributeName == null)
            {
                throw new ArgumentNullException("newAttributeName is a required property for WorkItemChangedAttributeViewModel and cannot be null");
            }
            this.NewAttributeName = newAttributeName;
            // to ensure "oldValue" is required (not null)
            if (oldValue == null)
            {
                throw new ArgumentNullException("oldValue is a required property for WorkItemChangedAttributeViewModel and cannot be null");
            }
            this.OldValue = oldValue;
            // to ensure "newValue" is required (not null)
            if (newValue == null)
            {
                throw new ArgumentNullException("newValue is a required property for WorkItemChangedAttributeViewModel and cannot be null");
            }
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets OldAttributeName
        /// </summary>
        [DataMember(Name = "oldAttributeName", IsRequired = true, EmitDefaultValue = true)]
        public string OldAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets NewAttributeName
        /// </summary>
        [DataMember(Name = "newAttributeName", IsRequired = true, EmitDefaultValue = true)]
        public string NewAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", IsRequired = true, EmitDefaultValue = true)]
        public Object OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", IsRequired = true, EmitDefaultValue = true)]
        public Object NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangedAttributeViewModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OldAttributeName: ").Append(OldAttributeName).Append("\n");
            sb.Append("  NewAttributeName: ").Append(NewAttributeName).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
            return this.Equals(input as WorkItemChangedAttributeViewModel);
        }

        /// <summary>
        /// Returns true if WorkItemChangedAttributeViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangedAttributeViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangedAttributeViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.OldAttributeName == input.OldAttributeName ||
                    (this.OldAttributeName != null &&
                    this.OldAttributeName.Equals(input.OldAttributeName))
                ) && 
                (
                    this.NewAttributeName == input.NewAttributeName ||
                    (this.NewAttributeName != null &&
                    this.NewAttributeName.Equals(input.NewAttributeName))
                ) && 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.OldAttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.OldAttributeName.GetHashCode();
                }
                if (this.NewAttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.NewAttributeName.GetHashCode();
                }
                if (this.OldValue != null)
                {
                    hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                }
                if (this.NewValue != null)
                {
                    hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
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
