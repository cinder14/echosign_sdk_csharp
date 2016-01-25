using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.OAuth
{
    public enum Modifier
    {
        /// <summary>
        /// Perform the specified action on behalf of the authorizing user
        /// This is the default - i.e. "agreement_send:self" is the same scope as "agreement_send" 
        /// </summary>
       self,

        /// <summary>
        /// Perform the specified action on behalf of any user in the same group as the authorizing user
        /// The authorizing user must be a group admin in order to grant this scope, and must have the Enterprise or Global edition of Adobe Document Cloud.
        /// </summary>
        group,

        /// <summary>
        /// Perform the specified action on behalf of any user in the same account as the authorizing user
        ///The authorizing user must be an account admin in order to grant this scope, and must have the Enterprise or Global edition of Adobe Document Cloud.
        /// </summary>
        account
       
    }
}
