using System.ComponentModel;

namespace Cinder14.EchoSign.Models
{
    public class PostSignOptions
    {
        /// <summary>
        /// (integer, optional): The delay (in seconds) before the user is taken to the success page. 
        /// If this value is greater than 0, the user will first see the standard Adobe Document Cloud success message, and then after a delay will be redirected to your success page.,
        /// </summary>
        [DefaultValue(0)]
        public virtual int redirectDelay { get; set; }
        /// <summary>
        /// (string): A publicly accessible url to which the user will be sent after successfully completing the signing process.
        /// </summary>
        public virtual string redirectUrl { get; set; }
    }
}