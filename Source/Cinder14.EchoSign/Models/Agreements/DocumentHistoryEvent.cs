using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Cinder14.EchoSign.Models
{
    public class DocumentHistoryEvent
    {
        /// <summary>
        ///  (string, optional): The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null),
        /// </summary>
        public string vaultEventId { get; set; }

        /// <summary>
        ///  (string): Email address of the user that initiated the event,
        /// </summary>
        public string participantEmail { get; set; }

        /// <summary>
        ///  (string): A unique identifier linking offline events to synchronization events (specified for offline signing events and synchronization events, else null),
        /// </summary>
        public string synchronizationId { get; set; }

        /// <summary>
        ///  (string): A description of the audit event,
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///  (string): An ID which uniquely identifies the version of the document associated with this audit event,
        /// </summary>
        public string versionId { get; set; }

        /// <summary>
        ///  (AgreementEventType): Type of agreement event,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AgreementEventType type { get; set; }

        /// <summary>
        ///  (date): The date of the audit event,
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        ///  (string): The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or SHARE, the message from the acting user to the participant,
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        ///  (string): The IP address of the user that initiated the event,
        /// </summary>
        public string actingUserIpAddress { get; set; }

        /// <summary>
        ///  (DeviceLocation): Location of the device that created the event (This value may be null due to limited privileges),
        /// </summary>
        public DeviceLocation deviceLocation { get; set; }

        /// <summary>
        ///  (string): Email address of the user that initiated the event
        /// </summary>
        public string actingUserEmail { get; set; }
        
    }
}