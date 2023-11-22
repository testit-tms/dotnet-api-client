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
    /// Defines BackgroundJobType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackgroundJobType
    {
        /// <summary>
        /// Enum ExportXlsxTestResultsByTestPlan for value: ExportXlsxTestResultsByTestPlan
        /// </summary>
        [EnumMember(Value = "ExportXlsxTestResultsByTestPlan")]
        ExportXlsxTestResultsByTestPlan = 1,

        /// <summary>
        /// Enum ExportXlsxWorkItemsByProject for value: ExportXlsxWorkItemsByProject
        /// </summary>
        [EnumMember(Value = "ExportXlsxWorkItemsByProject")]
        ExportXlsxWorkItemsByProject = 2,

        /// <summary>
        /// Enum ExportXlsxTestPointsByTestPlan for value: ExportXlsxTestPointsByTestPlan
        /// </summary>
        [EnumMember(Value = "ExportXlsxTestPointsByTestPlan")]
        ExportXlsxTestPointsByTestPlan = 3,

        /// <summary>
        /// Enum ExportJsonProject for value: ExportJsonProject
        /// </summary>
        [EnumMember(Value = "ExportJsonProject")]
        ExportJsonProject = 4,

        /// <summary>
        /// Enum ExportZipProject for value: ExportZipProject
        /// </summary>
        [EnumMember(Value = "ExportZipProject")]
        ExportZipProject = 5,

        /// <summary>
        /// Enum ExportJsonProjectWithTestPlans for value: ExportJsonProjectWithTestPlans
        /// </summary>
        [EnumMember(Value = "ExportJsonProjectWithTestPlans")]
        ExportJsonProjectWithTestPlans = 6,

        /// <summary>
        /// Enum ExportZipProjectWithTestPlans for value: ExportZipProjectWithTestPlans
        /// </summary>
        [EnumMember(Value = "ExportZipProjectWithTestPlans")]
        ExportZipProjectWithTestPlans = 7,

        /// <summary>
        /// Enum ImportJsonProject for value: ImportJsonProject
        /// </summary>
        [EnumMember(Value = "ImportJsonProject")]
        ImportJsonProject = 8,

        /// <summary>
        /// Enum ImportZipProject for value: ImportZipProject
        /// </summary>
        [EnumMember(Value = "ImportZipProject")]
        ImportZipProject = 9,

        /// <summary>
        /// Enum ImportXlsxProject for value: ImportXlsxProject
        /// </summary>
        [EnumMember(Value = "ImportXlsxProject")]
        ImportXlsxProject = 10,

        /// <summary>
        /// Enum ImportTestRailXmlProject for value: ImportTestRailXmlProject
        /// </summary>
        [EnumMember(Value = "ImportTestRailXmlProject")]
        ImportTestRailXmlProject = 11,

        /// <summary>
        /// Enum PurgeProject for value: PurgeProject
        /// </summary>
        [EnumMember(Value = "PurgeProject")]
        PurgeProject = 12,

        /// <summary>
        /// Enum ExportProjects for value: ExportProjects
        /// </summary>
        [EnumMember(Value = "ExportProjects")]
        ExportProjects = 13,

        /// <summary>
        /// Enum ImportProjects for value: ImportProjects
        /// </summary>
        [EnumMember(Value = "ImportProjects")]
        ImportProjects = 14

    }

}
