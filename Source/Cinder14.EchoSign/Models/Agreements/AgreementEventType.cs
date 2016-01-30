namespace Cinder14.EchoSign.Models
{
    public enum AgreementEventType
    {
        /// <summary>
        /// (enum): The document has been shared by a participant,
        /// </summary>
        SHARED,
        /// <summary>
        /// (enum): Document retention applied - all documents deleted,
        /// </summary>
        DOCUMENTS_DELETED,
        /// <summary>
        /// (enum): Changes have been suggested by the signer on the document,
        /// </summary>
        SIGNER_SUGGESTED_CHANGES,
        /// <summary>
        /// (enum): The Email sent to a signer bounced and was not delivered,
        /// </summary>
        EMAIL_BOUNCED,
        /// <summary>
        /// (enum): The document has been signed,
        /// </summary>
        SIGNED,
        /// <summary>
        /// (enum): In the future, statuses other than those above may be added to the Adobe Document Cloud application. For backward compatibility reasons, existing API clients receive status OTHER. You may need to update your client application to the latest version of the API to receive the new statuses in those cases,
        /// </summary>
        OTHER,
        /// <summary>
        /// (enum): The document has been approved,
        /// </summary>
        APPROVED,
        /// <summary>
        /// (enum): The document automatically expired,
        /// </summary>
        EXPIRED_AUTOMATICALLY,
        /// <summary>
        /// (enum): Document was vaulted,
        /// </summary>
        VAULTED,
        /// <summary>
        /// (enum): The document was digitally Signed,
        /// </summary>
        PRESIGNED,
        /// <summary>
        /// (enum): The document has been sent out for approval,
        /// </summary>
        APPROVAL_REQUESTED,
        /// <summary>
        /// (enum): The document has been eSigned,
        /// </summary>
        ESIGNED,
        /// <summary>
        /// (enum): The document has been delegated by the signer,
        /// </summary>
        DELEGATED,
        /// <summary>
        /// (enum): The agreement has been modified,
        /// </summary>
        AGREEMENT_MODIFIED,
        /// <summary>
        /// (enum): The document has been cancelled because of problems with processing,
        /// </summary>
        AUTO_CANCELLED_CONVERSION_PROBLEM,
        /// <summary>
        /// (enum): The document has been faxed in by the sender on behalf of the signer,
        /// </summary>
        FAXED_BY_SENDER,
        /// <summary>
        /// (enum): Signer failed all password authentication attempts,
        /// </summary>
        PASSWORD_AUTHENTICATION_FAILED,
        /// <summary>
        /// (enum): The document has been digitally Signed,
        /// </summary>
        DIGSIGNED,
        /// <summary>
        /// (enum): Signer successfully verified identity using Knowledge Based Authentication,
        /// </summary>
        KBA_AUTHENTICATED,
        /// <summary>
        /// (enum): The document has been sent out for signatures,
        /// </summary>
        SIGNATURE_REQUESTED,
        /// <summary>
        /// (enum): The document has expired,
        /// </summary>
        EXPIRED,
        /// <summary>
        /// (enum): The document has been rejected by the signer,
        /// </summary>
        REJECTED,
        /// <summary>
        /// (enum): Signer provided web identity before viewing the document,
        /// </summary>
        WEB_IDENTITY_AUTHENTICATED,
        /// <summary>
        /// (enum): The document has been uploaded by sender,
        /// </summary>
        UPLOADED_BY_SENDER,
        /// <summary>
        /// (enum): Signer provided web identity after viewing the document,
        /// </summary>
        WEB_IDENTITY_SPECIFIED,
        /// <summary>
        /// (enum): The widget was disabled,
        /// </summary>
        WIDGET_DISABLED,
        /// <summary>
        /// (enum): The document has been created,
        /// </summary>
        CREATED,
        /// <summary>
        /// (enum): Offline events have been synchronized and recorded,
        /// </summary>
        OFFLINE_SYNC,
        /// <summary>
        /// (enum): Signer was replaced by the sender,
        /// </summary>
        REPLACED_SIGNER,
        /// <summary>
        /// (enum): The document has been automatically delegated by the signer,
        /// </summary>
        AUTO_DELEGATED,
        /// <summary>
        /// (enum): The widget was enabled,
        /// </summary>
        WIDGET_ENABLED,
        /// <summary>
        /// (enum): The document has been viewed,
        /// </summary>
        EMAIL_VIEWED,
        /// <summary>
        /// (enum): The document has been cancelled by the sender,
        /// </summary>
        RECALLED,
        /// <summary>
        /// (enum): The faxed-in signature has been received,
        /// </summary>
        FAXIN_RECEIVED,
        /// <summary>
        /// (enum): A new revision of the document has been created,
        /// </summary>
        SENDER_CREATED_NEW_REVISION,
        /// <summary>
        /// (enum): The agreement modification has been acknowledged,
        /// </summary>
        USER_ACK_AGREEMENT_MODIFIED,
        /// <summary>
        /// (enum): Signer failed all Knowledge Based Authentication authentication attempts
        /// </summary>
        KBA_AUTHENTICATION_FAILED
    }
}