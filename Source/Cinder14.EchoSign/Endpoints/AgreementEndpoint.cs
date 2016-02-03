using Cinder14.EchoSign.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Endpoints
{
    public class AgreementEndpoint : EndpointBase
    {
        public AgreementEndpoint(EchoSignSDK api)
            : base(api)
        {

        }

        /// <summary>
        /// Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client
        /// </summary>
        /// <param name="info"></param>
        public virtual AgreementCreationResponse Create(AgreementCreationInfo info)
        {
            var request = new RestRequest(Method.POST);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements";
            request.AddJsonBody(info);
            return this.Sdk.Execute<AgreementCreationResponse>(request);
        }
        /// <summary>
        /// Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client
        /// </summary>
        /// <param name="info"></param>
        public virtual Task<AgreementCreationResponse> CreateAsync(AgreementCreationInfo info)
        {
            var request = new RestRequest(Method.POST);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements";
            request.AddJsonBody(info);
            return this.Sdk.ExecuteAsync<AgreementCreationResponse>(request);
        }


        /// <summary>
        /// Retrieves the latest status of an agreement.
        /// </summary>
        public virtual AgreementInfo Get(string agreementId)
        {
            var request = new RestRequest(Method.GET);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.Execute<AgreementInfo>(request);
        }
        /// <summary>
        /// Retrieves the latest status of an agreement.
        /// </summary>
        public virtual Task<AgreementInfo> GetAsync(string agreementId)
        {
            var request = new RestRequest(Method.GET);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.ExecuteAsync<AgreementInfo>(request);
        }

        /// <summary>
        /// Deletes an agreement.Agreement will no longer be visible in the user's Manage Page
        /// </summary>
        public virtual void Delete(string agreementId)
        {
            var request = new RestRequest(Method.DELETE);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}";
            request.AddUrlSegment("agreementId", agreementId);
            this.Sdk.Execute(request);
        }
        /// <summary>
        /// Deletes an agreement.Agreement will no longer be visible in the user's Manage Page
        /// </summary>
        public virtual Task DeleteAsync(string agreementId)
        {
            var request = new RestRequest(Method.DELETE);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.ExecuteAsync(request);
        }

        /// <summary>
        /// Retrieves the URL for the eSign page for the current signer(s) of an agreement
        /// </summary>
        /// <returns></returns>
        public virtual SigningUrlResponse GetSigningUrls(string agreementId)
        {
            var request = new RestRequest(Method.GET);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}/signingUrls";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.Execute<SigningUrlResponse>(request);
        }
        /// <summary>
        /// Retrieves the URL for the eSign page for the current signer(s) of an agreement
        /// </summary>
        /// <returns></returns>
        public virtual Task<SigningUrlResponse> GetSigningUrlsAsync(string agreementId)
        {
            var request = new RestRequest(Method.GET);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}/signingUrls";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.ExecuteAsync<SigningUrlResponse>(request);
        }

        
    }
}
