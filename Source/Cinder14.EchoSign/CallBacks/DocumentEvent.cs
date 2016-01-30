using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.CallBacks
{
    public enum DocumentEvent
    {
        /// <summary>
        /// When the document was first created
        /// </summary>
        CREATED,
        /// <summary>
        /// Document delivered to a specific user
        /// </summary>
        SIGNATURE_REQUESTED,
        /// <summary>
        /// End user opened the email with the document
        /// </summary>
        EMAIL_VIEWED,
        /// <summary>
        /// Someone signed the document. If multiple parties are required to sign, this will happen for each.
        /// </summary>
        ESIGNED
    }
}
