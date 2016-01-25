namespace Cinder14.EchoSign.Endpoints
{
    public abstract class EndpointBase
    {
        public EndpointBase(EchoSignSDK sdk)
        {
            this.Sdk = sdk;
        }

        protected virtual EchoSignSDK Sdk { get; set; }

    }
}
