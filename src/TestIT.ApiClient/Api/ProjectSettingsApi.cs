/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace TestIT.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProjectSettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Set autotest project settings.
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <returns></returns>
        void ApiV2ProjectsProjectIdSettingsAutotestsPost(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest));

        /// <summary>
        /// Set autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest));
        /// <summary>
        /// Get autotest project settings.
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <returns>AutoTestProjectSettingsGetModel</returns>
        AutoTestProjectSettingsGetModel GetAutotestProjectSettings(string projectId);

        /// <summary>
        /// Get autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <returns>ApiResponse of AutoTestProjectSettingsGetModel</returns>
        ApiResponse<AutoTestProjectSettingsGetModel> GetAutotestProjectSettingsWithHttpInfo(string projectId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProjectSettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Set autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV2ProjectsProjectIdSettingsAutotestsPostAsync(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfoAsync(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AutoTestProjectSettingsGetModel</returns>
        System.Threading.Tasks.Task<AutoTestProjectSettingsGetModel> GetAutotestProjectSettingsAsync(string projectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get autotest project settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AutoTestProjectSettingsGetModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutoTestProjectSettingsGetModel>> GetAutotestProjectSettingsWithHttpInfoAsync(string projectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProjectSettingsApi : IProjectSettingsApiSync, IProjectSettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProjectSettingsApi : IDisposable, IProjectSettingsApi
    {
        private TestIT.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ProjectSettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ProjectSettingsApi(string basePath)
        {
            this.Configuration = TestIT.ApiClient.Client.Configuration.MergeConfigurations(
                TestIT.ApiClient.Client.GlobalConfiguration.Instance,
                new TestIT.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIT.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIT.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ProjectSettingsApi(TestIT.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = TestIT.ApiClient.Client.Configuration.MergeConfigurations(
                TestIT.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIT.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIT.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProjectSettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProjectSettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIT.ApiClient.Client.Configuration.MergeConfigurations(
                TestIT.ApiClient.Client.GlobalConfiguration.Instance,
                new TestIT.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIT.ApiClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIT.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProjectSettingsApi(HttpClient client, TestIT.ApiClient.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIT.ApiClient.Client.Configuration.MergeConfigurations(
                TestIT.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIT.ApiClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIT.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProjectSettingsApi(TestIT.ApiClient.Client.ISynchronousClient client, TestIT.ApiClient.Client.IAsynchronousClient asyncClient, TestIT.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = TestIT.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public TestIT.ApiClient.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public TestIT.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public TestIT.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TestIT.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TestIT.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Set autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <returns></returns>
        public void ApiV2ProjectsProjectIdSettingsAutotestsPost(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest))
        {
            ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo(projectId, apiV2ProjectsProjectIdSettingsAutotestsPostRequest);
        }

        /// <summary>
        /// Set autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public TestIT.ApiClient.Client.ApiResponse<Object> ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new TestIT.ApiClient.Client.ApiException(400, "Missing required parameter 'projectId' when calling ProjectSettingsApi->ApiV2ProjectsProjectIdSettingsAutotestsPost");

            TestIT.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIT.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = TestIT.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIT.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("projectId", TestIT.ApiClient.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.Data = apiV2ProjectsProjectIdSettingsAutotestsPostRequest;

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/v2/projects/{projectId}/settings/autotests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2ProjectsProjectIdSettingsAutotestsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV2ProjectsProjectIdSettingsAutotestsPostAsync(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfoAsync(projectId, apiV2ProjectsProjectIdSettingsAutotestsPostRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Set autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="apiV2ProjectsProjectIdSettingsAutotestsPostRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<TestIT.ApiClient.Client.ApiResponse<Object>> ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfoAsync(string projectId, ApiV2ProjectsProjectIdSettingsAutotestsPostRequest apiV2ProjectsProjectIdSettingsAutotestsPostRequest = default(ApiV2ProjectsProjectIdSettingsAutotestsPostRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new TestIT.ApiClient.Client.ApiException(400, "Missing required parameter 'projectId' when calling ProjectSettingsApi->ApiV2ProjectsProjectIdSettingsAutotestsPost");


            TestIT.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIT.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = TestIT.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIT.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("projectId", TestIT.ApiClient.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.Data = apiV2ProjectsProjectIdSettingsAutotestsPostRequest;

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/v2/projects/{projectId}/settings/autotests", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2ProjectsProjectIdSettingsAutotestsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <returns>AutoTestProjectSettingsGetModel</returns>
        public AutoTestProjectSettingsGetModel GetAutotestProjectSettings(string projectId)
        {
            TestIT.ApiClient.Client.ApiResponse<AutoTestProjectSettingsGetModel> localVarResponse = GetAutotestProjectSettingsWithHttpInfo(projectId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <returns>ApiResponse of AutoTestProjectSettingsGetModel</returns>
        public TestIT.ApiClient.Client.ApiResponse<AutoTestProjectSettingsGetModel> GetAutotestProjectSettingsWithHttpInfo(string projectId)
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new TestIT.ApiClient.Client.ApiException(400, "Missing required parameter 'projectId' when calling ProjectSettingsApi->GetAutotestProjectSettings");

            TestIT.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIT.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = TestIT.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIT.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("projectId", TestIT.ApiClient.Client.ClientUtils.ParameterToString(projectId)); // path parameter

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AutoTestProjectSettingsGetModel>("/api/v2/projects/{projectId}/settings/autotests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAutotestProjectSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AutoTestProjectSettingsGetModel</returns>
        public async System.Threading.Tasks.Task<AutoTestProjectSettingsGetModel> GetAutotestProjectSettingsAsync(string projectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TestIT.ApiClient.Client.ApiResponse<AutoTestProjectSettingsGetModel> localVarResponse = await GetAutotestProjectSettingsWithHttpInfoAsync(projectId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get autotest project settings. 
        /// </summary>
        /// <exception cref="TestIT.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AutoTestProjectSettingsGetModel)</returns>
        public async System.Threading.Tasks.Task<TestIT.ApiClient.Client.ApiResponse<AutoTestProjectSettingsGetModel>> GetAutotestProjectSettingsWithHttpInfoAsync(string projectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new TestIT.ApiClient.Client.ApiException(400, "Missing required parameter 'projectId' when calling ProjectSettingsApi->GetAutotestProjectSettings");


            TestIT.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIT.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = TestIT.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIT.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("projectId", TestIT.ApiClient.Client.ClientUtils.ParameterToString(projectId)); // path parameter

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AutoTestProjectSettingsGetModel>("/api/v2/projects/{projectId}/settings/autotests", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAutotestProjectSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}