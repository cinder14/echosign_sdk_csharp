namespace Cinder14.EchoSign.Models
{
    public enum ParticipantSecurityOption
    {
        /// <summary>
        ///  (enum): The recipient must enter an access code sent to their phone to view and sign the document,
        /// </summary>
        PHONE,
        /// <summary>
        ///  (enum): In the future, statuses other than those above may be added to the Adobe Document Cloud application. For backward compatibility reasons, existing API clients will receive status OTHER. You may need to update your client application to the latest version of the API to receive the new statuses in those cases,
        /// </summary>
        OTHER,
        /// <summary>
        ///  (enum): The participant must pass Knowledge Based Authentication to view and sign the document,
        /// </summary>
        KBA,
        /// <summary>
        ///  (enum): The participant must provide a web identity to view and sign the document,
        /// </summary>
        WEB_IDENTITY,
        /// <summary>
        ///  (enum): The participant must enter a password to view and sign the document
        /// </summary>
        PASSWORD
    }
}