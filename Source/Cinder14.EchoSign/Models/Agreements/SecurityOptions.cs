namespace Cinder14.EchoSign.Models
{
    public class SecurityOptions
    {
        /// <summary>
        /// (string, optional): Specifies if signers are required to enter a password to have access to sign the document. The possible values are NONE, EXTERNAL_USERS, INTERNAL_USERS, or ALL_USERS,
        /// </summary>
        public virtual string passwordProtection { get; set; }
        /// <summary>
        /// (string, optional): Signers need to pass Knowledge Based Authentication before they gain access to view and sign the document. The possible values are NONE, EXTERNAL_USERS, INTERNAL_USERS, or ALL_USERS,
        /// </summary>
        public virtual string kbaProtection { get; set; }
        /// <summary>
        ///  (string, optional): Specifies if signers are required to provide their web identity, before they gain access to view and sign the document. The possible values are NONE, EXTERNAL_USERS, INTERNAL_USERS, or ALL_USERS,
        /// </summary>
        public virtual string webIdentityProtection { get; set; }
        /// <summary>
        ///  (boolean, optional): If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files,
        /// </summary>
        public virtual string protectOpen { get; set; }
        /// <summary>
        ///  (string, optional): The secondary password that will be used to protect signing the document for internal signers. Note that Adobe Document Cloud will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for internal signers or all signers,
        /// </summary>
        public virtual string internalPassword { get; set; }
        /// <summary>
        /// (string, optional): The secondary password that will be used to protect signing the document for external signers. Note that Adobe Document Cloud will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for external signers or all signers,
        /// </summary>
        public virtual string externalPassword { get; set; }
        /// <summary>
        ///  (string, optional): The secondary password that will be used to secure the PDF document. Note that Adobe Document Cloud will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is used only if protectOpen field is set to true
        /// </summary>
        public virtual string openPassword { get; set; }

    }
}