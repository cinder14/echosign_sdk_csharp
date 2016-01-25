using System;

namespace Cinder14.EchoSign.Models
{
    public class AgreementCreationResponse
    {
        /// <summary>
        /// (date): Expiration date for autologin. This is based on the user setting, API_AUTO_LOGIN_LIFETIME,
        /// </summary>
        public virtual DateTime? expiration { get; set; }
        /// <summary>
        /// (string): The unique identifier that can be used to query status and download signed documents,
        /// </summary>
        public virtual string agreementId { get; set; }
        /// <summary>
        /// (string): Javascript snippet suitable for an embedded page taking a user to a URL,
        /// </summary>
        public virtual string embeddedCode { get; set; }
        /// <summary>
        /// (string): Standalone URL to direct end users to
        /// </summary>
        public virtual string url { get; set; }
        
    }
}
