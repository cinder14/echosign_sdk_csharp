namespace Cinder14.EchoSign.Models
{
    public enum AuthenticationMethod
    {
        /// <summary>
        /// Authentication won't be used for this recipient
        /// </summary>
        NONE,
        /// <summary>
        /// The recipient must enter an access code sent to their phone to view and sign the document. The user can request the access code via SMS or voice call before signing,
        /// </summary>
        PHONE,
        /// <summary>
        /// The recipient will use the authentication method specified in the securityOptions in DocumentCreationInfo,
        /// </summary>
        INHERITED_FROM_DOCUMENT,
        /// <summary>
        /// The recipient must pass Knowledge Based Authentication to view and sign the document,
        /// </summary>
        KBA,
        /// <summary>
        /// The recipient must provide a web identity to view and sign the document,
        /// </summary>
        WEB_IDENTITY,
        /// <summary>
        /// The recipient must enter a password to view and sign the document,
        /// </summary>
        PASSWORD
    }
}