using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cinder14.EchoSign.Models
{
    public class RecipientSecurityOption
    {
        /// <summary>
        /// (AuthenticationMethod): The authentication method for the recipients to have access to view and sign the document,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual AuthenticationMethod authenticationMethod { get; set; }
        /// <summary>
        /// (PhoneInfo[]): The phoneInfo required for the recipient to view and sign the document,
        /// </summary>
        public virtual PhoneInfo[] phoneInfos { get; set; }
        /// <summary>
        /// (string, optional): The password required for the recipient to view and sign the document
        /// </summary>
        public virtual string password { get; set; }
       
    }
}