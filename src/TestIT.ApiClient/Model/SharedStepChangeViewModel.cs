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
    /// SharedStepChangeViewModel
    /// </summary>
    [DataContract(Name = "SharedStepChangeViewModel")]
    public partial class SharedStepChangeViewModel : IEquatable<SharedStepChangeViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepChangeViewModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharedStepChangeViewModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepChangeViewModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="steps">steps (required).</param>
        public SharedStepChangeViewModel(Guid id = default(Guid), long globalId = default(long), string name = default(string), List<WorkItemStepChangeViewModel> steps = default(List<WorkItemStepChangeViewModel>))
        {
            this.Id = id;
            this.GlobalId = globalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SharedStepChangeViewModel and cannot be null");
            }
            this.Name = name;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for SharedStepChangeViewModel and cannot be null");
            }
            this.Steps = steps;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<WorkItemStepChangeViewModel> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepChangeViewModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
            return this.Equals(input as SharedStepChangeViewModel);
        }

        /// <summary>
        /// Returns true if SharedStepChangeViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedStepChangeViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedStepChangeViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
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
