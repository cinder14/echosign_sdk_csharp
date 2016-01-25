namespace Cinder14.EchoSign.Models
{
    public class InteractiveOptions
    {
        /// <summary>
        ///  (boolean, optional): Turn off Chrome for the URL generated,
        /// </summary>
        public virtual bool noChrome { get; set; }
        /// <summary>
        /// (boolean, optional): A url to send page will be returned from where the agreement creation needs to be completed. All the parameters provided here will be retained in the send page,
        /// </summary>
        public virtual bool sendThroughWeb { get; set; }
        /// <summary>
        /// (string, optional): The locale in which page returned by this API should be shown in - for example, en_US or fr_FR. In case locale provided by client is not available or no locale is specified, page will be shown in the default language set in the user account,
        /// </summary>
        public virtual string locale { get; set; }
        /// <summary>
        /// (boolean, optional): Indicates that authoring is requested prior to sending the document,
        /// </summary>
        public virtual bool authoringRequested { get; set; }
        /// <summary>
        ///  (boolean, optional): If user settings allow, automatically logs the user in
        /// </summary>
        public virtual bool autoLoginUser { get; set; }
        /// <summary>
        ///  (SendThroughWebOptions, optional): A JSON object of Type SendThroughWebOptions to customize the sendPage. This one will apply only if sendThroughWeb is set to true,
        /// </summary>
        public virtual SendThroughWebOptions sendThroughWebOptions { get; set; }
        
    }
}