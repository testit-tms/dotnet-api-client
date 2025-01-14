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
    /// AutoTestResultReasonShort
    /// </summary>
    [DataContract(Name = "AutoTestResultReasonShort")]
    public partial class AutoTestResultReasonShort : IEquatable<AutoTestResultReasonShort>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FailureCategory
        /// </summary>
        [DataMember(Name = "failureCategory", IsRequired = true, EmitDefaultValue = true)]
        public FailureCategoryModel FailureCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultReasonShort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestResultReasonShort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultReasonShort" /> class.
        /// </summary>
        /// <param name="failureCategory">failureCategory (required).</param>
        /// <param name="name">name (required).</param>
        public AutoTestResultReasonShort(FailureCategoryModel failureCategory = default(FailureCategoryModel), string name = default(string))
        {
            this.FailureCategory = failureCategory;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutoTestResultReasonShort and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestResultReasonShort {\n");
            sb.Append("  FailureCategory: ").Append(FailureCategory).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AutoTestResultReasonShort);
        }

        /// <summary>
        /// Returns true if AutoTestResultReasonShort instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestResultReasonShort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestResultReasonShort input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailureCategory == input.FailureCategory ||
                    this.FailureCategory.Equals(input.FailureCategory)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.FailureCategory.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
