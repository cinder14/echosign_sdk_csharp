using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cinder14.EchoSign.Models
{
    public class ParticipantSetInfo
    {
        /// <summary>
        ///  (ParticipantSecurityOption[]): Security options that apply to the participant,
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public ParticipantSecurityOption[] securityOptions { get; set; }
        /// <summary>
        ///  (UserAgreementStatus): The participant set's status with respect to the widget,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public UserAgreementStatus status { get; set; }
        /// <summary>
        ///  (ParticipantRole[]): The current roles of the participant set. A participant set can have one or more roles,
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public ParticipantRole[] roles { get; set; }
        /// <summary>
        ///  (ParticipantInfo[]): Information about the members of the recipient set,
        /// </summary>
        public ParticipantInfo[] participantSetMemberInfos { get; set; }
        /// <summary>
        ///  (integer, optional): Index indicating sequential signing group (specified for hybrid routing)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? signingOrder { get; set; }
      
    }
}