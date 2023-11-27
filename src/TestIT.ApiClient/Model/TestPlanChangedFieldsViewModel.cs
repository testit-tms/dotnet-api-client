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
    /// TestPlanChangedFieldsViewModel
    /// </summary>
    [DataContract(Name = "TestPlanChangedFieldsViewModel")]
    public partial class TestPlanChangedFieldsViewModel : IEquatable<TestPlanChangedFieldsViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanChangedFieldsViewModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="productName">productName.</param>
        /// <param name="build">build.</param>
        /// <param name="period">period.</param>
        /// <param name="status">status.</param>
        /// <param name="tags">tags.</param>
        /// <param name="testSuite">testSuite.</param>
        /// <param name="testPoints">testPoints.</param>
        /// <param name="testResults">testResults.</param>
        /// <param name="locking">locking.</param>
        /// <param name="hasAutomaticDurationTimer">hasAutomaticDurationTimer.</param>
        /// <param name="attributes">attributes.</param>
        public TestPlanChangedFieldsViewModel(StringChangedFieldWithDiffsViewModel name = default(StringChangedFieldWithDiffsViewModel), StringChangedFieldWithDiffsViewModel description = default(StringChangedFieldWithDiffsViewModel), StringChangedFieldViewModel productName = default(StringChangedFieldViewModel), StringChangedFieldViewModel build = default(StringChangedFieldViewModel), PeriodViewModelChangedFieldViewModel period = default(PeriodViewModelChangedFieldViewModel), StringChangedFieldViewModel status = default(StringChangedFieldViewModel), StringArrayChangedFieldViewModel tags = default(StringArrayChangedFieldViewModel), TestSuiteChangeViewModelChangedFieldViewModel testSuite = default(TestSuiteChangeViewModelChangedFieldViewModel), TestPointChangeViewModelChangedFieldViewModel testPoints = default(TestPointChangeViewModelChangedFieldViewModel), TestResultChangeViewModelChangedFieldViewModel testResults = default(TestResultChangeViewModelChangedFieldViewModel), BooleanChangedFieldViewModel locking = default(BooleanChangedFieldViewModel), BooleanNullableChangedFieldViewModel hasAutomaticDurationTimer = default(BooleanNullableChangedFieldViewModel), Dictionary<string, CustomAttributeChangeModel> attributes = default(Dictionary<string, CustomAttributeChangeModel>))
        {
            this.Name = name;
            this.Description = description;
            this.ProductName = productName;
            this.Build = build;
            this.Period = period;
            this.Status = status;
            this.Tags = tags;
            this.TestSuite = testSuite;
            this.TestPoints = testPoints;
            this.TestResults = testResults;
            this.Locking = locking;
            this.HasAutomaticDurationTimer = hasAutomaticDurationTimer;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public StringChangedFieldWithDiffsViewModel Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public StringChangedFieldWithDiffsViewModel Description { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "productName", EmitDefaultValue = true)]
        public StringChangedFieldViewModel ProductName { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name = "build", EmitDefaultValue = true)]
        public StringChangedFieldViewModel Build { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = true)]
        public PeriodViewModelChangedFieldViewModel Period { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StringChangedFieldViewModel Status { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public StringArrayChangedFieldViewModel Tags { get; set; }

        /// <summary>
        /// Gets or Sets TestSuite
        /// </summary>
        [DataMember(Name = "testSuite", EmitDefaultValue = true)]
        public TestSuiteChangeViewModelChangedFieldViewModel TestSuite { get; set; }

        /// <summary>
        /// Gets or Sets TestPoints
        /// </summary>
        [DataMember(Name = "testPoints", EmitDefaultValue = true)]
        public TestPointChangeViewModelChangedFieldViewModel TestPoints { get; set; }

        /// <summary>
        /// Gets or Sets TestResults
        /// </summary>
        [DataMember(Name = "testResults", EmitDefaultValue = true)]
        public TestResultChangeViewModelChangedFieldViewModel TestResults { get; set; }

        /// <summary>
        /// Gets or Sets Locking
        /// </summary>
        [DataMember(Name = "locking", EmitDefaultValue = true)]
        public BooleanChangedFieldViewModel Locking { get; set; }

        /// <summary>
        /// Gets or Sets HasAutomaticDurationTimer
        /// </summary>
        [DataMember(Name = "hasAutomaticDurationTimer", EmitDefaultValue = true)]
        public BooleanNullableChangedFieldViewModel HasAutomaticDurationTimer { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, CustomAttributeChangeModel> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanChangedFieldsViewModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TestSuite: ").Append(TestSuite).Append("\n");
            sb.Append("  TestPoints: ").Append(TestPoints).Append("\n");
            sb.Append("  TestResults: ").Append(TestResults).Append("\n");
            sb.Append("  Locking: ").Append(Locking).Append("\n");
            sb.Append("  HasAutomaticDurationTimer: ").Append(HasAutomaticDurationTimer).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as TestPlanChangedFieldsViewModel);
        }

        /// <summary>
        /// Returns true if TestPlanChangedFieldsViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanChangedFieldsViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanChangedFieldsViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.TestSuite == input.TestSuite ||
                    (this.TestSuite != null &&
                    this.TestSuite.Equals(input.TestSuite))
                ) && 
                (
                    this.TestPoints == input.TestPoints ||
                    (this.TestPoints != null &&
                    this.TestPoints.Equals(input.TestPoints))
                ) && 
                (
                    this.TestResults == input.TestResults ||
                    (this.TestResults != null &&
                    this.TestResults.Equals(input.TestResults))
                ) && 
                (
                    this.Locking == input.Locking ||
                    (this.Locking != null &&
                    this.Locking.Equals(input.Locking))
                ) && 
                (
                    this.HasAutomaticDurationTimer == input.HasAutomaticDurationTimer ||
                    (this.HasAutomaticDurationTimer != null &&
                    this.HasAutomaticDurationTimer.Equals(input.HasAutomaticDurationTimer))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.Build != null)
                {
                    hashCode = (hashCode * 59) + this.Build.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.TestSuite != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuite.GetHashCode();
                }
                if (this.TestPoints != null)
                {
                    hashCode = (hashCode * 59) + this.TestPoints.GetHashCode();
                }
                if (this.TestResults != null)
                {
                    hashCode = (hashCode * 59) + this.TestResults.GetHashCode();
                }
                if (this.Locking != null)
                {
                    hashCode = (hashCode * 59) + this.Locking.GetHashCode();
                }
                if (this.HasAutomaticDurationTimer != null)
                {
                    hashCode = (hashCode * 59) + this.HasAutomaticDurationTimer.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
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
