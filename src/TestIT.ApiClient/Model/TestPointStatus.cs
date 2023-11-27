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
    /// Defines TestPointStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TestPointStatus
    {
        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 1,

        /// <summary>
        /// Enum Passed for value: Passed
        /// </summary>
        [EnumMember(Value = "Passed")]
        Passed = 2,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 3,

        /// <summary>
        /// Enum Skipped for value: Skipped
        /// </summary>
        [EnumMember(Value = "Skipped")]
        Skipped = 4,

        /// <summary>
        /// Enum Blocked for value: Blocked
        /// </summary>
        [EnumMember(Value = "Blocked")]
        Blocked = 5,

        /// <summary>
        /// Enum NoResults for value: NoResults
        /// </summary>
        [EnumMember(Value = "NoResults")]
        NoResults = 6

    }

}
