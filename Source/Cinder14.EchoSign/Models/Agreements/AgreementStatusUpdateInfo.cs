using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class AgreementStatusUpdateInfo
    {
        /// <summary>
        /// (string) = ['CANCEL']: The state to which the agreement is to be updated.The only valid state for this variable is currently, CANCEL,
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// (string, optional): An optional comment describing to the recipient why you want to cancel the transaction,
        /// </summary>
        public string comment { get; set; }
        /// <summary>
        /// (boolean, optional): Whether or not you would like the recipient to be notified that the transaction has been cancelled.The notification is mandatory if any party has already signed this document.The default value is false
        /// </summary>
        public bool? notifySigner { get; set; }
    }
}
