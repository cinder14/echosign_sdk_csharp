using Cinder14.EchoSign.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.Endpoints
{
    public class LibraryDocumentEndpoint : EndpointBase
    {
        public LibraryDocumentEndpoint(EchoSignSDK api)
            : base(api)
        {

        }

        /// <summary>
        /// Retrieves library documents for a user
        /// </summary>
        public virtual DocumentLibraryItems GetAll()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "libraryDocuments";
            return this.Sdk.Execute<DocumentLibraryItems>(request);
        }
        /// <summary>
        /// Retrieves library documents for a user
        /// </summary>
        public virtual Task<DocumentLibraryItems> GetAllAsync()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "libraryDocuments";
            return this.Sdk.ExecuteAsync<DocumentLibraryItems>(request);
        }

    }
}
