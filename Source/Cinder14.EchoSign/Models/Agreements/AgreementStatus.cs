namespace Cinder14.EchoSign.Models
{
    public enum AgreementStatus
    {
        /// <summary>
        /// (enum): The signature workflow has been cancelled by either the sender or the recipient. This is a terminal state,
        /// </summary>
        ABORTED,
        /// <summary>
        /// (enum): The agreement has passed the expiration date and can no longer be signed. This is a terminal state,
        /// </summary>
        EXPIRED,
        /// <summary>
        ///  (enum): The agreement has been signed by all the requested parties. This is a terminal state,
        /// </summary>
        SIGNED,
        /// <summary>
        ///  (enum): The status for agreements that are in the user's template library. This is a terminal state,
        /// </summary>
        DOCUMENT_LIBRARY,
        /// <summary>
        ///  (enum): In the future, statuses other than those above may be added to the Adobe Document Cloud application. For backward compatibility reasons, existing API clients will receive status OTHER. You may need to update your client application to the latest version of the API to receive the new statuses in those cases,
        /// </summary>
        OTHER,
        /// <summary>
        ///  (enum): The agreement uploaded by the user into their document archive. This is a terminal state,
        /// </summary>
        ARCHIVED,
        /// <summary>
        ///  (enum): The agreement is out for signature,
        /// </summary>
        OUT_FOR_SIGNATURE,
        /// <summary>
        ///  (enum): The widget is currently waiting to be verified,
        /// </summary>
        WIDGET_WAITING_FOR_VERIFICATION,
        /// <summary>
        ///  (enum): The agreement has been approved by all requested parties. If agreement has both signers and approvers, terminal status will be signed,
        /// </summary>
        APPROVED,
        /// <summary>
        ///  (enum): The status for the user's widgets. This is a terminal state,
        /// </summary>
        WIDGET,
        /// <summary>
        ///  (enum): The agreement is waiting for the sender to position fields before it can be sent for signature,
        /// </summary>
        AUTHORING,
        /// <summary>
        /// (enum): The agreement is waiting for the sender to fill out fields before it can be sent for signature,
        /// </summary>
        PREFILL,
        /// <summary>
        ///  (enum): The agreement out for approval,
        /// </summary>
        OUT_FOR_APPROVAL,
        /// <summary>
        ///  (enum): The agreement is currently waiting to be reviewed,
        /// </summary>
        WAITING_FOR_REVIEW,
        /// <summary>
        ///  (enum): The agreement is waiting for payment in order to proceed,
        /// </summary>
        WAITING_FOR_PAYMENT,
        /// <summary>
        ///  (enum): The agreement is currently waiting to be verified,
        /// </summary>
        WAITING_FOR_VERIFICATION,
        /// <summary>
        ///  (enum): The agreement is waiting for the sender to fax in the document contents before it can be sent for signature
        /// </summary>
        WAITING_FOR_FAXIN
    }
}