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
    /// Defines TestStatusType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TestStatusType
    {
        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 1,

        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 2,

        /// <summary>
        /// Enum Incomplete for value: Incomplete
        /// </summary>
        [EnumMember(Value = "Incomplete")]
        Incomplete = 3,

        /// <summary>
        /// Enum Succeeded for value: Succeeded
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded = 4,

        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 5

    }

}