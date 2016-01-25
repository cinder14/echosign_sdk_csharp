using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.OAuth
{
    public class AuthorizationInfo : TokenInfo
    {
        /// <summary>
        /// Endpoint to use when using the access code
        /// </summary>
        public virtual string api_endpoint { get; set; }

        /// <summary>
        /// Refresh Token, which can be used to get a fresh Access Token
        /// </summary>
        public virtual string refresh_token { get; set; }

        /// <summary>
        /// The state passed to Access Token Request
        /// </summary>
        public virtual string state { get; set; }

    }
}
