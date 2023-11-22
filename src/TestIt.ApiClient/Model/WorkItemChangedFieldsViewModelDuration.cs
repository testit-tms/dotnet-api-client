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
    /// WorkItemChangedFieldsViewModelDuration
    /// </summary>
    [DataContract(Name = "WorkItemChangedFieldsViewModel_duration")]
    public partial class WorkItemChangedFieldsViewModelDuration : IEquatable<WorkItemChangedFieldsViewModelDuration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModelDuration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemChangedFieldsViewModelDuration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModelDuration" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue (required).</param>
        /// <param name="newValue">newValue (required).</param>
        public WorkItemChangedFieldsViewModelDuration(int oldValue = default(int), int newValue = default(int))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", IsRequired = true, EmitDefaultValue = true)]
        public int OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", IsRequired = true, EmitDefaultValue = true)]
        public int NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangedFieldsViewModelDuration {\n");
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
            return this.Equals(input as WorkItemChangedFieldsViewModelDuration);
        }

        /// <summary>
        /// Returns true if WorkItemChangedFieldsViewModelDuration instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangedFieldsViewModelDuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangedFieldsViewModelDuration input)
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
