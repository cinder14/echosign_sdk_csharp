namespace Cinder14.EchoSign.Models
{
    public enum ParticipantRole
    {
        /// <summary>
        ///  (enum): Sender or originator of the document,
        /// </summary>
        SENDER,
        /// <summary>
        ///  (enum): Participant with whom the document has been shared,
        /// </summary>
        SHARE,
        /// <summary>
        ///  (enum): Signer of the document,
        /// </summary>
        SIGNER,
        /// <summary>
        ///  (enum): In the future, roles other than those above may be added to the Adobe Document Cloud application.For backward compatibility reasons, existing API clients will receive role OTHER.You may need to update your client application to the latest version of the API to receive the new roles in those cases,
        /// </summary>
        OTHER,
        /// <summary>
        ///  (enum): Delegate to signer of the document,
        /// </summary>
        DELEGATE_TO_SIGNER,
        /// <summary>
        ///  (enum): Participant that is bound to the document as an observer, by the sender,
        /// </summary>
        CC,
        /// <summary>
        ///  (enum): Delegate to approver of the document,
        /// </summary>
        DELEGATE_TO_APPROVER,
        /// <summary>
        ///  (enum): Approver of the document,
        /// </summary>
        APPROVER,
        /// <summary>
        ///  (enum): Participant that is delegated to sign the document, by the signer
        /// </summary>
        DELEGATE
    }
}