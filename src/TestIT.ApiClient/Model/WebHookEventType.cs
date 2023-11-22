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
    /// Defines WebHookEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebHookEventType
    {
        /// <summary>
        /// Enum AutomatedTestRunCreated for value: AutomatedTestRunCreated
        /// </summary>
        [EnumMember(Value = "AutomatedTestRunCreated")]
        AutomatedTestRunCreated = 1,

        /// <summary>
        /// Enum TestPlansStatusChanged for value: TestPlansStatusChanged
        /// </summary>
        [EnumMember(Value = "TestPlansStatusChanged")]
        TestPlansStatusChanged = 2,

        /// <summary>
        /// Enum TestRunStopped for value: TestRunStopped
        /// </summary>
        [EnumMember(Value = "TestRunStopped")]
        TestRunStopped = 3,

        /// <summary>
        /// Enum TestPointAssigned for value: TestPointAssigned
        /// </summary>
        [EnumMember(Value = "TestPointAssigned")]
        TestPointAssigned = 4,

        /// <summary>
        /// Enum TestResultJiraIssueCreated for value: TestResultJiraIssueCreated
        /// </summary>
        [EnumMember(Value = "TestResultJiraIssueCreated")]
        TestResultJiraIssueCreated = 5,

        /// <summary>
        /// Enum AutoTestFinished for value: AutoTestFinished
        /// </summary>
        [EnumMember(Value = "AutoTestFinished")]
        AutoTestFinished = 6,

        /// <summary>
        /// Enum UserMentionedInComment for value: UserMentionedInComment
        /// </summary>
        [EnumMember(Value = "UserMentionedInComment")]
        UserMentionedInComment = 7,

        /// <summary>
        /// Enum UserSelectedInWorkItemAttribute for value: UserSelectedInWorkItemAttribute
        /// </summary>
        [EnumMember(Value = "UserSelectedInWorkItemAttribute")]
        UserSelectedInWorkItemAttribute = 8,

        /// <summary>
        /// Enum AllTestPointsFinished for value: AllTestPointsFinished
        /// </summary>
        [EnumMember(Value = "AllTestPointsFinished")]
        AllTestPointsFinished = 9,

        /// <summary>
        /// Enum AllAutoTestsFinished for value: AllAutoTestsFinished
        /// </summary>
        [EnumMember(Value = "AllAutoTestsFinished")]
        AllAutoTestsFinished = 10,

        /// <summary>
        /// Enum AutoTestChanged for value: AutoTestChanged
        /// </summary>
        [EnumMember(Value = "AutoTestChanged")]
        AutoTestChanged = 11,

        /// <summary>
        /// Enum WorkItemAutoTestRelationChanged for value: WorkItemAutoTestRelationChanged
        /// </summary>
        [EnumMember(Value = "WorkItemAutoTestRelationChanged")]
        WorkItemAutoTestRelationChanged = 12,

        /// <summary>
        /// Enum WorkItemAttributeChanged for value: WorkItemAttributeChanged
        /// </summary>
        [EnumMember(Value = "WorkItemAttributeChanged")]
        WorkItemAttributeChanged = 13,

        /// <summary>
        /// Enum WorkItemChanged for value: WorkItemChanged
        /// </summary>
        [EnumMember(Value = "WorkItemChanged")]
        WorkItemChanged = 14,

        /// <summary>
        /// Enum ConfigurationChanged for value: ConfigurationChanged
        /// </summary>
        [EnumMember(Value = "ConfigurationChanged")]
        ConfigurationChanged = 15,

        /// <summary>
        /// Enum ProjectChanged for value: ProjectChanged
        /// </summary>
        [EnumMember(Value = "ProjectChanged")]
        ProjectChanged = 16,

        /// <summary>
        /// Enum TestPlanChanged for value: TestPlanChanged
        /// </summary>
        [EnumMember(Value = "TestPlanChanged")]
        TestPlanChanged = 17

    }

}
