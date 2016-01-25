using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Cinder14.EchoSign.Models
{
    public class DocumentLibraryItem
    {
        /// <summary>
        /// (LibraryTemplateType[]): A list of one or more library template types,
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public virtual LibraryTemplateType[] libraryTemplateTypes { get; set; }
        /// <summary>
        /// (DocumentLibraryItemScope): The scope of visibility of the library document,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual DocumentLibraryItemScope scope { get; set; }
        /// <summary>
        ///  (string): The unique identifier of the library document used when sending the document to be signed,
        /// </summary>
        public virtual string libraryDocumentId { get; set; }
        /// <summary>
        /// (string): The name of the library document,
        /// </summary>
        public virtual string name { get; set; }
        /// <summary>
        /// (date): The day on which the library document was last modified
        /// </summary>
        public virtual DateTime modifiedDate { get; set; }
        
    }
}