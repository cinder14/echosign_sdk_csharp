using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class ReminderCreationResult
    {
        /// <summary>
        /// (string): A status value indicating the result of the operation,
        /// </summary>
        public string result { get; set; }
        /// <summary>
        /// (ParticipantEmailSetInfo[]): The info of the party (participant sets) that was reminded.
        /// </summary>
        public ParticipantEmailSetInfo[] participantEmailsSet { get; set; }
    }
}
