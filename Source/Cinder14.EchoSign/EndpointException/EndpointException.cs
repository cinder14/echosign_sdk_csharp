using System;
using System.Net;

namespace Cinder14.EchoSign.Exceptions
{
    [Serializable]

    public class EndpointException : Exception
    {
        public EndpointException() { }
        public EndpointException(HttpStatusCode statusCode)
            : base(string.Format("HttpStatusCode: {0}", statusCode)) 
        {
            this.StatusCode = statusCode;
        }
        
        public EndpointException(HttpStatusCode statusCode, string message) 
            : base(message)
        {
            this.StatusCode = statusCode;
        }
        public EndpointException(HttpStatusCode statusCode, string message, string content)
            : base(message)
        {
            this.StatusCode = statusCode;
            this.Content = content;
        }
        public EndpointException(HttpStatusCode statusCode, string message, Exception inner)
            : base(message, inner) 
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
        public string Content { get; set; }
        protected EndpointException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
