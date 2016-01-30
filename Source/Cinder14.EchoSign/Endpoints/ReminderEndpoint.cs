using Cinder14.EchoSign.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Endpoints
{
    public class ReminderEndpoint : EndpointBase
    {
        public ReminderEndpoint(EchoSignSDK api)
            : base(api)
        {

        }

        /// <summary>
        /// Sends a reminder for an agreement.
        /// </summary>
        public virtual Task<ReminderCreationResult> SendReminderAsync(ReminderCreationInfo info)
        {
            var request = new RestRequest(Method.POST);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.Resource = "reminders";
            request.AddJsonBody(info);
            return this.Sdk.ExecuteAsync<ReminderCreationResult>(request);
        }

    }
}
