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
    /// AutotestsSelectModel
    /// </summary>
    [DataContract(Name = "AutotestsSelectModel")]
    public partial class AutotestsSelectModel : IEquatable<AutotestsSelectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestsSelectModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutotestsSelectModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestsSelectModel" /> class.
        /// </summary>
        /// <param name="filter">filter (required).</param>
        /// <param name="includes">includes (required).</param>
        public AutotestsSelectModel(AutotestsSelectModelFilter filter = default(AutotestsSelectModelFilter), AutotestsSelectModelIncludes includes = default(AutotestsSelectModelIncludes))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for AutotestsSelectModel and cannot be null");
            }
            this.Filter = filter;
            // to ensure "includes" is required (not null)
            if (includes == null)
            {
                throw new ArgumentNullException("includes is a required property for AutotestsSelectModel and cannot be null");
            }
            this.Includes = includes;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public AutotestsSelectModelFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [DataMember(Name = "includes", IsRequired = true, EmitDefaultValue = true)]
        public AutotestsSelectModelIncludes Includes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutotestsSelectModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
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
            return this.Equals(input as AutotestsSelectModel);
        }

        /// <summary>
        /// Returns true if AutotestsSelectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutotestsSelectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutotestsSelectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Includes == input.Includes ||
                    (this.Includes != null &&
                    this.Includes.Equals(input.Includes))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Includes != null)
                {
                    hashCode = (hashCode * 59) + this.Includes.GetHashCode();
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
