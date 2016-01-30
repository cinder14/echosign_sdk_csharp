using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Cinder14.EchoSign.Models
{
    public class AgreementInfo
    {
        /// <summary>
        /// (string): The message associated with the document that the sender has provided,
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// (DocSecurityOption[]): Security information about the document that specifies whether or not a password is required to view and sign the document,
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public DocSecurityOption[] securityOptions { get; set; }
        /// <summary>
        ///  (AgreementStatus): The current status of the document,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AgreementStatus status { get; set; }
        /// <summary>
        ///  (boolean): Information about whether the agreement can be modified,
        /// </summary>
        public bool modifiable { get; set; }
        /// <summary>
        ///  (date): The date after which the document can no longer be signed, if an expiration date is configured. The value is nil if an expiration date is not set for the document,
        /// </summary>
        public DateTime? expiration { get; set; }
        /// <summary>
        ///  (DocumentHistoryEvent[]): An ordered list of the events in the audit trail of this document,
        /// </summary>
        public DocumentHistoryEvent[] events { get; set; }
        /// <summary>
        ///  (ParticipantSetInfo[]): Information about all the participant sets of this document,
        /// </summary>
        public ParticipantSetInfo[] participantSetInfos { get; set; }
        /// <summary>
        ///  (string): The name of the document, specified by the sender,
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///  (string): The locale associated with this agreement - for example, en_US or fr_FR,
        /// </summary>
        public string locale { get; set; }
        /// <summary>
        ///  (string): A resource identifier that can be used to uniquely identify the agreement resource in other apis,
        /// </summary>
        public string agreementId { get; set; }
        /// <summary>
        ///  (NextParticipantSetInfo[]): Information about who needs to act next for this document - for example, if the agreement is in status OUT_FOR_SIGNATURE or OUT_FOR_APPROVAL, this will be the next signer or approver. If the AgreementStatus is a terminal state, this array is empty
        /// </summary>
        public NextParticipantSetInfo[] nextParticipantSetInfos { get; set; }
    }
}
