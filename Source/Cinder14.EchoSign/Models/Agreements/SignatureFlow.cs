namespace Cinder14.EchoSign.Models
{
    /// <summary>
    /// Serialized as String
    /// </summary>
    public enum SignatureFlow
    {
        SENDER_SIGNATURE_NOT_REQUIRED = 1,
        SENDER_SIGNS_LAST,
        SENDER_SIGNS_FIRST,
        SEQUENTIAL,
        PARALLEL
    }
}
