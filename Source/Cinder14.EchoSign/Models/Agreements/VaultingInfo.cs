namespace Cinder14.EchoSign.Models
{
    public class VaultingInfo
    {
        /// <summary>
        /// (boolean, optional): For accounts set up for document vaulting and the option to enable per agreement, this determines whether the document is to be vaulted
        /// </summary>
        public virtual bool enabled { get; set; }
    }
}