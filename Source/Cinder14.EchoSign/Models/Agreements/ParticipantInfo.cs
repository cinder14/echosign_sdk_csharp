using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cinder14.EchoSign.Models
{
    public class ParticipantInfo
    {
        /// <summary>
        ///  (string): The title of the participant, if available,
        /// </summary>
        public string title { get; set; }
        /// <summary>
        ///  (ParticipantSecurityOption[]): Security options that apply to the participant,
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public ParticipantSecurityOption[] securityOptions { get; set; }
        /// <summary>
        ///  (string): The email address of the participant,
        /// </summary>
        public string email { get; set; }
        /// <summary>
        ///  (string): The name of the participant, if available,
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///  (string): The company of the participant, if available,
        /// </summary>
        public string company { get; set; }
        /// <summary>
        ///  (ParticipantSetInfo[]): All the child participants of the current participant. The possible values for the status of these participants are, SHARE and DELEGATE
        /// </summary>
        public ParticipantSetInfo[] alternateParticipants { get; set; }
       
    }
}