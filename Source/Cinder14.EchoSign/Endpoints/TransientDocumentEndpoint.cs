using Cinder14.EchoSign.Models.TransientDocuments;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Endpoints
{
    public class TransientDocumentEndpoint : EndpointBase
    {
        public TransientDocumentEndpoint(EchoSignSDK api)
            : base(api)
        {

        }

        /// <summary>
        /// Uploads a document and obtains the document's ID.
        /// The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. 
        /// The returned transient document ID can be used to refer to the document in api calls like POST /agreements where uploaded file needs to be referred. 
        /// The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. 
        /// You can only upload one file at a time in this request.
        /// </summary>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param>
        /// <param name="filename">A name for the document being uploaded.</param>
        /// <param name="mimeType">The mime type of the document being uploaded. If not specified here then mime type is picked up from the file object. If mime type is not present there either then mime type is inferred from file name extension.</param>
        public virtual TransientDocumentResponse Create(string filename, string mimeType, byte[] file)
        {
            var request = new RestRequest(Method.POST);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.AlwaysMultipartFormData = true;
            request.Resource = "transientDocuments";
            request.AddParameter("File-Name", filename);
            request.AddParameter("Mime-Type", mimeType);
            request.AddFile("File", file, filename);
            return this.Sdk.Execute<TransientDocumentResponse>(request);
        }

        /// <summary>
        /// Uploads a document and obtains the document's ID.
        /// The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. 
        /// The returned transient document ID can be used to refer to the document in api calls like POST /agreements where uploaded file needs to be referred. 
        /// The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. 
        /// You can only upload one file at a time in this request.
        /// </summary>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param>
        /// <param name="filename">A name for the document being uploaded.</param>
        /// <param name="mimeType">The mime type of the document being uploaded. If not specified here then mime type is picked up from the file object. If mime type is not present there either then mime type is inferred from file name extension.</param>
        public virtual Task<TransientDocumentResponse> CreateAsync(string filename, string mimeType, byte[] file)
        {
            var request = new RestRequest(Method.POST);
            request.JsonSerializer = new Serialization.NewtonSoftSerializer();
            request.AlwaysMultipartFormData = true;
            request.Resource = "transientDocuments";
            request.AddParameter("File-Name", filename);
            request.AddParameter("Mime-Type", filename);
            request.AddFile("File", file, filename);
            return this.Sdk.ExecuteAsync<TransientDocumentResponse>(request);
        }
    }
}
