using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.OAuth
{
    public enum Scope
    {
        /// <summary>
        /// Controls any access to document files, images, or metadata
        /// </summary>
        agreement_read,
        /// <summary>
        /// Controls document vaulting.
        /// </summary>
        agreement_vault,
        /// <summary>
        /// Controls any document action - cancel, sendReminder, delegate, etc.
        /// </summary>
        agreement_write,
        /// <summary>
        /// Controls document retention.
        /// </summary>
        agreement_retention,
        /// <summary>
        /// Controls any action that results in a document being sent for signature
        /// </summary>
        agreement_send,
        /// <summary>
        /// Controls any attempt to view the library
        /// </summary>
        library_read,
        /// <summary>
        /// Controls any action that creates or modifies the library
        /// </summary>
        library_write,
        /// <summary>
        /// Controls any action that results in the user being logged into the app
        user_login,
        /// <summary>
        /// Controls any attempt to view users and groups
        /// </summary>
        user_read,
        /// <summary>
        /// Controls any attempt to create and manage users and groups
        /// </summary>
        user_write,
        /// <summary>
        /// Controls any attempt to view widgets
        /// </summary>
        widget_read,
        /// <summary>
        /// Controls any action that creates or modifies widgets
        /// </summary>
        widget_write,
        /// <summary>
        /// Controls any attempt to view workflows
        /// </summary>
        workflow_read,
        /// <summary>
        /// Controls any action that creates or modifies workflows
        /// </summary>
        workflow_write
    }
}
