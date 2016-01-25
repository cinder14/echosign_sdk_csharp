using Newtonsoft.Json;

namespace Cinder14.EchoSign.Models
{
    public class FormFieldCondition
    {
        /// <summary>
        /// (string, optional): Value to compare whenField's value with, to evaluate the condition,
        /// </summary>
        public virtual string value { get; set; }
        /// <summary>
        /// (int, optional): Index of the whenField's location whose value is the basis of the condition,
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? whenFieldLocationIndex { get; set; }
        /// <summary>
        /// (string, optional): Name of the field whose value is the basis of condition
        /// </summary>
        public virtual string whenFieldName { get; set; }
        
    }
}