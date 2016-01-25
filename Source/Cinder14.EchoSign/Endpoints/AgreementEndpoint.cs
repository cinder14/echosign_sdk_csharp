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

    }
}
