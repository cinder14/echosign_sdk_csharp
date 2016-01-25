using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models
{
    public class FileInfo
    {
        /// <summary>
        /// (string, optional): The documentID as returned from POST /transientDocuments,
        /// </summary>
        public virtual string transientDocumentId { get; set; }
        /// <summary>
        /// (string, optional): The ID for a library document that is available to the sender,
        /// </summary>
        public virtual string libraryDocumentId { get; set; }
        /// <summary>
        /// (string, optional): The name of a library document that is available to the sender,
        /// </summary>
        public virtual string libraryDocumentName { get; set; }
        /// <summary>
        /// (URLFileInfo, optional): File at a public URL location
        /// </summary>
        public virtual URLFileInfo documentURL { get; set; }
        
    }
}
