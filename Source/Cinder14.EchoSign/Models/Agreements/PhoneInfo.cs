namespace Cinder14.EchoSign.Models
{
    public class PhoneInfo
    {
        /// <summary>
        /// The phone number required for the recipient to view and sign the document if authentication type is PHONE,
        /// </summary>
        public virtual string phone { get; set; }
        /// <summary>
        /// (string, optional): The phoneInfo country code required for the recipient to view and sign the document if authentication type is PHONE
        /// </summary>
        public virtual string countryCode { get; set; }
    }
}