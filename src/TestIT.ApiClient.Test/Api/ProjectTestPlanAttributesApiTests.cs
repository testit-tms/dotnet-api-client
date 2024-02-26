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
    ///  Class for testing ProjectTestPlanAttributesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectTestPlanAttributesApiTests : IDisposable
    {
        private ProjectTestPlanAttributesApi instance;

        public ProjectTestPlanAttributesApiTests()
        {
            instance = new ProjectTestPlanAttributesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectTestPlanAttributesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectTestPlanAttributesApi
            //Assert.IsType<ProjectTestPlanAttributesApi>(instance);
        }

        /// <summary>
        /// Test CreateCustomAttributeTestPlanProjectRelations
        /// </summary>
        [Fact]
        public void CreateCustomAttributeTestPlanProjectRelationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //List<Guid> requestBody = null;
            //instance.CreateCustomAttributeTestPlanProjectRelations(projectId, requestBody);
        }

        /// <summary>
        /// Test DeleteCustomAttributeTestPlanProjectRelations
        /// </summary>
        [Fact]
        public void DeleteCustomAttributeTestPlanProjectRelationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //Guid attributeId = null;
            //instance.DeleteCustomAttributeTestPlanProjectRelations(projectId, attributeId);
        }

        /// <summary>
        /// Test GetCustomAttributeTestPlanProjectRelations
        /// </summary>
        [Fact]
        public void GetCustomAttributeTestPlanProjectRelationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.GetCustomAttributeTestPlanProjectRelations(projectId);
            //Assert.IsType<List<CustomAttributeModel>>(response);
        }

        /// <summary>
        /// Test SearchTestPlanAttributesInProject
        /// </summary>
        [Fact]
        public void SearchTestPlanAttributesInProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //SearchAttributesInProjectRequest searchAttributesInProjectRequest = null;
            //var response = instance.SearchTestPlanAttributesInProject(projectId, skip, take, orderBy, searchField, searchValue, searchAttributesInProjectRequest);
            //Assert.IsType<List<CustomAttributeGetModel>>(response);
        }

        /// <summary>
        /// Test UpdateCustomAttributeTestPlanProjectRelations
        /// </summary>
        [Fact]
        public void UpdateCustomAttributeTestPlanProjectRelationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //UpdateCustomAttributeTestPlanProjectRelationsRequest updateCustomAttributeTestPlanProjectRelationsRequest = null;
            //instance.UpdateCustomAttributeTestPlanProjectRelations(projectId, updateCustomAttributeTestPlanProjectRelationsRequest);
        }
    }
}
