namespace Cinder14.EchoSign.Models
{
    public enum DocumentLibraryItemScope
    {
        /// <summary>
        /// (enum): This library document is shared by another user in the group or account,
        /// </summary>
        SHARED,
        /// <summary>
        /// (enum): This library document is available to all Adobe Document Cloud users,
        /// </summary>
        GLOBAL,
        /// <summary>
        /// (enum): This library document belongs to a specific user
        /// </summary>
        PERSONAL
    }
}