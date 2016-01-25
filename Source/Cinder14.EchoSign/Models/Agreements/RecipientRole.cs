namespace Cinder14.EchoSign.Models
{
    public enum RecipientRole
    {
        /// <summary>
        /// Signer,
        /// </summary>
        SIGNER,
        /// <summary>
        /// Delegate to signer,
        /// </summary>
        DELEGATE_TO_SIGNER,
        /// <summary>
        /// Delegate to approver,
        /// </summary>
        DELEGATE_TO_APPROVER,
        /// <summary>
        /// Approver
        /// </summary>
        APPROVER
    }
}