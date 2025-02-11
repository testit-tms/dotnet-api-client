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
    /// TestPlanGroupByTesterAndStatus
    /// </summary>
    [DataContract(Name = "TestPlanGroupByTesterAndStatus")]
    public partial class TestPlanGroupByTesterAndStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupByTesterAndStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanGroupByTesterAndStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupByTesterAndStatus" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="status">status (required).</param>
        /// <param name="value">value (required).</param>
        public TestPlanGroupByTesterAndStatus(Guid? userId = default(Guid?), string status = default(string), long value = default(long))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TestPlanGroupByTesterAndStatus and cannot be null");
            }
            this.Status = status;
            this.Value = value;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public long Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanGroupByTesterAndStatus {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
