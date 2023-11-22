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
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

namespace TestIt.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all Tags
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TagShortModel&gt;</returns>
        List<TagShortModel> ApiV2TagsGet();

        /// <summary>
        /// Get all Tags
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TagShortModel&gt;</returns>
        ApiResponse<List<TagShortModel>> ApiV2TagsGetWithHttpInfo();
        /// <summary>
        /// Get all Tags that are used in TestPlans
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>List&lt;TagShortModel&gt;</returns>
        List<TagShortModel> ApiV2TagsTestPlansTagsGet(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string));

        /// <summary>
        /// Get all Tags that are used in TestPlans
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>ApiResponse of List&lt;TagShortModel&gt;</returns>
        ApiResponse<List<TagShortModel>> ApiV2TagsTestPlansTagsGetWithHttpInfo(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all Tags
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TagShortModel&gt;</returns>
        System.Threading.Tasks.Task<List<TagShortModel>> ApiV2TagsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all Tags
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TagShortModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TagShortModel>>> ApiV2TagsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all Tags that are used in TestPlans
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TagShortModel&gt;</returns>
        System.Threading.Tasks.Task<List<TagShortModel>> ApiV2TagsTestPlansTagsGetAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all Tags that are used in TestPlans
        /// </summary>
        /// <remarks>
        /// &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </remarks>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TagShortModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TagShortModel>>> ApiV2TagsTestPlansTagsGetWithHttpInfoAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApi : ITagsApiSync, ITagsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TagsApi : IDisposable, ITagsApi
    {
        private TestIt.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public TagsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public TagsApi(string basePath)
        {
            this.Configuration = TestIt.ApiClient.Client.Configuration.MergeConfigurations(
                TestIt.ApiClient.Client.GlobalConfiguration.Instance,
                new TestIt.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIt.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIt.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public TagsApi(TestIt.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = TestIt.ApiClient.Client.Configuration.MergeConfigurations(
                TestIt.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIt.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIt.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public TagsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
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
        public TagsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIt.ApiClient.Client.Configuration.MergeConfigurations(
                TestIt.ApiClient.Client.GlobalConfiguration.Instance,
                new TestIt.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new TestIt.ApiClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = TestIt.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class using Configuration object.
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
        public TagsApi(HttpClient client, TestIt.ApiClient.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = TestIt.ApiClient.Client.Configuration.MergeConfigurations(
                TestIt.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new TestIt.ApiClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = TestIt.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public TagsApi(TestIt.ApiClient.Client.ISynchronousClient client, TestIt.ApiClient.Client.IAsynchronousClient asyncClient, TestIt.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = TestIt.ApiClient.Client.Configuration.DefaultExceptionFactory;
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
        public TestIt.ApiClient.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public TestIt.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public TestIt.ApiClient.Client.ISynchronousClient Client { get; set; }

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
        public TestIt.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TestIt.ApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// Get all Tags &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;TagShortModel&gt;</returns>
        public List<TagShortModel> ApiV2TagsGet()
        {
            TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> localVarResponse = ApiV2TagsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Tags &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;TagShortModel&gt;</returns>
        public TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> ApiV2TagsGetWithHttpInfo()
        {
            TestIt.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIt.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = TestIt.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<TagShortModel>>("/api/v2/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2TagsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Tags &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TagShortModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<TagShortModel>> ApiV2TagsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> localVarResponse = await ApiV2TagsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Tags &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TagShortModel&gt;)</returns>
        public async System.Threading.Tasks.Task<TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>>> ApiV2TagsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            TestIt.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIt.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = TestIt.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<TagShortModel>>("/api/v2/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2TagsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Tags that are used in TestPlans &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>List&lt;TagShortModel&gt;</returns>
        public List<TagShortModel> ApiV2TagsTestPlansTagsGet(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string))
        {
            TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> localVarResponse = ApiV2TagsTestPlansTagsGetWithHttpInfo(skip, take, orderBy, searchField, searchValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Tags that are used in TestPlans &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <returns>ApiResponse of List&lt;TagShortModel&gt;</returns>
        public TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> ApiV2TagsTestPlansTagsGetWithHttpInfo(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string))
        {
            TestIt.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIt.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = TestIt.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "Skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "Take", take));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (searchField != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "SearchField", searchField));
            }
            if (searchValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "SearchValue", searchValue));
            }

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<TagShortModel>>("/api/v2/tags/testPlansTags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2TagsTestPlansTagsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Tags that are used in TestPlans &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;TagShortModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<TagShortModel>> ApiV2TagsTestPlansTagsGetAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>> localVarResponse = await ApiV2TagsTestPlansTagsGetWithHttpInfoAsync(skip, take, orderBy, searchField, searchValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Tags that are used in TestPlans &lt;br&gt;Use case  &lt;br&gt;User runs method execution  &lt;br&gt;System returns tags (listed in the response example)
        /// </summary>
        /// <exception cref="TestIt.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip">Amount of items to be skipped (offset) (optional)</param>
        /// <param name="take">Amount of items to be taken (limit) (optional)</param>
        /// <param name="orderBy">SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional)</param>
        /// <param name="searchField">Property name for searching (optional)</param>
        /// <param name="searchValue">Value for searching (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;TagShortModel&gt;)</returns>
        public async System.Threading.Tasks.Task<TestIt.ApiClient.Client.ApiResponse<List<TagShortModel>>> ApiV2TagsTestPlansTagsGetWithHttpInfoAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string searchField = default(string), string searchValue = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            TestIt.ApiClient.Client.RequestOptions localVarRequestOptions = new TestIt.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = TestIt.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = TestIt.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "Skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "Take", take));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "OrderBy", orderBy));
            }
            if (searchField != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "SearchField", searchField));
            }
            if (searchValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(TestIt.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "SearchValue", searchValue));
            }

            // authentication (Bearer or PrivateToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<TagShortModel>>("/api/v2/tags/testPlansTags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2TagsTestPlansTagsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
