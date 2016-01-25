namespace Cinder14.EchoSign.Models
{
    public class AgreementCreationInfo
    {
        /// <summary>
        ///  (DocumentCreationInfo): Information about the document you want to send,
        /// </summary>
        public virtual DocumentCreationInfo documentCreationInfo { get; set; }
        /// <summary>
        ///  (InteractiveOptions, optional): Options for authoring and sending the agreement
        /// </summary>
        public virtual InteractiveOptions options { get; set; }
        
    }
}
