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
    /// TestSuiteV2TreeModel
    /// </summary>
    [DataContract(Name = "TestSuiteV2TreeModel")]
    public partial class TestSuiteV2TreeModel : IValidatableObject
    {

        /// <summary>
        /// Type of the test suite
        /// </summary>
        /// <value>Type of the test suite</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TestSuiteType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteV2TreeModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestSuiteV2TreeModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteV2TreeModel" /> class.
        /// </summary>
        /// <param name="children">nested enumeration of children is allowed.</param>
        /// <param name="id">Unique ID of the test suite (required).</param>
        /// <param name="refreshDate">Date of the last refresh of the test suite.</param>
        /// <param name="parentId">Unique ID of the parent test suite in hierarchy.</param>
        /// <param name="testPlanId">Unique ID of test plan to which the test suite belongs (required).</param>
        /// <param name="name">Name of the test suite (required).</param>
        /// <param name="type">Type of the test suite.</param>
        /// <param name="saveStructure">Indicates if the test suite retains section tree structure.</param>
        /// <param name="autoRefresh">Indicates if scheduled auto refresh is enabled for the test suite.</param>
        public TestSuiteV2TreeModel(List<TestSuiteV2TreeModel> children = default(List<TestSuiteV2TreeModel>), Guid id = default(Guid), DateTime? refreshDate = default(DateTime?), Guid? parentId = default(Guid?), Guid testPlanId = default(Guid), string name = default(string), TestSuiteType? type = default(TestSuiteType?), bool? saveStructure = default(bool?), bool? autoRefresh = default(bool?))
        {
            this.Id = id;
            this.TestPlanId = testPlanId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestSuiteV2TreeModel and cannot be null");
            }
            this.Name = name;
            this.Children = children;
            this.RefreshDate = refreshDate;
            this.ParentId = parentId;
            this.Type = type;
            this.SaveStructure = saveStructure;
            this.AutoRefresh = autoRefresh;
        }

        /// <summary>
        /// nested enumeration of children is allowed
        /// </summary>
        /// <value>nested enumeration of children is allowed</value>
        [DataMember(Name = "children", EmitDefaultValue = true)]
        [Obsolete]
        public List<TestSuiteV2TreeModel> Children { get; set; }

        /// <summary>
        /// Unique ID of the test suite
        /// </summary>
        /// <value>Unique ID of the test suite</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Date of the last refresh of the test suite
        /// </summary>
        /// <value>Date of the last refresh of the test suite</value>
        [DataMember(Name = "refreshDate", EmitDefaultValue = true)]
        public DateTime? RefreshDate { get; set; }

        /// <summary>
        /// Unique ID of the parent test suite in hierarchy
        /// </summary>
        /// <value>Unique ID of the parent test suite in hierarchy</value>
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Unique ID of test plan to which the test suite belongs
        /// </summary>
        /// <value>Unique ID of test plan to which the test suite belongs</value>
        [DataMember(Name = "testPlanId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestPlanId { get; set; }

        /// <summary>
        /// Name of the test suite
        /// </summary>
        /// <value>Name of the test suite</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the test suite retains section tree structure
        /// </summary>
        /// <value>Indicates if the test suite retains section tree structure</value>
        [DataMember(Name = "saveStructure", EmitDefaultValue = true)]
        public bool? SaveStructure { get; set; }

        /// <summary>
        /// Indicates if scheduled auto refresh is enabled for the test suite
        /// </summary>
        /// <value>Indicates if scheduled auto refresh is enabled for the test suite</value>
        [DataMember(Name = "autoRefresh", EmitDefaultValue = true)]
        public bool? AutoRefresh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestSuiteV2TreeModel {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RefreshDate: ").Append(RefreshDate).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SaveStructure: ").Append(SaveStructure).Append("\n");
            sb.Append("  AutoRefresh: ").Append(AutoRefresh).Append("\n");
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
