using System;

namespace Cinder14.EchoSign.Models
{
    public class NextParticipantInfo
    {
        /// <summary>
        /// (date): The date since which the document has been waiting for the participant to take action,
        /// </summary>
        public DateTime waitingSince { get; set; }
        /// <summary>
        /// (string): The email address of the next participant,
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// (string): The name of the next participant, if available
        /// </summary>
        public string name { get; set; }
    }
}