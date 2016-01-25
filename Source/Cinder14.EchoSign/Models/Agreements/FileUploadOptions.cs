namespace Cinder14.EchoSign.Models
{
    public class FileUploadOptions
    {
        /// <summary>
        ///  (boolean, optional): Whether link to attach documents from web sources like Dropbox should appear or not. Default value is taken as true,
        /// </summary>
        public virtual bool webConnectors { get; set; }
        /// <summary>
        ///  (boolean, optional): Whether library documents link should appear or not. Default value is taken as true,
        /// </summary>
        public virtual bool libraryDocument { get; set; }
        /// <summary>
        ///  (boolean, optional): Whether local file upload button should appear or not. Default value is taken as true
        /// </summary>
        public virtual bool localFile { get; set; }
        
    }
}