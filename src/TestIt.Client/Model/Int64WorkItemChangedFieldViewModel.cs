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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// Int64WorkItemChangedFieldViewModel
    /// </summary>
    [DataContract(Name = "Int64WorkItemChangedFieldViewModel")]
    public partial class Int64WorkItemChangedFieldViewModel : IEquatable<Int64WorkItemChangedFieldViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Int64WorkItemChangedFieldViewModel" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        public Int64WorkItemChangedFieldViewModel(long oldValue = default(long), long newValue = default(long))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = false)]
        public long OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = false)]
        public long NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Int64WorkItemChangedFieldViewModel {\n");
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
            return this.Equals(input as Int64WorkItemChangedFieldViewModel);
        }

        /// <summary>
        /// Returns true if Int64WorkItemChangedFieldViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of Int64WorkItemChangedFieldViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Int64WorkItemChangedFieldViewModel input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
