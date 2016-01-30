using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class SigningUrlSetInfo
    {
        /// <summary>
        ///  (SigningUrl[]): An array of urls for current signer set.
        /// </summary>
        public SigningUrl[] signingUrls { get; set; }
    }
}
