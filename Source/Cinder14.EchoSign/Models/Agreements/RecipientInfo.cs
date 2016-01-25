namespace Cinder14.EchoSign.Models
{
    public class RecipientInfo
    {
        /// <summary>
        /// (RecipientSecurityOption[], optional): Security options that apply to the recipient,
        /// </summary>
        public virtual RecipientSecurityOption[] securityOptions { get; set; }
        /// <summary>
        /// (string): Fax of the recipient. This is required if email is not provided. Both fax and email can not be provided. In case of recipient set having more than one member, fax is not allowed,
        /// </summary>
        public virtual string fax { get; set; }
        /// <summary>
        /// (string): Email of the recipient. This is required if fax is not provided. Both fax and email can not be provided
        /// </summary>
        public virtual string email { get; set; }

    }
}