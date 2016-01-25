namespace Cinder14.EchoSign.Models
{
    public class UserInfo
    {
        /// <summary>
        /// (string): The identifier that can be used in group management methods,
        /// </summary>
        public virtual string groupId { get; set; }
        /// <summary>
        ///  (string): The user's email address,
        /// </summary>
        public virtual string email { get; set; }
        /// <summary>
        ///  (string): A unique identifier of the user resource for REST APIs. This identfier can not be used in SOAP APIs,
        /// </summary>
        public virtual string userId { get; set; }
        /// <summary>
        ///  (string): The name of the user's company,
        /// </summary>
        public virtual string company { get; set; }
        /// <summary>
        ///  (string): The user's full name, if available; or their email address
        /// </summary>
        public virtual string fullNameOrEmail { get; set; }
    }
}