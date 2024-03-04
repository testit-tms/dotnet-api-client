/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using TestIT.ApiClient.Client;
using TestIT.ApiClient.Api;
// uncomment below to import models
//using TestIT.ApiClient.Model;

namespace TestIT.ApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing ProjectImportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectImportApiTests : IDisposable
    {
        private ProjectImportApi instance;

        public ProjectImportApiTests()
        {
            instance = new ProjectImportApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectImportApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectImportApi
            //Assert.IsType<ProjectImportApi>(instance);
        }

        /// <summary>
        /// Test BackgroundImportToExistingProject
        /// </summary>
        [Fact]
        public void BackgroundImportToExistingProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //FileParameter file = null;
            //var response = instance.BackgroundImportToExistingProject(projectId, file);
            //Assert.IsType<Guid>(response);
        }

        /// <summary>
        /// Test BackgroundImportZipToExistingProject
        /// </summary>
        [Fact]
        public void BackgroundImportZipToExistingProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //FileParameter file = null;
            //var response = instance.BackgroundImportZipToExistingProject(projectId, file);
            //Assert.IsType<Guid>(response);
        }

        /// <summary>
        /// Test ImportToExistingProject
        /// </summary>
        [Fact]
        public void ImportToExistingProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //bool? includeAttachments = null;
            //FileParameter file = null;
            //instance.ImportToExistingProject(projectId, includeAttachments, file);
        }
    }
}