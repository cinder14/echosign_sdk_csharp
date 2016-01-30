namespace Cinder14.EchoSign.Models
{
    /// <summary>
    /// Serialized as String
    /// </summary>
    public enum DocSecurityOption
    {
        /// <summary>
        /// (enum): In the future, options other than those above may be added to the Adobe Document Cloud application. For backward compatibility reasons, existing API clients will receive the option, OTHER. You may need to update your client application to the latest version of the API to receive the new options,
        /// </summary>
        OTHER,
        /// <summary>
        ///  (enum): A password is required to open the document
        /// </summary>
        OPEN_PROTECTED
     }
}