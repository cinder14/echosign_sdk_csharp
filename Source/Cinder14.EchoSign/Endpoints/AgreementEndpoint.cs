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
        public virtual Task<AgreementInfo> GetAsync(string agreementId)
        {
            var request = new RestRequest(Method.GET);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "agreements/{agreementId}";
            request.AddUrlSegment("agreementId", agreementId);
            return this.Sdk.ExecuteAsync<AgreementInfo>(request);
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
