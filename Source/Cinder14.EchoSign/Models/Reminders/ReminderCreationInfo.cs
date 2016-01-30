using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class ReminderCreationInfo
    {
        /// <summary>
        /// (string): The agreement identifier,
        /// </summary>
        public string agreementId { get; set; }
        /// <summary>
        /// (string, optional): An optional message sent to the recipients, describing what is being sent and why their signatures are required.
        /// </summary>
        public string comment { get; set; }
    }
}
