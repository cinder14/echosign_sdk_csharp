using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class SigningUrlResponse
    {
        /// <summary>
        /// (SigningUrlSetInfo[]): An array of urls for signer sets involved in this agreement.
        /// </summary>
        public SigningUrlSetInfo[] signingUrlSetInfos { get; set; }
    }
}
