using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;

namespace Cinder14.EchoSign.Models
{
    public class DocumentCreationInfo
    {
        public DocumentCreationInfo()
        {
        }
        /// <summary>
        ///  (string) = ['ESIGN' or 'WRITTEN']: Specifies the type of signature you would like to request - written or eSignature. The possible values are ESIGN or WRITTEN,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual SignatureType signatureType { get; set; }
        /// <summary>
        ///  (FileInfo[], optional): Specifies the form field layer template or source of form fields to apply on the files in this transaction. 
        ///  If specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type. 
        ///  Note: Only one of the four parameters in every FileInfo object must be specified,
        /// </summary>
        public virtual FileInfo[] formFieldLayerTemplates { get; set; }
        /// <summary>
        /// (SecurityOption, optional): Sets optional secondary security parameters for your document,
        /// </summary>
        public virtual SecurityOptions securityOptions { get; set; }
        /// <summary>
        ///  (string, optional): A publicly accessible url to which Adobe Document Cloud will do an HTTP GET operation every time there is a new agreement event. 
        ///  HTTP authentication is supported using standard embedded syntax - i.e. http://username:password@your.server.com/path/to/file. Adobe Document Cloud can also ping your system using HTTP PUT with the final signed PDF. Please contact support@echosign.com if you wish to use this option.,
        /// </summary>
        public virtual string callbackInfo { get; set; }
        /// <summary>
        ///  (integer, optional): The number of days that remain before the document expires. You cannot sign the document after it expires,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? daysUntilSigningDeadline { get; set; }
        /// <summary>
        ///  (string, optional): The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. 
        ///  If none specified, defaults to the language configured for the agreement sender,
        /// </summary>
        public virtual string locale { get; set; }

        /// <summary>
        ///  A list of one or more recipient sets. A recipient set may have one or more recipients. 
        ///  If any member of the recipient set signs, the agreement is considered signed by the recipient set. 
        ///  For regular (non-MegaSign) documents, there is no limit on the number of electronic signatures in a single document. 
        ///  Written signatures are limited to four per document. This limit includes the sender if the sender's signature is also required,
        /// </summary>
        public virtual RecipientSetInfo[] recipientSetInfos { get; set; }

        /// <summary>
        /// (string[], optional): A list of one or more email addresses that you want to copy on this transaction. 
        /// The email addresses will each receive an email at the beginning of the transaction and also when the final document is signed. 
        /// The email addresses will also receive a copy of the document, attached as a PDF file,
        /// </summary>
        public virtual string[] ccs { get; set; }

        /// <summary>
        /// (ExternalId, optional): A unique identifier for your transaction from an external system. You can use the ExternalID to search for your transaction through API,
        /// </summary>
        public virtual ExternalId externalId { get; set; }

        /// <summary>
        /// (VaultingInfo, optional): Sets the vaulting properties that allows Adobe Document Cloud to securely store documents with a vault provider,
        /// </summary>
        public virtual VaultingInfo vaultingInfo { get; set; }

        /// <summary>
        /// SignatureFlow = (string, optional) = ['', 'SENDER_SIGNATURE_NOT_REQUIRED' or 'SENDER_SIGNS_LAST' or 'SENDER_SIGNS_FIRST' or 'SEQUENTIAL' or 'PARALLEL']: 
        /// Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the recipient, or not at all. 
        /// Note: leave unspecified for hybrid routing,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual SignatureFlow? signatureFlow { get; set; }

        /// <summary>
        /// (RequestFormField[], optional): Information of form fields of an agreement. 
        /// PDF_SIGNATURE inputType field is currently not supported,
        /// </summary>
        public virtual RequestFormField[] formFields { get; set; }

        /// <summary>
        /// (string, optional): An optional message to the recipients, describing what is being sent or why their signature is required,
        /// </summary>
        public virtual string message { get; set; }

        /// <summary>
        /// (MergefieldInfo[], optional): Optional default values for fields to merge into the document. 
        /// The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. 
        /// Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName.
        /// Only file and url are curently supported,
        /// </summary>
        public virtual MergefieldInfo[] mergeFieldInfo { get; set; }

        /// <summary>
        /// A list of one or more files (or references to files) that will be sent out for signature. 
        /// If more than one file is provided, they will be combined into one PDF before being sent out.
        /// Note: Only one of the four parameters in every FileInfo object must be specified,
        /// </summary>
        public virtual FileInfo[] fileInfos { get; set; }

        /// <summary>
        /// ReminderFrequency => (string, optional) = ['DAILY_UNTIL_SIGNED' or 'WEEKLY_UNTIL_SIGNED']: Optional parameter that sets how often you want to send reminders to the recipients. The possible values are DAILY_UNTIL_SIGNED or WEEKLY_UNTIL_SIGNED,
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ReminderFrequency? reminderFrequency { get; set; }

        /// <summary>
        /// (PostSignOptions, optional): URL and associated properties for the success page the user will be taken to after completing the signing process,
        /// </summary>
        public virtual PostSignOptions postSignOptions { get; set; }

        /// <summary>
        ///  (string): The name of the agreement that will be used to identify it, in emails and on the website
        /// </summary>
        public virtual string name { get; set; }
       
    }
}
