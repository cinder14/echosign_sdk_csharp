using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Models.TransientDocuments
{
    public class TransientDocumentResponse
    {
        /// <summary>
        ///  (string): The unique identifier of the uploaded document that can be used in an agreement or a megaSign or widget creation call
        /// </summary>
        public string transientDocumentId { get; set; }
    }
}
