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
    /// ExternalFormFieldModel
    /// </summary>
    [DataContract(Name = "ExternalFormFieldModel")]
    public partial class ExternalFormFieldModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFormFieldModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalFormFieldModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFormFieldModel" /> class.
        /// </summary>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="helpText">helpText.</param>
        /// <param name="type">type.</param>
        /// <param name="arrayValuesType">arrayValuesType.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="isCustomValueAllowed">isCustomValueAllowed (required).</param>
        /// <param name="autoCompleteUrl">autoCompleteUrl.</param>
        /// <param name="controlType">controlType.</param>
        /// <param name="minLength">minLength.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        public ExternalFormFieldModel(string fieldId = default(string), string fieldName = default(string), string helpText = default(string), string type = default(string), string arrayValuesType = default(string), Object defaultValue = default(Object), bool isCustomValueAllowed = default(bool), string autoCompleteUrl = default(string), string controlType = default(string), int? minLength = default(int?), int? maxLength = default(int?), bool? isRequired = default(bool?), Object min = default(Object), Object max = default(Object))
        {
            this.IsCustomValueAllowed = isCustomValueAllowed;
            this.FieldId = fieldId;
            this.FieldName = fieldName;
            this.HelpText = helpText;
            this.Type = type;
            this.ArrayValuesType = arrayValuesType;
            this.DefaultValue = defaultValue;
            this.AutoCompleteUrl = autoCompleteUrl;
            this.ControlType = controlType;
            this.MinLength = minLength;
            this.MaxLength = maxLength;
            this.IsRequired = isRequired;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = true)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "helpText", EmitDefaultValue = true)]
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ArrayValuesType
        /// </summary>
        [DataMember(Name = "arrayValuesType", EmitDefaultValue = true)]
        public string ArrayValuesType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "defaultValue", EmitDefaultValue = true)]
        public Object DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets IsCustomValueAllowed
        /// </summary>
        [DataMember(Name = "isCustomValueAllowed", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCustomValueAllowed { get; set; }

        /// <summary>
        /// Gets or Sets AutoCompleteUrl
        /// </summary>
        [DataMember(Name = "autoCompleteUrl", EmitDefaultValue = true)]
        public string AutoCompleteUrl { get; set; }

        /// <summary>
        /// Gets or Sets ControlType
        /// </summary>
        [DataMember(Name = "controlType", EmitDefaultValue = true)]
        public string ControlType { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name = "minLength", EmitDefaultValue = true)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = true)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name = "isRequired", EmitDefaultValue = true)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", EmitDefaultValue = true)]
        public Object Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", EmitDefaultValue = true)]
        public Object Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalFormFieldModel {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ArrayValuesType: ").Append(ArrayValuesType).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  IsCustomValueAllowed: ").Append(IsCustomValueAllowed).Append("\n");
            sb.Append("  AutoCompleteUrl: ").Append(AutoCompleteUrl).Append("\n");
            sb.Append("  ControlType: ").Append(ControlType).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
