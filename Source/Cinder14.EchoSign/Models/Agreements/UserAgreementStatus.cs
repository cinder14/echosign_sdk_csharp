namespace Cinder14.EchoSign.Models
{
    public enum UserAgreementStatus
    {
        /// <summary>,
        /// (enum): The agreement has expired,,
        /// </summary>
        EXPIRED,
        /// <summary>,
        /// (enum): The agreement has been signed and filed,,
        /// </summary>
        SIGNED,
        /// <summary>,
        /// (enum): The agreement is waiting for the current participant to approve,,
        /// </summary>
        WAITING_FOR_MY_APPROVAL,
        /// <summary>,
        /// (enum): In the future, statuses other than those above may be added to the Adobe Document Cloud application. For backward compatibility reasons, existing API clients will receive status OTHER. You may need to update your client application to the latest version of the API to receive the new statuses in those cases,,
        /// </summary>
        OTHER,
        /// <summary>,
        /// (enum): The current status of the agreement is unknown,,
        /// </summary>
        UNKNOWN,
        /// <summary>,
        /// (enum): The agreement has been archived,,
        /// </summary>
        ARCHIVED,
        /// <summary>,
        /// (enum): The agreement is out for signature,,
        /// </summary>
        OUT_FOR_SIGNATURE,
        /// <summary>,
        /// (enum): The agreement has been approved,,
        /// </summary>
        APPROVED,
        /// <summary>,
        /// (enum): The agreement is currently hidden,,
        /// </summary>
        HIDDEN,
        /// <summary>,
        /// (enum): The agreement is waiting for the current participant to delegate,,
        /// </summary>
        WAITING_FOR_MY_DELEGATION,
        /// <summary>,
        /// (enum): The agreement is waiting for the current participant to sign,,
        /// </summary>
        WAITING_FOR_MY_SIGNATURE,
        /// <summary>,
        /// (enum): The agreement is waiting to be authored,,
        /// </summary>
        WAITING_FOR_AUTHORING,
        /// <summary>,
        /// (enum): The agreement is a widget,,
        /// </summary>
        WIDGET,
        /// <summary>,
        /// (enum): The agreement out for approval,,
        /// </summary>
        OUT_FOR_APPROVAL,
        /// <summary>,
        /// (enum): The agreement has been recalled by the sender,,
        /// </summary>
        RECALLED,
        /// <summary>,
        /// (enum): The agreement is a form,,
        /// </summary>
        FORM,
        /// <summary>,
        /// (enum): The agreement is not yet visible to the current participant,,
        /// </summary>
        NOT_YET_VISIBLE,
        /// <summary>,
        /// (enum): The agreement is in the review process,,
        /// </summary>
        IN_REVIEW,
        /// <summary>,
        /// (enum): The agreement is waiting for the current participant to review,,
        /// </summary>
        WAITING_FOR_MY_REVIEW,
        /// <summary>,
        /// (enum): The agreement is incomplete,,
        /// </summary>
        PARTIAL,
        /// <summary>,
        /// (enum): The agreement is waiting for the signature to be faxed-in,
        /// </summary>
        WAITING_FOR_FAXIN
    }
}