using Cinder14.EchoSign.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Endpoints
{
    public class UserEndpoint : EndpointBase
    {
        public UserEndpoint(EchoSignSDK api)
            : base(api)
        {

        }

        /// <summary>
        /// Gets all the users in an account
        /// </summary>
        public virtual Task<UsersInfo> GetAsync(string email)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "users";
            request.AddQueryParameter("x-user-email", email);
            return this.Sdk.ExecuteAsync<UsersInfo>(request);
        }

    }
}
