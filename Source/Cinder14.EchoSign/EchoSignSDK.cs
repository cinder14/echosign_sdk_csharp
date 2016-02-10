using Cinder14.EchoSign.Endpoints;
using Cinder14.EchoSign.Exceptions;
using Cinder14.EchoSign.Serialization;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cinder14.EchoSign
{
    public partial class EchoSignSDK
    {
        #region Constructor

        public EchoSignSDK()
            : this(API_BASE_URL, string.Empty, string.Empty, string.Empty)
        {
        }
        public EchoSignSDK(string baseUrl)
            : this(baseUrl, string.Empty, string.Empty, string.Empty)
        {
        }
        public EchoSignSDK(string baseUrl, string accessToken)
            : this(baseUrl, accessToken, string.Empty, string.Empty)
        {
        }
        public EchoSignSDK(string baseUrl, string accessToken, string apiUser, string apiEmail)
        {
            this.CustomHeaders = new List<KeyValuePair<string, string>>();

            this.AccessToken = accessToken;
            this.AsyncTimeoutMillisecond = (int)TimeSpan.FromSeconds(40).TotalMilliseconds;
            this.ApiUser = apiUser;
            this.ApiEmail = apiEmail;

            if (baseUrl == null)
            {
                baseUrl = API_BASE_URL;
            }
            this.BaseUrl = baseUrl;
            if(!this.BaseUrl.ToLower().Contains("/api/"))
            {
                // likely user just put the api endpoint from token response, fix it up
                this.BaseUrl = this.BaseUrl.TrimEnd('/') + "/api/rest/v5";
            }

            this.InstanceCache = new Dictionary<string, object>();

            this.ConstructEndpoints();
        }

        #endregion

        #region Constants

        public const string API_BASE_URL = "https://api.na1.echosign.com/api/rest/v5";
        protected const string API_PARAM_ACCESS_TOKEN = "Access-Token";
        protected const string API_PARAM_API_USER = "x-api-user";

        #endregion

        #region Properties

        public virtual int AsyncTimeoutMillisecond { get; set; }
        public virtual string BaseUrl { get; set; }
        public virtual string AccessToken { get; set; }
        /// <summary>
        /// The userId of API caller using the account or group token. If it is not specified, then the caller is inferred from the AccessToken.
        /// </summary>
        public virtual string ApiUser { get; set; }
        /// <summary>
        /// The email of API caller using the account or group token. If it is not specified, then the caller is inferred from the AccessToken.
        /// </summary>
        public virtual string ApiEmail { get; set; }

        /// <summary>
        /// adds the headers to every request
        /// </summary>
        public virtual List<KeyValuePair<string, string>> CustomHeaders { get; set; }

        protected internal Dictionary<string, object> InstanceCache { get; set; }


        public virtual AgreementEndpoint Agreements { get; set; }
        public virtual LibraryDocumentEndpoint LibraryDocuments { get; set; }
        public virtual UserEndpoint Users { get; set; }

        public virtual ReminderEndpoint Reminders { get; set; }
        public virtual TransientDocumentEndpoint TransientDocuments { get; set; }

        #endregion

        #region Public Methods


        public virtual IRestResponse Execute(RestRequest request)
        {
            RestClient client = new RestClient();

            this.PrepareRequest(client, request);

            IRestResponse response = client.Execute(request);

            this.ValidateResponse(response);

            return response;
        }
        public virtual T Execute<T>(RestRequest request)
        {
            RestClient client = new RestClient();

            this.PrepareRequest(client, request);
            
            IRestResponse response = client.Execute(request);

            this.ValidateResponse(response);

            string content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }
        public virtual byte[] DownloadData(RestRequest request)
        {
            RestClient client = new RestClient();

            client.AddHandler("application/pdf", new MockDeserializer());

            this.PrepareRequest(client, request);

            IRestResponse rest = client.Execute(request);
            byte[] response = rest.RawBytes;

            return response;
        }

        public virtual Task<IRestResponse> ExecuteAsync(RestRequest request)
        {
            return ExecuteAsync(request, this.AsyncTimeoutMillisecond);
        }
        public virtual async Task<IRestResponse> ExecuteAsync(RestRequest request, int milliSecondTimeout)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            Task<IRestResponse> task = ExecuteAsyncInternal(request);
            var completedTask = await Task.WhenAny(task, Task.Delay(this.AsyncTimeoutMillisecond, tokenSource.Token));
            if (completedTask == task)
            {
                tokenSource.Cancel();
                return await task;
            }
            else
            {
                throw new EndpointTimeoutException(System.Net.HttpStatusCode.GatewayTimeout, "Error communicating with server, connection timed out.");
            }
        }

        public virtual Task<T> ExecuteAsync<T>(RestRequest request)
        {
            return ExecuteAsync<T>(request, this.AsyncTimeoutMillisecond);
        }
        public virtual async Task<T> ExecuteAsync<T>(RestRequest request, int milliSecondTimeout)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            Task<T> task = ExecuteAsyncInternal<T>(request);
            var completedTask = await Task.WhenAny(task, Task.Delay(this.AsyncTimeoutMillisecond, tokenSource.Token));
            if (completedTask == task)
            {
                tokenSource.Cancel();
                return await task;
            }
            else
            {
                throw new EndpointTimeoutException(System.Net.HttpStatusCode.GatewayTimeout, "Error communicating with server, connection timed out.");
            }
        }

        #endregion

        #region Protected Methods


        protected virtual void ConstructEndpoints()
        {
            this.Agreements = new AgreementEndpoint(this);
            this.LibraryDocuments = new LibraryDocumentEndpoint(this);
            this.Users = new UserEndpoint(this);
            this.Reminders = new ReminderEndpoint(this);
            this.TransientDocuments = new TransientDocumentEndpoint(this);
        }

        protected virtual void PrepareRequest(RestClient client, RestRequest request)
        {
            client.BaseUrl = new Uri(BaseUrl);

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();

            this.AddAuthorizationHeaders(client, request);
            this.AddCustomHeaders(client, request);
        }
        protected virtual async Task<IRestResponse> ExecuteAsyncInternal(RestRequest request)
        {
            RestClient client = new RestClient();

            this.PrepareRequest(client, request);

            IRestResponse response = await client.ExecuteTaskAsync(request);

            this.ValidateResponse(response);

            return response;
        }
        protected virtual async Task<T> ExecuteAsyncInternal<T>(RestRequest request)
        {
            RestClient client = new RestClient();

            this.PrepareRequest(client, request);

            IRestResponse response = await client.ExecuteTaskAsync(request);

            this.ValidateResponse(response);
            string content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }


        protected virtual void AddCustomHeaders(RestClient client, RestRequest request)
        {
            if (this.CustomHeaders != null)
            {
                foreach (var item in this.CustomHeaders)
                {
                    if (!string.IsNullOrEmpty(item.Key))
                    {
                        client.AddDefaultHeader(item.Key, item.Value);
                    }
                }
            }
        }
        protected virtual void AddAuthorizationHeaders(RestClient client, RestRequest request)
        {
            if (!string.IsNullOrEmpty(this.AccessToken))
            {
                client.AddDefaultHeader(API_PARAM_ACCESS_TOKEN, this.AccessToken);
            }

            if (!string.IsNullOrEmpty(this.ApiUser))
            {
                client.AddDefaultHeader(API_PARAM_API_USER, string.Format("userid:{0}", this.ApiUser));
            }
            else if (!string.IsNullOrEmpty(this.ApiEmail))
            {
                client.AddDefaultHeader(API_PARAM_API_USER, string.Format("email:{0}", this.ApiEmail));
            }
        }
        protected virtual void ValidateResponse(IRestResponse response)
        {
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.Continue:
                case System.Net.HttpStatusCode.Accepted:
                case System.Net.HttpStatusCode.Created:
                case System.Net.HttpStatusCode.NoContent:
                case System.Net.HttpStatusCode.NotModified:
                case System.Net.HttpStatusCode.OK:
                    // do nothing
                    break;
                default:
                    throw new EndpointException(response.StatusCode, response.StatusDescription);
            }
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error retrieving response.  Check inner details for more info.", response.ErrorException);
            }
        }

        #endregion

    }
}
