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
    /// WorkItemChangedFieldsViewModelGlobalId
    /// </summary>
    [DataContract(Name = "WorkItemChangedFieldsViewModel_globalId")]
    public partial class WorkItemChangedFieldsViewModelGlobalId : IEquatable<WorkItemChangedFieldsViewModelGlobalId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModelGlobalId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemChangedFieldsViewModelGlobalId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModelGlobalId" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue (required).</param>
        /// <param name="newValue">newValue (required).</param>
        public WorkItemChangedFieldsViewModelGlobalId(long oldValue = default(long), long newValue = default(long))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", IsRequired = true, EmitDefaultValue = true)]
        public long OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", IsRequired = true, EmitDefaultValue = true)]
        public long NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangedFieldsViewModelGlobalId {\n");
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
            return this.Equals(input as WorkItemChangedFieldsViewModelGlobalId);
        }

        /// <summary>
        /// Returns true if WorkItemChangedFieldsViewModelGlobalId instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangedFieldsViewModelGlobalId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangedFieldsViewModelGlobalId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OldValue == input.OldValue ||
                    this.OldValue.Equals(input.OldValue)
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    this.NewValue.Equals(input.NewValue)
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
                hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
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
