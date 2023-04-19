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
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace TestIt.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBackgroundJobsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get current user background jobs
        /// </summary>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>List&lt;BackgroundJobModel&gt;</returns>
        List<BackgroundJobModel> ApiV2BackgroundJobsGet(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string));

        /// <summary>
        /// Get current user background jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>ApiResponse of List&lt;BackgroundJobModel&gt;</returns>
        ApiResponse<List<BackgroundJobModel>> ApiV2BackgroundJobsGetWithHttpInfo(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBackgroundJobsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get current user background jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BackgroundJobModel&gt;</returns>
        System.Threading.Tasks.Task<List<BackgroundJobModel>> ApiV2BackgroundJobsGetAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get current user background jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BackgroundJobModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BackgroundJobModel>>> ApiV2BackgroundJobsGetWithHttpInfoAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBackgroundJobsApi : IBackgroundJobsApiSync, IBackgroundJobsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BackgroundJobsApi : IDisposable, IBackgroundJobsApi
    {
        private TestIt.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public BackgroundJobsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public BackgroundJobsApi(string basePath)
        {
            this.Configuration = TestIt.Client.Client.Configuration.MergeConfigurations(
                TestIt.Client.Client.GlobalConfiguration.Instance,
                new TestIt.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIt.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIt.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public BackgroundJobsApi(TestIt.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = TestIt.Client.Client.Configuration.MergeConfigurations(
                TestIt.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIt.Client.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIt.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public BackgroundJobsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class.
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
        public BackgroundJobsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIt.Client.Client.Configuration.MergeConfigurations(
                TestIt.Client.Client.GlobalConfiguration.Instance,
                new TestIt.Client.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIt.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIt.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class using Configuration object.
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
        public BackgroundJobsApi(HttpClient client, TestIt.Client.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIt.Client.Client.Configuration.MergeConfigurations(
                TestIt.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIt.Client.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIt.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundJobsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BackgroundJobsApi(TestIt.Client.Client.ISynchronousClient client, TestIt.Client.Client.IAsynchronousClient asyncClient, TestIt.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = TestIt.Client.Client.Configuration.DefaultExceptionFactory;
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
        public TestIt.Client.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public TestIt.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public TestIt.Client.Client.ISynchronousClient Client { get; set; }

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
        public TestIt.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TestIt.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Get current user background jobs 
        /// </summary>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>List&lt;BackgroundJobModel&gt;</returns>
        public List<BackgroundJobModel> ApiV2BackgroundJobsGet(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string))
        {
            TestIt.Client.Client.ApiResponse<List<BackgroundJobModel>> localVarResponse = ApiV2BackgroundJobsGetWithHttpInfo(skip, take, orderBy, searchField, searchValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user background jobs 
        /// </summary>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>ApiResponse of List&lt;BackgroundJobModel&gt;</returns>
        public TestIt.Client.Client.ApiResponse<List<BackgroundJobModel>> ApiV2BackgroundJobsGetWithHttpInfo(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string))
        {
            TestIt.Client.Client.RequestOptions localVarRequestOptions = new TestIt.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = TestIt.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "Skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "Take", take));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (searchField != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "SearchField", searchField));
            }
            if (searchValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "SearchValue", searchValue));
            }

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<BackgroundJobModel>>("/api/v2/backgroundJobs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2BackgroundJobsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get current user background jobs 
        /// </summary>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;BackgroundJobModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<BackgroundJobModel>> ApiV2BackgroundJobsGetAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TestIt.Client.Client.ApiResponse<List<BackgroundJobModel>> localVarResponse = await ApiV2BackgroundJobsGetWithHttpInfoAsync(skip, take, orderBy, searchField, searchValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user background jobs 
        /// </summary>
        /// <exception cref="TestIt.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;BackgroundJobModel&gt;)</returns>
        public async System.Threading.Tasks.Task<TestIt.Client.Client.ApiResponse<List<BackgroundJobModel>>> ApiV2BackgroundJobsGetWithHttpInfoAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            TestIt.Client.Client.RequestOptions localVarRequestOptions = new TestIt.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = TestIt.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "Skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "Take", take));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (searchField != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "SearchField", searchField));
            }
            if (searchValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.Client.Client.ClientUtils.ParameterToMultiMap("", "SearchValue", searchValue));
            }

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<BackgroundJobModel>>("/api/v2/backgroundJobs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2BackgroundJobsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}