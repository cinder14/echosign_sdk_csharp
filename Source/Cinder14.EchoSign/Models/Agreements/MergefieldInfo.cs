namespace Cinder14.EchoSign.Models
{
    public class MergefieldInfo
    {
        /// <summary>
        /// (string, optional): The name of the field,
        /// </summary>
        public virtual string fieldName { get; set; }
        /// <summary>
        /// (string, optional): The default value of the field
        /// </summary>
        public virtual string defaultValue { get; set; }
    }
}