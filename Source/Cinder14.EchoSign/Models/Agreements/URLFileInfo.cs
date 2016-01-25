namespace Cinder14.EchoSign.Models
{
    public class URLFileInfo
    {
        /// <summary>
        /// (string, optional): The original system file name of the document being sent - used to name attachments, and to infer the mime type if one is not explicitly specified,
        /// </summary>
        public virtual string name { get; set; }
        /// <summary>
        /// (string, optional): A publicly accessible URL for retrieving the raw file content. HTTP authentication is supported using standard embedded syntax - i.e. http://username:password@your.server.com/path/to/file.,
        /// </summary>
        public virtual string url { get; set; }
        /// <summary>
        /// (string, optional): The mime type of the referenced file, used to determine if the file can be accepted and the necessary conversion steps can be performed
        /// </summary>
        public virtual string mimeType { get; set; }
    }
}