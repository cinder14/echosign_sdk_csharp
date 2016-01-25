using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cinder14.EchoSign.Models
{
    public class RecipientSetInfo
    {
        /// <summary>
        /// Information about the members of the recipient set,
        /// </summary>
        public virtual RecipientInfo[] recipientSetMemberInfos { get; set; }
        /// <summary>
        /// (RecipientSecurityOption[], optional): Security options that apply to the recipient,
        /// </summary>
        public virtual RecipientSecurityOption[] securityOptions { get; set; }
        /// <summary>
        /// (RecipientRole): Specify the role of recipient set,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual RecipientRole recipientSetRole { get; set; }
        /// <summary>
        /// (integer, optional): Index indicating sequential signing group (specify for hybrid routing)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? signingOrder { get; set; }
    }
}