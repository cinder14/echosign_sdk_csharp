using Newtonsoft.Json;
using System;

namespace Cinder14.EchoSign.Models
{
    public class ExternalId
    {
        /// <summary>
        /// (string, optional): An arbitrary value from your system, which can be specified at sending time and then later returned or queried,
        /// </summary>
        public virtual string id { get; set; }
        /// <summary>
        /// (string, optional): An arbitrary value from your system, which can be specified at sending time and then later returned or queried,
        /// </summary>
        public virtual string group { get; set; }
        /// <summary>
        ///  (string, optional): Only supported value for the ExternalID namespace at this time is API_OTHER
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        [Obsolete("Only supported value for the ExternalID namespace at this time is API_OTHER, changing is not permitted", true)]
        public virtual string name_space { get { return "API_OTHER"; } set { } }

    }
}