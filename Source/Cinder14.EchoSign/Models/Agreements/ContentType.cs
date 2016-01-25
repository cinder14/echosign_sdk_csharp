namespace Cinder14.EchoSign.Models
{
    /// <summary>
    /// Serialized as String
    /// </summary>
    public enum ContentType
    {
        UNSPECIFIED = 1,
        DATA,
        SIGNATURE_BLOCK,
        SIGNATURE,
        SIGNER_NAME,
        SIGNER_FIRST_NAME,
        SIGNER_LAST_NAME,
        SIGNER_INITIALS,
        SIGNER_EMAIL,
        SIGNER_TITLE,
        SIGNER_COMPANY,
        SIGNATURE_DATE,
        AGREEMENT_NAME,
        AGREEMENT_MESSAGE,
        TRANSACTION_ID,
        SIGNATURE_STAMP,
        CALC
    }
}